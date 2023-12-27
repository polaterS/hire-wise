using HireWise.Domain.Entities;
using HireWise.Domain.Entities.Common;
using HireWise.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HireWise.Persistence.Context
{
    public class HireWiseDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public HireWiseDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<MaritalStatu> MaritalStatus { get; set; }
        public DbSet<SchoolExperience> SchoolExperiences { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<Domain.Entities.File> Files { get; set; }
        public DbSet<EmployeeImageFile> EmployeeImageFiles { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Endpoint> Endpoints { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<AnnouncementAndNews> AnnouncementAndNews { get; set; }
        public DbSet<EventAndSeminar> EventAndSeminars { get; set; }
        public DbSet<JobPosting> JobPosts { get; set; }
        public DbSet<EmployeeReport> EmployeeReport { get; set; }
        public DbSet<DepartmentReport> DepartmentReport { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
