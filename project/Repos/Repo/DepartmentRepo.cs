using Domain;
using Microsoft.EntityFrameworkCore;
using Repos.IRepo;
using System.Collections.Generic;
using System.Linq;

namespace Repos.Repo
{
    public class DepartmentRepo : IRepo<Department>
    {
        private readonly AppDpContext context = new AppDpContext();

        public List<Department> GetAll() =>
            context.Departments.Include(i => i.Employees).AsNoTracking().ToList();

        public Department GetByID(int id) =>
            context.Departments.Include(i => i.Employees).AsNoTracking().FirstOrDefault(x => x.DeptNo == id);

        public void InsertData(Department item)
        {
            context.Departments.Add(item);
            this.SaveChanges();
        }
        public void RemoveItem(int id)
        {
            var deptToRemove = context.Departments.Find(id);
            context.Departments.Remove(deptToRemove);
            this.SaveChanges();
        }

        public Department UpdateData(Department item)
        {
            context.Departments.Update(item);
            this.SaveChanges();
            return this.GetByID(item.DeptNo);
        }

        public void SaveChanges() =>context.SaveChanges();
    }
}
