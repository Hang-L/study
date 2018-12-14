using DesignModel.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.Build_Pattern
{
    class Meal
    {
        private List<Item> items = new List<Item>();
        public void AddItem(Item item)
        {
            items.Add(item);
        }
        public float GetCost()
        {
            float cost = 0.0f;
            foreach (var item in items) {
                cost += item.price();
            }
            return cost;
        }
        public void ShowItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"item:+{item.Name()}");
                Console.WriteLine($", Packling:{item.packing().pack()}");
                Console.WriteLine($", price:{item.price()}");
            }
            Console.ReadLine();
        }
    }
}
