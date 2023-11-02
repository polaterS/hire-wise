using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HireWise.Application.Features.Commands.EmployeeImageFile.RemoveEmployeeImage
{
    public class RemoveEmployeeImageCommandHandler : IRequestHandler<RemoveEmployeeImageCommandRequest, RemoveEmployeeImageCommandResponse>
    {

        readonly IEmployeeReadRepository _employeeReadRepository;
        readonly IEmployeeWriteRepository _employeeWriteRepository;

        public RemoveEmployeeImageCommandHandler(IEmployeeReadRepository employeeReadRepository, IEmployeeWriteRepository employeeWriteRepository)
        {
            _employeeReadRepository = employeeReadRepository;
            _employeeWriteRepository = employeeWriteRepository;
        }

        public async Task<RemoveEmployeeImageCommandResponse> Handle(RemoveEmployeeImageCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Employee? employee = await _employeeReadRepository.Table.Include(p => p.EmployeeImageFiles)
                .FirstOrDefaultAsync(p => p.Id == int.Parse(request.Id));

            Domain.Entities.EmployeeImageFile? employeeImageFile = employee?.EmployeeImageFiles.FirstOrDefault(p => p.Id == int.Parse(request.ImageId));

            if (employeeImageFile != null)
                employee?.EmployeeImageFiles.Remove(employeeImageFile);

            await _employeeWriteRepository.SaveAsync();
            return new();
        }
    }
}
