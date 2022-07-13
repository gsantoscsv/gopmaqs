using CognizantSoftvision.Maqs.BaseDatabaseTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Linq;
using System.Collections.Generic;


namespace Tests
{
    /// <summary>
    /// Tests test class with VSUnit
    /// </summary>
    [TestClass]
    public class DatabaseTestVSUnit : BaseDatabaseTest
    {
        CRUDOrders crudOrders = new CRUDOrders();
        /// <summary>
        /// Connect to database
        /// </summary>
        [TestMethod]
        public void ConnectToDatabase()
        {
            IDbConnection defaultConn = ConnectionFactory.GetOpenConnection();

            var products = this.DatabaseDriver.Query("SELECT * FROM Products").ToList(); 
            DataTable statesTable = DatabaseUtils.ToDataTable(products);
 
            Assert.AreEqual(products.Count, statesTable.Rows.Count, "Expected 5 products.");
        }

        /// <summary>
        /// Get records as an object
        /// </summary>
        [TestMethod]
        public void GetResultAsAnObject()
        {
            List<Product> table = this.DatabaseDriver.Query<Product>("SELECT * FROM Products").ToList(); 
            Assert.AreEqual(table.Count(), 5, "Expected 5 rows");
        }

        /// <summary>
        /// Execute command using stored procedure
        /// </summary>
        [TestMethod]
        public void InsertProduct()
        {
            Order newOrder = crudOrders.CreateNewOrder();
            long id = this.DatabaseDriver.Insert(newOrder);
            Assert.IsTrue(id > 10);
        }


        [TestMethod]
        public void Update()
        {
            Order order = this.DatabaseDriver.Query<Order>("SELECT * FROM orders").First();
            order.OrderName = "NEW";
            bool updated = this.DatabaseDriver.Update(order);
            Assert.AreEqual(true, updated,"Expected record to be updated.");
        }

        [TestMethod]
        public void Execute()
        {
            int numberOfAffected = this.DatabaseDriver.Execute(crudOrders.ScriptToExecute());
            Assert.AreEqual(1, numberOfAffected,"Expected number of affected 1.");
        }

        [TestMethod]
        public void Delete()
        {
            int numberOfDeleted = this.DatabaseDriver.Execute("Delete from orders where id > 10 ");
            Assert.AreEqual(1, numberOfDeleted, "Expected record to be deleted.");
        } 


    }
}   