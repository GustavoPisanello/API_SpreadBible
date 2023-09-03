using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_SpreadBible.Models
{
    public class Church
    {
        public Guid ChurchId { get; set; }
        public string ChurchName { get; set; }
        public string ChurchAddress { get; set; }
        public  string ChurchCEP { get; set; }
        public string ChurchUF { get; set; }
        public string ChurchTel { get; set; }
    }
    
}