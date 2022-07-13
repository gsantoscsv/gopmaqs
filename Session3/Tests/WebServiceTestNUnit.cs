using CognizantSoftvision.Maqs.BaseWebServiceTest;
using System.Collections.Generic;
using NUnit.Framework;
using WebServiceModel;

namespace Tests
{
    /// <summary>
    /// Simple web service test class using NUnit
    /// </summary>
    [TestFixture]
    public class WebServiceTestNUnit : BaseWebServiceTest
    {
        /// <summary>
        /// Get single product as XML
        /// </summary>
        [Test]
        public void GetXmlDeserializedNUnit()
        {
            ProductXml result = this.WebServiceDriver.Get<ProductXml>("/api/XML_JSON/GetProduct/1", "application/xml", false);

            Assert.AreEqual(1, result.Id, "Expected to get product 1");
        }

        /// <summary>
        /// Get single product as Json
        /// </summary>
        [Test]
        public void GetJsonDeserializedNUnit()
        {
            ProductJson result = this.WebServiceDriver.Get<ProductJson>("/api/XML_JSON/GetProduct/1", "application/json", false);

            Assert.AreEqual(1, result.Id, "Expected to get product 1");
        }

        /// <summary>
        /// Get all products as Json
        /// </summary>
        [Test]
        public void GetArrayOfProductsNUnitJson()
        {
            ProductJson[] arrayOfProducts = new ProductJson[3];
            arrayOfProducts = this.WebServiceDriver.Get<ProductJson[]>("/api/XML_JSON/GetAllProducts", "application/json", false);
            Assert.AreEqual(3, arrayOfProducts.Length, "Expected to get all products");
        }
    }
}
