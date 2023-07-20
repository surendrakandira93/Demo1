using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo1.Models
{
    public static class StateLIst
    {
        private static List<State> itemList = new List<State>();

        static StateLIst()
        {
            itemList.Add(new State()
            {
                Name = "Rajsthan",
                Id = 1,

            });

            itemList.Add(new State()
            {
                Name = "up",
                Id = 2,

            });
        }
        public static void Add(State State)
        {
            State.Id = itemList.Max(x => x.Id) + 1;
            itemList.Add(State);
        }
        public static void Update(int id, State State)
        {
            var item = itemList.FirstOrDefault(x => x.Id == id);
            itemList.Remove(item);
            itemList.Add(State);
        }

        public static void Delete(int id)
        {
            var item = itemList.FirstOrDefault(x => x.Id == id);
            itemList.Remove(item);
        }

        public static State GetById(int id)
        {
            var item = itemList.FirstOrDefault(x => x.Id == id);
            return item;
        }

        public static List<State> GetAll()
        {
            return itemList;
        }
    }
}