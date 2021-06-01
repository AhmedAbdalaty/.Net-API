using Domain;
using Microsoft.EntityFrameworkCore;
using Repos.IRepo;
using System.Collections.Generic;
using System.Linq;

namespace Repos.Repo
{
    public class EmployeeRepo : IRepo<Employee>
    {
        private readonly AppDpContext context = new AppDpContext();

        public List<Employee> GetAll() =>
            context.Employees.Include(i => i.Department).AsNoTracking().ToList();

        public Employee GetByID(int id) =>
            context.Employees.Include(i => i.Department).AsNoTracking().FirstOrDefault(x => x.EmpNo == id);

        public void InsertData(Employee item)
        {
            context.Employees.Add(item);
            this.SaveChanges();
        }
        public void RemoveItem(int id)
        {
            var empToRemove = context.Employees.Find(id);
            context.Employees.Remove(empToRemove);
            this.SaveChanges();
        }

        public Employee UpdateData(Employee item)
        {
            context.Employees.Update(item);
            this.SaveChanges();
            return this.GetByID(item.EmpNo);
        }

        public void SaveChanges() => context.SaveChanges();
    }
}
