using MediatR;

namespace HireWise.Application.Features.Commands.Family.CreateFamily
{
    public class CreateFamilyCommandRequest : IRequest<CreateFamilyCommandResponse>
    {
        public int EmployeeId { get; set; }
        public string FamilyType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FamilyPhoneNumber { get; set; }
    }
}
