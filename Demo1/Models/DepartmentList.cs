using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo1.Models
{
    public static class Departmentlist
    {
        private static List<Department> Department = new List<Department>();

        static Departmentlist()
        {
            Departmentlist.Add(new Department()
            {
                Name = "Surendra",
                Id = 1,
               
            });

            Departmentlist.Add(new Department()
            {
                Name = "Mohini",
                Id = 2,
                
            });
        }
        public static void Add(Department student)
        {
            student.Id = Departmentlist.Max(x => x.Id) + 1;
            Departmentlist.Add(student);
        }
        public static void Update(int id, Department Department)
        {
            var item = Departmentlist.FirstOrDefault(x => x.Id == id);
            Departmentlist.Remove(item);
            Departmentlist.Add(Department);
        }

        public static void Delete(int id)
        {
            var item = Departmentlist.FirstOrDefault(x => x.Id == id);
            Departmentlist.Remove(item);
        }

        public static Department GetById(int id)
        {
            var item = Departmentlist.FirstOrDefault(x => x.Id == id);
            return item;
        }

        public static List<Department> GetAll()
        {
            return Departmentlist;
        }
    }
}