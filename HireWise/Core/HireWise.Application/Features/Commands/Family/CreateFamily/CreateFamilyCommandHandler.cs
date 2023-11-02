using MediatR;

namespace HireWise.Application.Features.Commands.Family.CreateFamily
{
    public class CreateFamilyCommandHandler : IRequestHandler<CreateFamilyCommandRequest, CreateFamilyCommandResponse>
    {
        readonly IFamilyWriteRepository _familyWriteRepository;

        public CreateFamilyCommandHandler(IFamilyWriteRepository familyWriteRepository)
        {
            _familyWriteRepository = familyWriteRepository;
        }

        public async Task<CreateFamilyCommandResponse> Handle(CreateFamilyCommandRequest request, CancellationToken cancellationToken)
        {
            await _familyWriteRepository.AddAsync(new()
            {
                EmployeeId = request.EmployeeId,
                FamilyType = request.FamilyType,
                FirstName = request.FirstName,
                LastName = request.LastName,
                IsAlive = request.IsAlive,
            });
            await _familyWriteRepository.SaveAsync();

            return new();
        }
    }
}
