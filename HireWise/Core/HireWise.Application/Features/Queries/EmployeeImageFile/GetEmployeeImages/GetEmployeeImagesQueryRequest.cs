using MediatR;

namespace HireWise.Application.Features.Queries.EmployeeImageFile.GetEmployeeImages
{
    public class GetEmployeeImagesQueryRequest : IRequest<List<GetEmployeeImagesQueryResponse>>
    {
        public string Id { get; set; }
    }
}
