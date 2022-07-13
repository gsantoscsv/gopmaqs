using Dapper.Contrib.Extensions;

namespace Tests
{
    /// <summary>
    /// Class representing the product table.
    /// </summary>
    [Table("products")]
    public class Product
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string ProductName { get; set; }
    }

    [Table("orders")]
    public class Order
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets order id.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets the order name.
        /// </summary>
        public string OrderName { get; set; }

        /// <summary>
        /// Gets or sets the product id
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the user id
        /// </summary>
        public int UserId { get; set; }
    }

}
