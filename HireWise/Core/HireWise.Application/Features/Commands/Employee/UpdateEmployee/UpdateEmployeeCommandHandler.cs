using HireWise.Application.Dto;
using HireWise.Domain.Entities;
using MediatR;

namespace HireWise.Application.Features.Commands.Employee.UpdateEmployee
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommandRequest, UpdateEmployeeCommandResponse>
    {
        readonly IEmployeeReadRepository _employeeReadRepository;
        readonly IEmployeeWriteRepository _employeeWriteRepository;

        public UpdateEmployeeCommandHandler(IEmployeeReadRepository employeeReadRepository, IEmployeeWriteRepository employeeWriteRepository)
        {
            _employeeReadRepository = employeeReadRepository;
            _employeeWriteRepository = employeeWriteRepository;
        }

        public async Task<UpdateEmployeeCommandResponse> Handle(UpdateEmployeeCommandRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.Employee employee = await _employeeReadRepository.GetByIdAsync(request.Id);
            if (request.FirstName != null)
                employee.FirstName = request.FirstName;

            if (request.LastName != null)
                employee.LastName = request.LastName;

            if (request.Email != null)
                employee.Email = request.Email;

            if (request.Phone != null)
                employee.Phone = request.Phone;

            if (request.DateOfBirth != null)
                employee.DateOfBirth = request.DateOfBirth;

            if (request.CitizenshipNumber != null)
                employee.CitizenshipNumber = request.CitizenshipNumber;

            if (request.DepartmentId.HasValue)
                employee.DepartmentId = request.DepartmentId.Value;

            if (request.GenderId.HasValue)
                employee.GenderId = request.GenderId.Value;

            if (request.MaritalStatuId.HasValue)
                employee.MaritalStatuId = request.MaritalStatuId.Value;

            if (request.PositionId.HasValue)
                employee.PositionId = request.PositionId.Value;

            if (employee.Languages != null)
                employee.Languages.Clear();
            if (employee.LeaveDays != null)
                employee.LeaveDays.Clear();
            if (employee.Addresses != null)
                employee.Addresses.Clear();
            if (employee.Families != null)
                employee.Families.Clear();
            if (employee.SchoolExperiences != null)
                employee.SchoolExperiences.Clear();
            if (employee.WorkExperiences != null)
                employee.WorkExperiences.Clear();

            if (request.Languages != null)
                employee.Languages = MapLanguages(request.Languages);
            if (request.LeaveDays != null)
                employee.LeaveDays = MapLeaveDays(request.LeaveDays);
            if (request.Addresses != null)
                employee.Addresses = MapAddresses(request.Addresses);
            if (request.Families != null)
                employee.Families = MapFamilies(request.Families);
            if (request.SchoolExperiences != null)
                employee.SchoolExperiences = MapSchoolExperiences(request.SchoolExperiences);
            if (request.WorkExperiences != null)
                employee.WorkExperiences = MapWorkExperiences(request.WorkExperiences);




            await _employeeWriteRepository.SaveAsync();
            return new();
        }

        private ICollection<Domain.Entities.Language> MapLanguages(List<LanguageDto> dtos)
        {
            if (dtos == null) return null; // Null kontrolü

            return dtos.Select(dto => new Domain.Entities.Language
            {
                LanguageEnum = dto.LanguageEnum,
                ProficiencyLevel = dto.ProficiencyLevel
            }).ToList();
        }

        private ICollection<Domain.Entities.EmployeeLeaveDays> MapLeaveDays(List<EmployeeLeaveDaysDto> dtos)
        {
            if (dtos == null) return null; // Null kontrolü

            return dtos.Select(dto => new Domain.Entities.EmployeeLeaveDays
            {
                LeaveStartDate = dto.LeaveStartDate,
                LeaveEndDate = dto.LeaveEndDate,
                LeaveReason = dto.LeaveReason,
                LeaveTypeName = dto.LeaveTypeName,
                LeaveStatusName = dto.LeaveStatusName,
            }).ToList();
        }

        private ICollection<HireWise.Domain.Entities.Address> MapAddresses(List<AddressDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(dto => new HireWise.Domain.Entities.Address
            {
                Title = dto.Title,
                Street = dto.Street,
                City = dto.City,
                Country = dto.Country,
                PostalCode = dto.PostalCode
            }).ToList();
        }

        private ICollection<HireWise.Domain.Entities.Family> MapFamilies(List<FamilyDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(dto => new HireWise.Domain.Entities.Family
            {
                FamilyType = dto.FamilyType,
                FamilyFirstName = dto.FamilyFirstName,
                FamilyLastName = dto.FamilyLastName,
                FamilyPhoneNumber = dto.FamilyPhoneNumber
            }).ToList();
        }

        private ICollection<HireWise.Domain.Entities.SchoolExperience> MapSchoolExperiences(List<SchoolExperienceDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(dto => new HireWise.Domain.Entities.SchoolExperience
            {
                SchoolName = dto.SchoolName,
                SchoolType = dto.SchoolType,
                Grade = dto.Grade,
                SchoolDateOfStartOnUtc = dto.SchoolDateOfStartOnUtc,
                SchoolDateOfEndOnUtc = dto.SchoolDateOfEndOnUtc
            }).ToList();
        }

        private ICollection<HireWise.Domain.Entities.WorkExperience> MapWorkExperiences(List<WorkExperienceDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(dto => new HireWise.Domain.Entities.WorkExperience
            {
                CompanyName = dto.CompanyName,
                Departmant = dto.Departmant,
                Position = dto.Position,
                WorkDateOfStart = dto.WorkDateOfStart,
                WorkDateOfEnd = dto.WorkDateOfEnd
            }).ToList();
        }
    }
}
