using ReservationApi.Infrastructure;
using ReservationApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApi.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetReservationByBkgNumber(int bkgNumber)
        {
            return new ReservationDTO
            {
                Id=new Random().Next(100),
                Amount=new Random().Next(100,1000),
                BkgDate=DateTime.Now,
                CheckinDate=DateTime.Now.AddDays(20),
                CheckoutDate=DateTime.Now.AddDays(27),
                BkgNumber = bkgNumber
            };
        }
    }
}
