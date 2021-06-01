using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class AppDpContext:DbContext
{
    public AppDpContext()
    {
        
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=0NewCompanyDb;Integrated Security=true");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Works_on>().HasKey(i => new { i.ProjectNo, i.EmpNo });

        modelBuilder.Entity<Department>().HasData(new List<Department>()
        {
            new Department(){ DeptNo=1, DeptName="Smart Village Branch", Location=Location.Cairo},
            new Department(){ DeptNo=2, DeptName="Alex Branch", Location=Location.Alexandria},
            new Department(){ DeptNo=3, DeptName="Suez Branch", Location=Location.Suez}
        });

        modelBuilder.Entity<Employee>().HasData(new List<Employee>()
        {
            new Employee(){ EmpNo=1, Fname="Ahmed", Lname="Mahmoud", Salary=10_000, DeptNo=1},
            new Employee(){ EmpNo=2, Fname="Ahmed", Lname="Mostafa", Salary=8_000, DeptNo=1},
            new Employee(){ EmpNo=3, Fname="Belal", Lname="Anan", Salary=8_000, DeptNo=1},
            new Employee(){ EmpNo=4, Fname="Mohamed", Lname="Moslem", Salary=11_000, DeptNo=2},
            new Employee(){ EmpNo=5, Fname="Mona", Lname="Hafez", Salary=12_000, DeptNo=3}
        });

        modelBuilder.Entity<Project>().HasData(new List<Project>()
        {
            new Project(){ ProjectNo=1, ProjectName="Recycle Project", Budget=1_000_000},
            new Project(){ ProjectNo=2, ProjectName="Developing Project", Budget=20_000_000}
        });

        modelBuilder.Entity<Works_on>().HasData(new List<Works_on>() 
        { 
            new Works_on(){ ProjectNo=1, EmpNo=1, Enter_Date=DateTime.Now, Job="Build the project"},
            new Works_on(){ ProjectNo=1, EmpNo=2, Enter_Date=DateTime.Now, Job="Build the plan"},
            new Works_on(){ ProjectNo=1, EmpNo=3, Enter_Date=DateTime.Now, Job="Start the project"},
            new Works_on(){ ProjectNo=2, EmpNo=4, Enter_Date=DateTime.Now, Job="Build the project"},
            new Works_on(){ ProjectNo=2, EmpNo=5, Enter_Date=DateTime.Now, Job="Build the project"}
        });

        base.OnModelCreating(modelBuilder);
    }
    public virtual DbSet<Department> Departments { get; set; }
    public virtual DbSet<Employee> Employees { get; set; }
    public virtual DbSet<Project> Projects { get; set; }
    public virtual DbSet<Works_on> Works_Ons { get; set; }
}
