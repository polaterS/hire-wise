﻿using MediatR;

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
                FamilyFirstName = request.FamilyFirstName,
                FamilyLastName = request.FamilyLastName,
                FamilyPhoneNumber = request.FamilyPhoneNumber,
            });
            await _familyWriteRepository.SaveAsync();

            return new();
        }
    }
}
