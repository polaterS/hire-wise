using HireWise.Application.Abstractions.Storage;
using MediatR;

namespace HireWise.Application.Features.Commands.EmployeeImageFile.UploadEmployeeImage
{
    public class UploadEmployeeImageCommandHandler : IRequestHandler<UploadEmployeeImageCommandRequest, UploadEmployeeImageCommandResponse>
    {
        readonly IStorageService _storageService;
        readonly IEmployeeReadRepository _employeeReadRepository;
        readonly IEmployeeImageFileWriteRepository _employeeImageFileWriteRepository;

        public UploadEmployeeImageCommandHandler(IStorageService storageService, IEmployeeReadRepository employeeReadRepository, IEmployeeImageFileWriteRepository employeeImageFileWriteRepository)
        {
            _storageService = storageService;
            _employeeReadRepository = employeeReadRepository;
            _employeeImageFileWriteRepository = employeeImageFileWriteRepository;
        }

        public async Task<UploadEmployeeImageCommandResponse> Handle(UploadEmployeeImageCommandRequest request, CancellationToken cancellationToken)
        {
            List<(string fileName, string pathOrContainerName)> result = await _storageService.UploadAsync("photo-images", request.Files);


            Domain.Entities.Employee employee = await _employeeReadRepository.GetByIdAsync(request.Id);


            await _employeeImageFileWriteRepository.AddRangeAsync(result.Select(r => new Domain.Entities.EmployeeImageFile
            {
                FileName = r.fileName,
                Path = r.pathOrContainerName,
                Storage = _storageService.StorageName,
            }).ToList());

            await _employeeImageFileWriteRepository.SaveAsync();

            return new();
        }
    }
}
