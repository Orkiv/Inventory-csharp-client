/* 
 * InventoryAPI
 *
 * Orkiv Inventory API client 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DefaultApiTests
    {
        private DefaultApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DefaultApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' DefaultApi
            Assert.IsInstanceOfType(typeof(DefaultApi), instance, "instance is a DefaultApi");
        }

        
        /// <summary>
        /// Test AllGet
        /// </summary>
        [Test]
        public void AllGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AllGet();
            //Assert.IsInstanceOf<List<InventoryGroup>> (response, "response is List<InventoryGroup>");
        }
        
        /// <summary>
        /// Test CategoriesDelete
        /// </summary>
        [Test]
        public void CategoriesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.CategoriesDelete(id);
            //Assert.IsInstanceOf<Response> (response, "response is Response");
        }
        
        /// <summary>
        /// Test CategoriesPost
        /// </summary>
        [Test]
        public void CategoriesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Dictionary query = null;
            //var response = instance.CategoriesPost(query);
            //Assert.IsInstanceOf<List<Category>> (response, "response is List<Category>");
        }
        
        /// <summary>
        /// Test CategoriesPut
        /// </summary>
        [Test]
        public void CategoriesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Category category = null;
            //var response = instance.CategoriesPut(id, category);
            //Assert.IsInstanceOf<Category> (response, "response is Category");
        }
        
        /// <summary>
        /// Test ItemAddPost
        /// </summary>
        [Test]
        public void ItemAddPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Item item = null;
            //var response = instance.ItemAddPost(item);
            //Assert.IsInstanceOf<Item> (response, "response is Item");
        }
        
        /// <summary>
        /// Test ItemAddbulkPost
        /// </summary>
        [Test]
        public void ItemAddbulkPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<Item> items = null;
            //var response = instance.ItemAddbulkPost(items);
            //Assert.IsInstanceOf<Response> (response, "response is Response");
        }
        
        /// <summary>
        /// Test ItemDelete
        /// </summary>
        [Test]
        public void ItemDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ItemDelete(id);
            //Assert.IsInstanceOf<Response> (response, "response is Response");
        }
        
        /// <summary>
        /// Test ItemPut
        /// </summary>
        [Test]
        public void ItemPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Dictionary item = null;
            //var response = instance.ItemPut(id, item);
            //Assert.IsInstanceOf<Response> (response, "response is Response");
        }
        
        /// <summary>
        /// Test ItemsCountPost
        /// </summary>
        [Test]
        public void ItemsCountPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Dictionary query = null;
            //var response = instance.ItemsCountPost(query);
            //Assert.IsInstanceOf<decimal?> (response, "response is decimal?");
        }
        
        /// <summary>
        /// Test ItemsPost
        /// </summary>
        [Test]
        public void ItemsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Dictionary query = null;
            //var response = instance.ItemsPost(query);
            //Assert.IsInstanceOf<List<Item>> (response, "response is List<Item>");
        }
        
        /// <summary>
        /// Test ItemsallfieldsPost
        /// </summary>
        [Test]
        public void ItemsallfieldsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Dictionary query = null;
            //var response = instance.ItemsallfieldsPost(query);
            //Assert.IsInstanceOf<List<Dictionary>> (response, "response is List<Dictionary>");
        }
        
        /// <summary>
        /// Test OrdersPost
        /// </summary>
        [Test]
        public void OrdersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Dictionary query = null;
            //var response = instance.OrdersPost(query);
            //Assert.IsInstanceOf<List<Order>> (response, "response is List<Order>");
        }
        
        /// <summary>
        /// Test QueryPost
        /// </summary>
        [Test]
        public void QueryPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? page = null;
            //string categoryid = null;
            //string sort = null;
            //string search = null;
            //decimal? minprice = null;
            //decimal? maxprice = null;
            //Dictionary query = null;
            //var response = instance.QueryPost(page, categoryid, sort, search, minprice, maxprice, query);
            //Assert.IsInstanceOf<List<Item>> (response, "response is List<Item>");
        }
        
        /// <summary>
        /// Test QueryallfieldsPost
        /// </summary>
        [Test]
        public void QueryallfieldsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? page = null;
            //string categoryid = null;
            //string sort = null;
            //string search = null;
            //decimal? minprice = null;
            //decimal? maxprice = null;
            //Dictionary query = null;
            //var response = instance.QueryallfieldsPost(page, categoryid, sort, search, minprice, maxprice, query);
            //Assert.IsInstanceOf<List<Dictionary>> (response, "response is List<Dictionary>");
        }
        
        /// <summary>
        /// Test ServicesDelete
        /// </summary>
        [Test]
        public void ServicesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ServicesDelete(id);
            //Assert.IsInstanceOf<Response> (response, "response is Response");
        }
        
        /// <summary>
        /// Test ServicesGet
        /// </summary>
        [Test]
        public void ServicesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ServicesGet();
            //Assert.IsInstanceOf<List<Service>> (response, "response is List<Service>");
        }
        
        /// <summary>
        /// Test ServicesPost
        /// </summary>
        [Test]
        public void ServicesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Service service = null;
            //var response = instance.ServicesPost(service);
            //Assert.IsInstanceOf<Service> (response, "response is Service");
        }
        
        /// <summary>
        /// Test ServicesPut
        /// </summary>
        [Test]
        public void ServicesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Service service = null;
            //var response = instance.ServicesPut(id, service);
            //Assert.IsInstanceOf<Response> (response, "response is Response");
        }
        
        /// <summary>
        /// Test WriteDelete
        /// </summary>
        [Test]
        public void WriteDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.WriteDelete(id);
            //Assert.IsInstanceOf<Response> (response, "response is Response");
        }
        
        /// <summary>
        /// Test WritePost
        /// </summary>
        [Test]
        public void WritePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EventRequest eventRequest = null;
            //var response = instance.WritePost(eventRequest);
            //Assert.IsInstanceOf<Response> (response, "response is Response");
        }
        
    }

}
