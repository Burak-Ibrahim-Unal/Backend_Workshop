using OOP_Test13_v2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Test13_v2.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign c);
        void Delete(Campaign c);
        void Update(Campaign c);
    }
}
