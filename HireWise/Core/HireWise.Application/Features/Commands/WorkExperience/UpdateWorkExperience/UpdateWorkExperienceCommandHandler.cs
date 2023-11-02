using MediatR;

namespace HireWise.Application.Features.Commands.WorkExperience.UpdateWorkExperience
{
    public class UpdateWorkExperienceCommandHandler : IRequestHandler<UpdateWorkExperienceCommandRequest, UpdateWorkExperienceCommandResponse>
    {
        readonly IWorkExperienceWriteRepository _workExperienceWriteRepository;
        readonly IWorkExperienceReadRepository _workExperienceReadRepository;

        public UpdateWorkExperienceCommandHandler(IWorkExperienceWriteRepository workExperienceWriteRepository, IWorkExperienceReadRepository workExperienceReadRepository)
        {
            _workExperienceWriteRepository = workExperienceWriteRepository;
            _workExperienceReadRepository = workExperienceReadRepository;
        }

        public async Task<UpdateWorkExperienceCommandResponse> Handle(UpdateWorkExperienceCommandRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.WorkExperience workExperience = await _workExperienceReadRepository.GetByIdAsync(request.WorkExperienceId);
            workExperience.CompanyName = request.CompanyName;
            workExperience.Departmant = request.Departmant;
            workExperience.Position = request.Position;
            workExperience.WorkDateOfStart = request.WorkDateOfStart;
            workExperience.WorkDateOfEnd = request.WorkDateOfEnd;
            await _workExperienceWriteRepository.SaveAsync();
            return new();
        }
    }
}
