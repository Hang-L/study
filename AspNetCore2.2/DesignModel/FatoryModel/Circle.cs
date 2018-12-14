using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore2._2.DesignModel.FatoryModel
{
    public class Circle : ISharpe
    {
        public void Draw()
        {
            Console.WriteLine("circle");
        }
    }
}
