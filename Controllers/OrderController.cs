using Microsoft.AspNetCore.Mvc;
using UnitOfShop.Models;
using UnitOfShop.Repositories;
using UnitOfShop.Repositories.Interfaces;

namespace UnitOfShop.Controllers
{
    [Route("v1/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {


        [HttpPost]
        [Route("")]
        public Order Post(
            [FromServices]ICustomerRepository customerRepository,
            [FromServices]IOrderRepository orderRepository,
            [FromServices]IUnitOfWork uow
        )
        {
            try
            {
                var customer = new Customer{ Name = "matheus bertho"};
                var order = new Order{Number = "1324", Custumer = customer};
                
                customerRepository.Save(customer);
                orderRepository.Save(order);

                uow.Commit();

                return order;
            }
            catch (System.Exception)
            {
                uow.RollBack();
                return null;
            }
        }

    }
}