using ReservationApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApi.Infrastructure
{
    public interface IReservationService
    {
        public ReservationDTO GetReservationByBkgNumber(int bkgNumber);
    }
}
