using HireWise.Application.Dto;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HireWise.Application.Features.Queries.Employee.GetByIdEmployee
{
    public class GetByIdEmployeeQueryHandler : IRequestHandler<GetByIdEmployeeQueryRequest, GetByIdEmployeeQueryResponse>
    {
        readonly IEmployeeReadRepository _employeeReadRepository;
        readonly ILanguageReadRepository _languageReadRepository;
        readonly IAddressReadRepository _addressReadRepository;
        readonly IFamilyReadRepository _familyReadRepository;
        readonly ISchoolExperienceReadRepository _schoolExperienceReadRepository;
        readonly IWorkExperienceReadRepository _workExperienceReadRepository;

        public GetByIdEmployeeQueryHandler(
            IEmployeeReadRepository employeeReadRepository,
            ILanguageReadRepository languageReadRepository,
            IAddressReadRepository addressReadRepository,
            IFamilyReadRepository familyReadRepository,
            ISchoolExperienceReadRepository schoolExperienceReadRepository,
            IWorkExperienceReadRepository workExperienceReadRepository
        )
        {
            _employeeReadRepository = employeeReadRepository;
            _languageReadRepository = languageReadRepository;
            _addressReadRepository = addressReadRepository;
            _familyReadRepository = familyReadRepository;
            _schoolExperienceReadRepository = schoolExperienceReadRepository;
            _workExperienceReadRepository = workExperienceReadRepository;
        }

        public async Task<GetByIdEmployeeQueryResponse> Handle(GetByIdEmployeeQueryRequest request, CancellationToken cancellationToken)
        {
            var employee = await _employeeReadRepository.GetByIdAsync(request.Id, false);

            var languages = await _languageReadRepository.GetWhere(l => l.EmployeeId == employee.Id).ToListAsync();
            var addresses = await _addressReadRepository.GetWhere(a => a.EmployeeId == employee.Id).ToListAsync();
            var families = await _familyReadRepository.GetWhere(f => f.EmployeeId == employee.Id).ToListAsync();
            var schoolExperiences = await _schoolExperienceReadRepository.GetWhere(s => s.EmployeeId == employee.Id).ToListAsync();
            var workExperiences = await _workExperienceReadRepository.GetWhere(w => w.EmployeeId == employee.Id).ToListAsync();


            return new GetByIdEmployeeQueryResponse
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                Phone = employee.Phone,
                DateOfBirth = employee.DateOfBirth,
                CitizenshipNumber = employee.CitizenshipNumber,

                DepartmentId = employee.DepartmentId,
                GenderId = employee.GenderId,
                MaritalStatuId = employee.MaritalStatuId,
                PositionId = employee.PositionId,

                Languages = languages.Select(l => new LanguageDto {
                    LanguageEnum = l.LanguageEnum,
                    ProficiencyLevel = l.ProficiencyLevel
                }).ToList(),

                Addresses = addresses.Select(a => new AddressDto {
                    Title = a.Title,
                    Street = a.Street,
                    City = a.City,
                    Country = a.Country,
                    PostalCode = a.PostalCode
                }).ToList(),

                Families = families.Select(f => new FamilyDto {
                    FamilyType = f.FamilyType,
                    FamilyFirstName = f.FamilyFirstName,
                    FamilyLastName = f.FamilyLastName,
                    FamilyPhoneNumber = f.FamilyPhoneNumber
                }).ToList(),

                SchoolExperiences = schoolExperiences.Select(s => new SchoolExperienceDto {
                    SchoolName = s.SchoolName,
                    SchoolType = s.SchoolType,
                    Grade = s.Grade,
                    SchoolDateOfStartOnUtc = s.SchoolDateOfStartOnUtc,
                    SchoolDateOfEndOnUtc = s.SchoolDateOfEndOnUtc
                }).ToList(),

                WorkExperiences = workExperiences.Select(w => new WorkExperienceDto {
                    CompanyName = w.CompanyName,
                    Departmant = w.Departmant,
                    Position = w.Position,
                    WorkDateOfStart = w.WorkDateOfStart,
                    WorkDateOfEnd = w.WorkDateOfEnd
                }).ToList(),
            };


        }
    }
}