        [HttpGet()]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {

            // Barkode Production List line=montaj hattı,material=sku, barcodeProductionCount= malzeme sayısı
            // Oracle'daki barcode production tablosunu çektik
            var barcodeProductionQuery = new GetBarcodeProductionListQuery();
            barcodeProductionQuery.PageRequest = pageRequest;
            var BarcodeProductionResult = await Mediator.Send(barcodeProductionQuery);


            //materialGroup id,name=malzeme adı -- Sql'deki material tablosunu çektik
            var materialGroupListQuery = new GetMaterialGroupListQuery();
            materialGroupListQuery.PageRequest = pageRequest;
            var materialGroupResult = await Mediator.Send(materialGroupListQuery);


            //materialGroupName=malzeme adı,name=montaj hattı,sku=sku,quantity = 1 ise malzeme sayısı buradan alınacak
            // Exception rule view ini çektik
            var exceptionRuleQuery = new GetVW_ExceptionRuleByLineModelListQuery();
            exceptionRuleQuery.PageRequest = pageRequest;
            var exceptionRuleResult = await Mediator.Send(exceptionRuleQuery);

            //name=montaj hattı,material group id=material adını joinle,quantity = 1 ise malzeme sayısı buradan alınacak
            // General rule view ini çektik
            var generalRuleQuery = new GetVW_GeneralRuleByLineListQuery();
            generalRuleQuery.PageRequest = pageRequest;
            var generalRuleResult = await Mediator.Send(generalRuleQuery);


            // Oracle'daki barcode production tablosu ile Exception rule view ini joinledik
            var dataFromBarcodeJoinExceptionRules = from barcode in BarcodeProductionResult.Items

                                                    join exceptionRule in exceptionRuleResult.Items
                                                    on barcode.Material equals exceptionRule.Name

                                                    where
                                                         exceptionRule.SKU == barcode.Material
                                                    //&&
                                                    //     exceptionRule.Name == barcode.Material
                                                    &&
                                                         exceptionRule.Quantity == 1

                                                    select new
                                                    {
                                                        LineName = barcode.Line,
                                                        MaterialName = exceptionRule.MaterialGroupName,
                                                        MaterialCount = barcode.BarcodeProductionCount,
                                                    };

            // Oracle'daki barcode production tablosu ile Exception rule view ini joinleyince şartlar sağlanamıyorsa
            // general rule tablosu ve material adı için material tablosuyla joinledik

            if (dataFromBarcodeJoinExceptionRules.Count() != 0)
            {
                return Ok(dataFromBarcodeJoinExceptionRules);
            }

            var dataFromBarcodeJoinGeneralRules = from barcode in BarcodeProductionResult.Items

                                                  join generalRule in generalRuleResult.Items
                                                  on barcode.Line equals generalRule.Name
                                                  join material in materialGroupResult.Items
                                                  on generalRule.MaterialGroupId equals material.Id

                                                  where
                                                      generalRule.Name == barcode.Line
                                                  &&
                                                      generalRule.Quantity == 1

                                                  select new
                                                  {
                                                      LineName = barcode.Line,
                                                      MaterialName = material.Name,
                                                      MaterialCount = barcode.BarcodeProductionCount,
                                                  };

            return Ok(dataFromBarcodeJoinGeneralRules);

        }