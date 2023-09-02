namespace API_SpreadBible.Models
{
    public class AddChurchRequest
    {
        public string ChurchName { get; set; }
        public string ChurchAddress { get; set; }
        public string ChurchCEP { get; set; }
        public string ChurchUF { get; set; }
        public string ChurchTel { get; set; }
    }
}
