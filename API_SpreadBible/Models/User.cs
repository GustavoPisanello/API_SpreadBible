using System.ComponentModel.DataAnnotations.Schema;

namespace API_SpreadBible.Models
{
    public class User
    {
        public int IdUser { get; set; }

        public string Name { get; set; }
        public string UserEmail { get; set; }

        public string UserPassword {get;set;}

        [ForeignKey("ChurchId")]
       public Guid FavChurch { get; set;} 
    }

}
