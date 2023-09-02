using Microsoft.EntityFrameworkCore.Metadata.Internal;

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