using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore2._2.DesignModel.FatoryModel
{
    public class SharpFactory
    {
        public ISharpe GetSharpe(string sharpType)
        {
          
            switch (sharpType)
            {
                case "R":
                    return new Recentagle();
                case "S":
                    return new Square();
                case "C":
                    return new Circle();
            }
            return null;
        }
    }
}
