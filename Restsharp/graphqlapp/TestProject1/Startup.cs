using GraphQL.Client.Abstractions;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLTesting
{
    internal class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGraphQLClient>(new GraphQLHttpClient(new Uri("http://localhost:5000/graphql"), 
                new NewtonsoftJsonSerializer()));
        }
    }
}
