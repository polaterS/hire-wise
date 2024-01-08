using MediatR;

namespace HireWise.Application.Features.Commands.Family.UpdateFamily
{
    public class UpdateFamilyCommandHandler : IRequestHandler<UpdateFamilyCommandRequest, UpdateFamilyCommandResponse>
    {
        readonly IFamilyWriteRepository _familyWriteRepository;
        readonly IFamilyReadRepository _familyReadRepository;

        public UpdateFamilyCommandHandler(IFamilyWriteRepository familyWriteRepository, IFamilyReadRepository familyReadRepository)
        {
            _familyWriteRepository = familyWriteRepository;
            _familyReadRepository = familyReadRepository;
        }

        public async Task<UpdateFamilyCommandResponse> Handle(UpdateFamilyCommandRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.Family family = await _familyReadRepository.GetByIdAsync(request.Id);
            family.EmployeeId = request.EmployeeId;
            family.FirstName = request.FirstName;
            family.LastName = request.LastName;
            family.FamilyType = request.FamilyType;
            family.FamilyPhoneNumber = request.FamilyPhoneNumber;
            await _familyWriteRepository.SaveAsync();
            return new();
        }
    }
}
