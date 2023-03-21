using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CatalogAPI.Models
{
    //user2 modifying the code
    // add sub catalog name

    [Table("Catalog")]
    public class Catalog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
<<<<<<< HEAD
        //CatalogId add length constraint by user3
=======
        //rename catalogId by user2
>>>>>>> 09289b163d01b008dcbcbfe5df1cd1f557a9c0b2
        [Column("Catalog_Id")]
        public long CatalogId { get; set; }
<<<<<<< HEAD
        //modified by user3
=======
//modified by user2
>>>>>>> c2b467949fecfe9549563191d974e0aad3bb9b98
        [Column("Catalog_Name")]
        [Required]
        [StringLength(50)]
        //user3 modifying property
        // add additional constraints to CatalogName
        public string? CatalogName { get; set; }

        //[JsonIgnore]       
       // public Collection<Product> ProductList { get; set; }


    }
}
