using Microsoft.EntityFrameworkCore;
using Views_And_Procedures_STEP;
using Views_And_Procedures_STEP.Entities;

using (var context = new AppDbContext())
{
    //var it = new Department { Name = "IT" };
    //var hr = new Department { Name = "HR" };
    //var sales = new Department { Name = "Sales" };

    //context.Departments.AddRange(it, hr, sales);
    //context.SaveChanges();

    //var employees = new List<Employees>
    //{
    //    new Employees { Name = "Ali Aliyev",      Salary = 1200, DepartmentId = it.Id,    IsActive = true  },
    //    new Employees { Name = "Vusal Hasanov",   Salary = 3500, DepartmentId = it.Id,    IsActive = true  },
    //    new Employees { Name = "Nigar Mammadova", Salary = 2800, DepartmentId = it.Id,    IsActive = false },
    //    new Employees { Name = "Kamran Guliyev",  Salary = 3200, DepartmentId = hr.Id,    IsActive = true  },
    //    new Employees { Name = "Aygun Rzayeva",   Salary = 1500, DepartmentId = hr.Id,    IsActive = true  },
    //    new Employees { Name = "Elvin Suleymanov",Salary = 4000, DepartmentId = sales.Id, IsActive = true  },
    //    new Employees { Name = "Leyla Ismayilova",Salary = 3100, DepartmentId = sales.Id, IsActive = true  },
    //    new Employees { Name = "Tural Bagirov",   Salary = 1800, DepartmentId = sales.Id, IsActive = true  },
    //};

    //context.Employees.AddRange(employees);
    //context.SaveChanges();

    //var activeEmployees = context.ActiveEmployees.ToList();

    //foreach (var emp in activeEmployees)
    //{
    //    Console.WriteLine($"ID: {emp.Id} | Employee: {emp.EmpName} | Department: {emp.DepName} | Salary: {emp.Salary}");
    //}

    //int departmentId = 2;

    //var result = await context.EmployeeResults
    //                          .FromSqlInterpolated($"EXEC GetEmployeesByDepartment {departmentId}")
    //                          .ToListAsync();

    //foreach (var emp in result)
    //{
    //    Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Salary}");
    //}

    //int empId = 1;
    //int newSalary = 8500;

    //await context.Database.ExecuteSqlInterpolatedAsync($"EXEC UpdateEmployeeSalary @EmployeeId = {empId}, @NewSalary = {newSalary}");

    //var employee = context.Employees.FirstOrDefault(e => e.Id == empId);

    //if (employee != null)
    //{
    //    Console.WriteLine($"Employee: {employee.Name}, Salary: {employee.Salary}");
    //}
}