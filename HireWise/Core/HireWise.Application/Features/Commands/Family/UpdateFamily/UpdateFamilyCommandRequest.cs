﻿using MediatR;

namespace HireWise.Application.Features.Commands.Family.UpdateFamily
{
    public class UpdateFamilyCommandRequest : IRequest<UpdateFamilyCommandResponse>
    {
        public string Id { get; set; }
        public int EmployeeId { get; set; }
        public string FamilyType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAlive { get; set; }
    }
}