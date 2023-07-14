using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo1.Models
{
    public static class Departmentlist
    {
        private static List<Department> itemList = new List<Department>();

        static Departmentlist()
        {
            itemList.Add(new Department()
            {
                Name = ".Net",
                Id = 1,
               
            });

            itemList.Add(new Department()
            {
                Name = "Account",
                Id = 2,
                
            });
        }
        public static void Add(Department Department)
        {
            Department.Id = itemList.Max(x => x.Id) + 1;
            itemList.Add(Department);
        }
        public static void Update(int id, Department Department)
        {
            var item = itemList.FirstOrDefault(x => x.Id == id);
            itemList.Remove(item);
            Departmentlist.Add(Department);
        }

        public static void Delete(int id)
        {
            var item = itemList.FirstOrDefault(x => x.Id == id);
            itemList.Remove(item);
        }

        public static Department GetById(int id)
        {
            var item = itemList.FirstOrDefault(x => x.Id == id);
            return item;
        }

        public static List<Department> GetAll()
        {
            return itemList;
        }
    }
}