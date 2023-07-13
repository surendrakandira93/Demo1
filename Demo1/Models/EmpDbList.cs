using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo1.Models
{
    public static class Empdblist
    {
        private static List<EmployeeDto> itemList = new List<EmployeeDto>();

        static Empdblist()
        {
            itemList.Add(new EmployeeDto()
            {
                Name = "Surendra",
                Id = 1,
                DOB=
                Gender= "female",
                IsActive= true, 
                Department= "java"

            });

            itemList.Add(new EmployeeDto()
            {
                Name = "Mohini",
                Id = 2,
                
                

                 DOB =
                Gender = "female",
                IsActive = true,
                Department = "java"
            });
        }
        public static void Add(EmployeeDto EmployeeDto)
        {
            EmployeeDto.Id = itemList.Max(x => x.Id) + 1;
            itemList.Add(EmployeeDto);
        }
        public static void Update(int id, EmployeeDto EmployeeDto)
        {
            var item = itemList.FirstOrDefault(x => x.Id == id);
            itemList.Remove(item);
            itemList.Add(EmployeeDto);
        }

        public static void Delete(int id)
        {
            var item = itemList.FirstOrDefault(x => x.Id == id);
            itemList.Remove(item);
        }

        public static EmployeeDto GetById(int id)
        {
            var item = itemList.FirstOrDefault(x => x.Id == id);
            return item;
        }

        public static List<EmployeeDto> GetAll()
        {
            return itemList;
        }
    }
}