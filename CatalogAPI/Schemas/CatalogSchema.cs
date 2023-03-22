using CatalogAPI.Queries;
using GraphQL.Types;

namespace CatalogAPI.Schemas
{
    public class CatalogSchema:Schema
    {
//modified by user3
        public CatalogSchema(IServiceProvider ServiceProvider)
        {
            Query = ServiceProvider.GetRequiredService<CatalogGQLQuery>();
        }
    }
}
