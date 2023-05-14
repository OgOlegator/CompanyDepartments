using CompanyDepartments.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyDepartments.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department[]
                {
                    new Department { Id = 1, IdParent = 0, Name = "Отдел по обслуживанию клиентов", EmployeeCount = 11 },

                    new Department { Id = 2, IdParent = 1, Name = "Отдел продаж", EmployeeCount = 4 },
                    new Department { Id = 3, IdParent = 2, Name = "Отдел оптовых продаж", EmployeeCount = 2 },
                    new Department { Id = 4, IdParent = 2, Name = "Отдел розничных продаж", EmployeeCount = 2 },

                    new Department { Id = 5, IdParent = 1, Name = "Отдел логистики", EmployeeCount = 7 },
                    new Department { Id = 6, IdParent = 5, Name = "Склад", EmployeeCount = 2 },
                    new Department { Id = 7, IdParent = 5, Name = "Отдел доставки", EmployeeCount = 5 },

                    new Department { Id = 8, IdParent = 0, Name = "Производственный отдел", EmployeeCount = 7 },
                    new Department { Id = 9, IdParent = 8, Name = "Инженерный отдел", EmployeeCount = 4 },
                    new Department { Id = 10, IdParent = 8, Name = "Отдел проверки качества", EmployeeCount = 2 },
                    new Department { Id = 11, IdParent = 8, Name = "Отдел закупок", EmployeeCount = 1 },

                    new Department { Id = 12, IdParent = 0, Name = "Бухгалтерия", EmployeeCount = 2 },
                });
        }
    }
}
