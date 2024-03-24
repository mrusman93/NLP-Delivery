namespace NLP_Delivery_WebApplication.DTOS.BrandDTO
{
    public class PostPutBrandDTO
    {
        public string BrandName { get; set; }
        public Byte[] BrandImage { get; set; }
        public string StoreName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
