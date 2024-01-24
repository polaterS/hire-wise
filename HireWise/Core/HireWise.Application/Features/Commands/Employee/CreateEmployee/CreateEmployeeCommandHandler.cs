using HireWise.Application.Dto;
using MediatR;

namespace HireWise.Application.Features.Commands.Employee.CreateEmployee
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommandRequest, CreateEmployeeCommandResponse>
    {
        readonly IEmployeeWriteRepository _employeeWriteRepository;

        public CreateEmployeeCommandHandler(IEmployeeWriteRepository employeeWriteRepository)
        {
            _employeeWriteRepository = employeeWriteRepository;
        }

        public async Task<CreateEmployeeCommandResponse> Handle(CreateEmployeeCommandRequest request, CancellationToken cancellationToken)
        {

            var newEmployee = new HireWise.Domain.Entities.Employee();

            if (request.FirstName != null)
                newEmployee.FirstName = request.FirstName;

            if (request.LastName != null)
                newEmployee.LastName = request.LastName;

            if (request.Email != null)
                newEmployee.Email = request.Email;

            if (request.Phone != null)
                newEmployee.Phone = request.Phone;

            if (request.DateOfBirth != null)
                newEmployee.DateOfBirth = request.DateOfBirth;

            if (request.CitizenshipNumber != null)
                newEmployee.CitizenshipNumber = request.CitizenshipNumber;

            if (request.DepartmentId.HasValue)
                newEmployee.DepartmentId = request.DepartmentId.Value;

            if (request.GenderId.HasValue)
                newEmployee.GenderId = request.GenderId.Value;

            if (request.MaritalStatuId.HasValue)
                newEmployee.MaritalStatuId = request.MaritalStatuId.Value;

            if (request.PositionId.HasValue)
                newEmployee.PositionId = request.PositionId.Value;

            // EmployeeImageFiles mapping could be added here similar to other properties

            if (request.Languages != null)
                newEmployee.Languages = MapLanguages(request.Languages);

            if (request.Addresses != null)
                newEmployee.Addresses = MapAddresses(request.Addresses);

            if (request.Families != null)
                newEmployee.Families = MapFamilies(request.Families);

            if (request.SchoolExperiences != null)
                newEmployee.SchoolExperiences = MapSchoolExperiences(request.SchoolExperiences);

            if (request.WorkExperiences != null)
                newEmployee.WorkExperiences = MapWorkExperiences(request.WorkExperiences);

            await _employeeWriteRepository.AddAsync(newEmployee);
            await _employeeWriteRepository.SaveAsync();

            return new();
        }


        //private ICollection<HireWise.Domain.Entities.EmployeeImageFile> MapEmployeeImageFiles(List<EmployeeImageFileDto> dtos)
        //{
        //    if (dtos == null) return null; 

        //    return dtos.Select(dto => new HireWise.Domain.Entities.EmployeeImageFile
        //    {
        //        FileName = dto.FileName,
        //        Path = dto.Path,
        //        Storage = dto.Storage,
        //        EmployeeId = dto.EmployeeId
        //    }).ToList();
        //}
        private ICollection<Domain.Entities.Language> MapLanguages(List<LanguageDto> dtos)
        {
            if (dtos == null) return null; // Null kontrolü

            return dtos.Select(dto => new Domain.Entities.Language
            {
                LanguageEnum = dto.LanguageEnum,
                ProficiencyLevel = dto.ProficiencyLevel
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
