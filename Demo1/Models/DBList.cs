using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo1.Models
{
    public static class DBList
    {
        private static List<Student> itemList = new List<Student>();

        static DBList()
        {
            itemList.Add(new Student()
            {
                Name="Surendra",
                Id=1,
                Age=30,
                gender="Male"
            });

            itemList.Add(new Student()
            {
                Name = "Mohini",
                Id = 2,
                Age = 25,
                gender = "Female"
            });
        }
        public static void Add(Student student)
        {
            student.Id = itemList.Max(x => x.Id) + 1;
            itemList.Add(student);
        }
        public static void Update(int id, Student student)
        {
            var item = itemList.FirstOrDefault(x => x.Id == id);
            itemList.Remove(item);
            itemList.Add(student);
        }

        public static void Delete(int id)
        {
            var item = itemList.FirstOrDefault(x => x.Id == id);
            itemList.Remove(item);
        }

        public static Student GetById(int id)
        {
            var item = itemList.FirstOrDefault(x => x.Id == id);
            return item;
        }

        public static List<Student> GetAll()
        {
            return itemList;
        }
    }
}