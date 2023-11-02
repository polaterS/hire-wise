namespace HireWise.Application.Features.Queries.Address.GetByIdAddress
{
    public class GetByIdAddressQueryResponse
    {
        public int EmployeeId { get; set; }
        public string Title { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }
    }
}
