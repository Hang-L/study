using DesignModel.Entity;
using DesignModel.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.Factory_Pattern
{
    class SharpeFactory
    {
        public Sharp GetSharpe(string sharpType)
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
