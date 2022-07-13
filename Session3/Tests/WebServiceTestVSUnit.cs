using CognizantSoftvision.Maqs.BaseWebServiceTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebServiceModel;
using System.Collections.Generic;

namespace Tests
{
    /// <summary>
    /// Simple web service test class using VS unit
    /// </summary>
    [TestClass]
    public class WebServiceTestVSUnit : BaseWebServiceTest
    {
        private const bool ExpectSuccess = false;

        public object Current => throw new System.NotImplementedException();

        /// <summary>
        /// Get single product as XML
        /// </summary>
        [TestMethod]
        public void GetXmlDeserialized()
        {
            ProductXml result = this.WebServiceDriver.Get<ProductXml>("/api/XML_JSON/GetProduct/1", "application/xml", false);

            Assert.AreEqual(1, result.Id, "Expected to get product 1");
        }

        /// <summary>
        /// Get single product as Json
        /// </summary>
        [TestMethod]
        public void GetJsonDeserialized()
        {
            ProductJson result = this.WebServiceDriver.Get<ProductJson>("/api/XML_JSON/GetProduct/1", "application/json", false);

            Assert.AreEqual(1, result.Id, "Expected to get product 1");
        }

        /// <summary>
        /// Get all products as Json
        /// </summary>
        [TestMethod]
        public void GetArrayOfProductsNUnitJson()
        {
            ProductJson[] arrayOfProducts = new ProductJson[3];
            arrayOfProducts = this.WebServiceDriver.Get<ProductJson[]>("/api/XML_JSON/GetAllProducts", "application/json", false);
            Assert.AreEqual(3, arrayOfProducts.Length, "Expected to get all products");
        }

/*         /// <summary>
        /// Get all products and save to an ArrayOfProducts
        /// </summary>
        [TestMethod]
        public void GetArrayOfProductsNUnitXML()
        {
            List<ArrayOfProductXML> result = new List<ArrayOfProductXML>();
            result = this.WebServiceDriver.Get<List<ArrayOfProductXML>>("/api/XML_JSON/GetAllProducts", "application/xml", false);
            Assert.AreEqual(3, result.Count, "Expected to get all products");
        } */
    }
}
