using MediatR;

namespace HireWise.Application.Features.Commands.Family.UpdateFamily
{
    public class UpdateFamilyCommandRequest : IRequest<UpdateFamilyCommandResponse>
    {
        public string Id { get; set; }
        public int EmployeeId { get; set; }
        public string FamilyType { get; set; }
        public string FamilyFirstName { get; set; }
        public string FamilyLastName { get; set; }
        public int FamilyPhoneNumber { get; set; }
    }
}
