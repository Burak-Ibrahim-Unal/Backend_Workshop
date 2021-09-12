using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public List<Order> GetAllByCustomerId(string customerId)
        {
            return _orderDal.GetAll(o => o.CustomerId == customerId);
        }

        public List<Order> GetAllByEmployeeId(string employeeId)
        {
            return _orderDal.GetAll(o => o.EmployeeId == employeeId);
        }

        public List<Order> GetAllByOrderDate(DateTime orderDate)
        {
            return _orderDal.GetAll(o => o.OrderDate == orderDate);
        }

        public List<Order> GetAllOrders()
        {
            return _orderDal.GetAll();
        }

        public List<OrderDetailDto> GetOrderDetails()
        {
            return _orderDal.GetOrderDetails();
        }
    }
}
