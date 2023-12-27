using HireWise.Application;
using HireWise.Application.Abstractions.Authentications;
using HireWise.Application.Abstractions.Services;
using HireWise.Domain.Entities.Identity;
using HireWise.Persistence.Context;
using HireWise.Persistence.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HireWise.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<HireWiseDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<HireWiseDbContext>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IExternalAuthentication, AuthService>();
            services.AddScoped<IInternalAuthentication, AuthService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IAuthorizationEndpointService, AuthorizationEndpointService>();

            services.AddScoped<IAddressReadRepository, AddressReadRepository>();
            services.AddScoped<IAddressWriteRepository, AddressWriteRepository>();

            services.AddScoped<IDepartmentReadRepository, DepartmentReadRepository>();
            services.AddScoped<IDepartmentWriteRepository, DepartmentWriteRepository>();

            services.AddScoped<IEmployeeReadRepository, EmployeeReadRepository>();
            services.AddScoped<IEmployeeWriteRepository, EmployeeWriteRepository>();

            services.AddScoped<IFamilyReadRepository, FamilyReadRepository>();
            services.AddScoped<IFamilyWriteRepository, FamilyWriteRepository>();

            services.AddScoped<IGenderReadRepository, GenderReadRepository>();
            services.AddScoped<IGenderWriteRepository, GenderWriteRepository>();

            services.AddScoped<ILanguageReadRepository, LanguageReadRepository>();
            services.AddScoped<ILanguageWriteRepository, LanguageWriteRepository>();

            services.AddScoped<IMaritalStatuReadRepository, MaritalStatuReadRepository>();
            services.AddScoped<IMaritalStatuWriteRepository, MaritalStatuWriteRepository>();

            services.AddScoped<ISchoolExperienceReadRepository, SchoolExperienceReadRepository>();
            services.AddScoped<ISchoolExperienceWriteRepository, SchoolExperienceWriteRepository>();

            services.AddScoped<IWorkExperienceReadRepository, WorkExperienceReadRepository>();
            services.AddScoped<IWorkExperienceWriteRepository, WorkExperienceWriteRepository>();

            services.AddScoped<IFileReadRepostiory, FileReadRepository>();
            services.AddScoped<IFileWriteRepostiory, FileWriteRepository>();

            services.AddScoped<IEmployeeImageFileReadRepository, EmployeeImageFileReadRepository>();
            services.AddScoped<IEmployeeImageFileWriteRepository, EmployeeImageFileWriteRepository>();

            services.AddScoped<IMenuReadRepository, MenuReadRepository>();
            services.AddScoped<IMenuWriteRepository, MenuWriteRepository>();

            services.AddScoped<IEndpointReadRepository, EndpointReadRepository>();
            services.AddScoped<IEndpointWriteRepository, EndpointWriteRepository>();

            services.AddScoped<IPositionReadRepository, PositionReadRepository>();
            services.AddScoped<IPositionWriteRepository, PositionWriteRepository>();

            services.AddScoped<IJobPostingReadRepository, JobPostingReadRepository>();
            services.AddScoped<IJobPostingWriteRepository, JobPostingWriteRepository>();

            services.AddScoped<IAnnouncementAndNewsReadRepository, AnnouncementAndNewsReadRepository>();
            services.AddScoped<IAnnouncementAndNewsWriteRepository, AnnouncementAndNewsWriteRepository>();

            services.AddScoped<IEventAndSeminarReadRepository, EventAndSeminarReadRepository>();
            services.AddScoped<IEventAndSeminarWriteRepository, EventAndSeminarWriteRepository>();

            services.AddScoped<IEmployeeReportReadRepository, EmployeeReportReadRepository>();
            services.AddScoped<IEmployeeReportWriteRepository, EmployeeReportWriteRepository>();

            services.AddScoped<IDepartmentReportReadRepository, DepartmentReportReadRepository>();
            services.AddScoped<IDepartmentReportWriteRepository, DepartmentReportWriteRepository>();
        }
    }
}
