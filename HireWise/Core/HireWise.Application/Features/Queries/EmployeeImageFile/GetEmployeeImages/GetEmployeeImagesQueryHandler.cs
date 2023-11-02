using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HireWise.Application.Features.Queries.EmployeeImageFile.GetEmployeeImages
{
    public class GetEmployeeImagesQueryHandler : IRequestHandler<GetEmployeeImagesQueryRequest, List<GetEmployeeImagesQueryResponse>>
    {
        readonly IEmployeeReadRepository _employeeReadRepository;
        readonly IConfiguration configuration;

        public GetEmployeeImagesQueryHandler(IEmployeeReadRepository employeeReadRepository, IConfiguration configuration)
        {
            _employeeReadRepository = employeeReadRepository;
            this.configuration = configuration;
        }

        public async Task<List<GetEmployeeImagesQueryResponse>> Handle(GetEmployeeImagesQueryRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Employee? employee = await _employeeReadRepository.Table.Include(p => p.EmployeeImageFiles)
                   .FirstOrDefaultAsync(p => p.Id == int.Parse(request.Id));
            return employee?.EmployeeImageFiles.Select(p => new GetEmployeeImagesQueryResponse
            {
                Path = $"{configuration["BaseStorageUrl"]}/{p.Path}",
                FileName = p.FileName,
                Id = p.Id
            }).ToList();
        }
    }
}
