using MediatR;

namespace HireWise.Application.Features.Commands.WorkExperience.CreateWorkExperience
{
    public class CreateWorkExperienceCommandHandler : IRequestHandler<CreateWorkExperienceCommandRequest, CreateWorkExperienceCommandResponse>
    {
        readonly IWorkExperienceWriteRepository _workExperienceWriteRepository;

        public CreateWorkExperienceCommandHandler(IWorkExperienceWriteRepository workExperienceWriteRepository)
        {
            _workExperienceWriteRepository = workExperienceWriteRepository;
        }

        public async Task<CreateWorkExperienceCommandResponse> Handle(CreateWorkExperienceCommandRequest request, CancellationToken cancellationToken)
        {
            await _workExperienceWriteRepository.AddAsync(new()
            {
                EmployeeId = request.EmployeeId,
                CompanyName = request.CompanyName,
                Departmant = request.Departmant,
                Position = request.Position,
                WorkDateOfStart = request.WorkDateOfStart,
                WorkDateOfEnd = request.WorkDateOfEnd
            });
            await _workExperienceWriteRepository.SaveAsync();

            return new();
        }
    }
}
