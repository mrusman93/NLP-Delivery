namespace NLP_Delivery_WebApplication.DTOS.Addresses
{
    public class GetAddressesDTO
    {
        public int AddressID { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
