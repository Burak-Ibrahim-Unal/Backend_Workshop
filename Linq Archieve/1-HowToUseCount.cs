        public async Task<IPaginate<BarcodeProductionListDto>> GetAllBarcodeProductions(int index = 0, int size = 1000000, CancellationToken cancellationToken = default)
        {
            DateTime dateFilter = DateTime.Now.AddDays(-1);

            var result = from barcodeProduction in Context.BarcodeProductions
                         where barcodeProduction.ProdDate >= dateFilter
                         group barcodeProduction by
                         new { barcodeProduction.Line, barcodeProduction.Material } into barcodeProductionGroup
                         //orderby barcodeProductionGroup.Key descending
                         select new BarcodeProductionListDto
                         {
                             Line = barcodeProductionGroup.Key.Line,
                             Material = barcodeProductionGroup.Key.Material,
                             BarcodeProductionCount = barcodeProductionGroup.Count()

                         };


            return await result.ToPaginateAsync(index, size, 0, cancellationToken);
        }