using CatalogAPI.Models;
using GraphQL.Types;
namespace CatalogAPI.Queries
{
    public class CatalogQueryType : ObjectGraphType<Catalog>
    {
//modifying Type by user3
        public CatalogQueryType(){
            Name = "CatalogType";
            Field(_ => _.CatalogId).Description("Catalog Id");
            Field(_ => _.CatalogName).Description("Catalog Name");

        }
                
        
    }
}
