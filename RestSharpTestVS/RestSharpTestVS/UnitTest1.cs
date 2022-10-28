using System;
using System.Threading.Tasks;
using FluentAssertions;
using RestSharp;
using RestSharpTestVS.Models;
using Xunit;
using Xunit.Abstractions;

namespace RestSharpTestVS
{
    public class UnitTest1
    {
        private ITestOutputHelper testOutputHelper;

        public UnitTest1(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public async Task GetOperationTest()
        {
            var restClientOprions = new RestClientOptions
            {
                BaseUrl = new Uri("https://localhost:5001/"),
                RemoteCertificateValidationCallback = (senderobject, certificate, chain, errors) => true
            };

            //Rest client
            var client = new RestClient(restClientOprions);

            //Rest Request
            var request = new RestRequest(resource: "Product/GetProductById/1");

            //Perform GET operation
            var response = await client.GetAsync<Product>(request);

            //Assert
            response?.Name.Should().Be("Keyboard");
        }

        [Fact]
        public async Task GetWithQuerySegmentTest()
        {
            var restClientOptions = new RestClientOptions
            {
                BaseUrl = new Uri("https://localhost:5001/"),
                RemoteCertificateValidationCallback = (senderobject, certificate, chain, errors) => true
            };

            //Rest client
            var client = new RestClient(restClientOptions);

            //Rest Request
            var request = new RestRequest(resource:"Product/GetProductById/{id}");
            request.AddUrlSegment(name:"id", value: 2);

            //Perform GET operation
            var response = await client.GetAsync<Product>(request);

            //Assert
            response?.Price.Should().Be(400);
        }

        [Fact]
        public async Task GetWithQueryParameterTest()
        {
            var restClientOptions = new RestClientOptions
            {
                BaseUrl = new Uri("https://localhost:5001/"),
                RemoteCertificateValidationCallback = (senderobject, certificate, chain, errors) => true
            };

            //Rest client
            var client = new RestClient(restClientOptions);

            //Rest Request
            var request = new RestRequest(resource:"Product/GetProductByIdAndName");
            request.AddQueryParameter("id", 2);
            request.AddQueryParameter("name", "Monitor");

            //Perform GET operation
            var response = await client.GetAsync<Product>(request);

            //Assert
            response?.Price.Should().Be(400);
        }

        [Fact]
        public async Task PostProductTest()
        {
            var restClientOprions = new RestClientOptions
            {
                BaseUrl = new Uri("https://localhost:5001/"),
                RemoteCertificateValidationCallback = (senderobject, certificate, chain, errors) => true
            };

            //Rest client
            var client = new RestClient(restClientOprions);

            //Rest Request
            var request = new RestRequest(resource:"Product/Create");
            request.AddJsonBody(new Product
            {
                Name = "Cabinet",
                Description = "Gaming Cabinet",
                Price = 300,
                ProductType = ProductType.PERIPHARALS,
            });
           
            //Perform Post operation
            var response = await client.PostAsync<Product>(request);

            //Assert
            response?.Price.Should().Be(300);
        }
    }
}