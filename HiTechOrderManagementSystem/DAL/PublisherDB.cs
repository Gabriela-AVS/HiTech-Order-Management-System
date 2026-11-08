using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechOrderManagementSystem.LINQ_Data;



namespace HiTechOrderManagementSystem.DAL
{
    public static class PublisherDB
    {
        public static List<Publisher> GetAllPublishers()
        {
            using (HiTechDBDataContext db = new HiTechDBDataContext())
            {
                return db.Publishers.ToList();
            }
        }
    }

}
