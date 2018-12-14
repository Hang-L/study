using DesignModel.Abstrac_Factory_Pattern;
using DesignModel.Build_Pattern;
using DesignModel.Factory_Pattern;
using DesignModel.Interface;
using System;

namespace DesignModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("选择工厂模式");
            var type = Console.ReadLine();
            switch (type)
            {
                case "1"://工厂模式
                    var sharpFactory = new SharpeFactory();
                    Sharp sharp = sharpFactory.GetSharpe("R");
                    sharp.Draw();
                    Console.ReadLine();
                    break;
                case "2"://抽象工厂模式
                    AbstractFactory abstractFactory= FactoryProducer.GetFactory("1212");
                    IColor color= abstractFactory.GetColor("B");
                    color.Fill();
                    Console.ReadLine();
                    break;
                case "3"://建造者模式
                    MealBuilder mealBuilder = new MealBuilder();
                    Meal vgMeal = mealBuilder.PrepareVegMeal();
                    Console.WriteLine("Veg meal");
                    vgMeal.ShowItems();
                    Console.WriteLine($"Total Cost:{vgMeal.GetCost()}");
                    Meal nonVegMeal = mealBuilder.PrepareNonVegMeal();
                    Console.WriteLine("NonVeg Meal");
                    nonVegMeal.ShowItems();
                    Console.WriteLine($"Total Cost:{nonVegMeal.GetCost()}");
                    break;

            }
            
        }
    }
}
