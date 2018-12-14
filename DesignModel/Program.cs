using DesignModel.Factory_Pattern;
using DesignModel.Interface;
using System;

namespace DesignModel
{
    class Program
    {
        static void Main(string[] args)
        {
            var sharpFactory = new SharpeFactory();
            Sharp sharp = sharpFactory.GetSharpe("R");
            sharp.Draw();
            Console.ReadLine();
        }
    }
}
