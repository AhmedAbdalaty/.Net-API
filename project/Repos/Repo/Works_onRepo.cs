using Domain;
using Microsoft.EntityFrameworkCore;
using Repos.IRepo;
using System.Collections.Generic;
using System.Linq;

namespace Repos.Repo
{
    public class Works_onRepo:IRepo<Works_on>
    {
        private readonly AppDpContext context = new AppDpContext();

        public List<Works_on> GetAll() =>
            context.Works_Ons.Include(i => i.Employee).Include(i=>i.Project).AsNoTracking().ToList();

        public Works_on GetByID(int id) =>
            context.Works_Ons.Include(i => i.Employee).Include(i => i.Project).AsNoTracking().FirstOrDefault(x => x.ProjectNo== id);

        public void InsertData(Works_on item)
        {
            context.Works_Ons.Add(item);
            this.SaveChanges();
        }
        public void RemoveItem(int id)
        {
            var worksOnToRemove = context.Works_Ons.FirstOrDefault(x => x.ProjectNo == id);
            context.Works_Ons.Remove(worksOnToRemove);
            this.SaveChanges();
        }

        public Works_on UpdateData(Works_on item)
        {
            context.Works_Ons.Update(item);
            this.SaveChanges();
            return this.GetByID(item.ProjectNo);
        }

        public void SaveChanges() => context.SaveChanges();
    }
}
