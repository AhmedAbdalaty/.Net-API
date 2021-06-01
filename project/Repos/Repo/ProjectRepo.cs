using Domain;
using Microsoft.EntityFrameworkCore;
using Repos.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Repo
{
    public class ProjectRepo : IRepo<Project>
    {
        private readonly AppDpContext context = new AppDpContext();

        public List<Project> GetAll() =>
            context.Projects.AsNoTracking().ToList();

        public Project GetByID(int id) =>
            context.Projects.AsNoTracking().FirstOrDefault(x => x.ProjectNo == id);

        public void InsertData(Project item)
        {
            context.Projects.Add(item);
            this.SaveChanges();
        }
        public void RemoveItem(int id)
        {
            var projectToRemove = context.Projects.Find(id);
            context.Projects.Remove(projectToRemove);
            this.SaveChanges();
        }

        public Project UpdateData(Project item)
        {
            context.Projects.Update(item);
            this.SaveChanges();
            return this.GetByID(item.ProjectNo);
        }

        public void SaveChanges() => context.SaveChanges();
    }
}
