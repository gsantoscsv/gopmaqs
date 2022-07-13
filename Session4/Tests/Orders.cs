
namespace Tests
{
    public class CRUDOrders
    {
        public Order CreateNewOrder()
        {
            var order = new Order {
                OrderId = 143,
                OrderName = "ByGladys",
                ProductId = 1,
                UserId = 1
            };
            return order;
        }

        public string ScriptToExecute()
        {
            string script = $"Update orders SET OrderName = 'NEW ORDER' where id = 1";
            return script;
        }
    }
}