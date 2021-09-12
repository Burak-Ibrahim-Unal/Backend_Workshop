using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();
        List<Order> GetAllByCustomerId(string customerId);
        List<Order> GetAllByEmployeeId(int employeeId);
        List<Order> GetAllByOrderDate(DateTime orderDate);
        List<OrderDetailDto> GetOrderDetails();
    }
}
