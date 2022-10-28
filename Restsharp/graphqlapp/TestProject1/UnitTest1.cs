using FluentAssertions;
using GraphQL;
using GraphQL.Client.Abstractions;
using GraphQL.Client.Abstractions.Websocket;
using GraphQL.Client.Http;
using GraphQLProductApp.Data;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly IGraphQLClient _graphQLClient;
        public UnitTest1(IGraphQLClient graphQLClient)
        {
            _graphQLClient = graphQLClient;
        }

        [Fact]
        public async void Test1()
        {
            //Request -query
            var query = new GraphQLRequest
            {
                Query = @"{
                            products {
                                name
                                price
                                components{
                                    id
                                    name
                                    }
                                }
                            }"
            };

            var response = await _graphQLClient.SendQueryAsync<ProductQueryResponse>(query);
            response.Data.Products.Should().Contain(c => c.Name == "keyboard");
        }

        private IGraphQLWebsocketJsonSerializer NewTonsoftJasonSerializer()
        {
            throw new NotImplementedException();
        }
    }

    public class ProductQueryResponse
    {
        public IEnumerable<Product> Products { get; set; }
    }
}