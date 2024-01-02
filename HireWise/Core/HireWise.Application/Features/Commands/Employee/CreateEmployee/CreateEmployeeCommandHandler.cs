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
            await _employeeWriteRepository.AddAsync(new()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Phone = request.Phone,
                DateOfBirth = request.DateOfBirth,
                CitizenshipNumber = request.CitizenshipNumber,
                DepartmentId = request.DepartmentId,
                GenderId = request.GenderId,
                MaritalStatuId = request.MaritalStatuId,
                PositionId = request.PositionId,
                //EmployeeImageFiles = MapEmployeeImageFiles(request.EmployeeImageFiles),
                Languages = MapLanguages(request.Languages),
                Addresses = MapAddresses(request.Addresses),
                Families = MapFamilies(request.Families),
                SchoolExperiences = MapSchoolExperiences(request.SchoolExperiences),
                WorkExperiences = MapWorkExperiences(request.WorkExperiences),
            });
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
                Name = dto.Name,
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
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                IsAlive = dto.IsAlive
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
