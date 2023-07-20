using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo1.Models
{
    public static class Citylist
    {
        private static List<City> itemList = new List<City>();

        static Citylist()
        {
            itemList.Add(new City()
            {
                Name = "Alwar",
                Id = 1,
                StateId=1

            });

            itemList.Add(new City()
            {
                Name = "Ajmer",
                Id = 2,
                StateId=2

            });
        }
        public static void Add(City City)
        {
            City.Id = itemList.Max(x => x.Id) + 1;
            itemList.Add(City);
        }
        public static void Update(int id, City City)
        {
            var item = itemList.FirstOrDefault(x => x.Id == id);
            itemList.Remove(item);
            itemList.Add(City);
        }

        public static void Delete(int id)
        {
            var item = itemList.FirstOrDefault(x => x.Id == id);
            itemList.Remove(item);
        }

        public static City GetById(int id)
        {
            var item = itemList.FirstOrDefault(x => x.Id == id);
            return item;
        }

        public static List<City> GetAll()
        {
            return itemList;
        }
    }
}