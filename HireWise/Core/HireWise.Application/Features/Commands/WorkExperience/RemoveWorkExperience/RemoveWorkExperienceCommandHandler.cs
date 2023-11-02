using MediatR;

namespace HireWise.Application.Features.Commands.WorkExperience.RemoveWorkExperience
{
    public class RemoveWorkExperienceCommandHandler : IRequestHandler<RemoveWorkExperienceCommandRequest, RemoveWorkExperienceCommandResponse>
    {
        readonly IWorkExperienceWriteRepository _workExperienceWriteRepository;

        public RemoveWorkExperienceCommandHandler(IWorkExperienceWriteRepository workExperienceWriteRepository)
        {
            _workExperienceWriteRepository = workExperienceWriteRepository;
        }

        public async Task<RemoveWorkExperienceCommandResponse> Handle(RemoveWorkExperienceCommandRequest request, CancellationToken cancellationToken)
        {
            await _workExperienceWriteRepository.RemoveAsync(request.WorkExperienceId);
            await _workExperienceWriteRepository.SaveAsync();
            return new();
        }
    }
}
