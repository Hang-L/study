using System;
using System.Collections.Generic;
using System.Text;
using DesignModel.Entity;
using DesignModel.Interface;

namespace DesignModel.Abstrac_Factory_Pattern
{
    class SharpFactory : AbstractFactory
    {
        public override IColor GetColor(string colorType)
        {
            return null;
        }

        public override Sharp GetSharp(string sharpType)
        {
            switch (sharpType)
            {
                case "R":
                    return new Recentagle();
                case "C":
                    return new Circle();
                case "S":
                    return new Square();
            }
            return null;
        }
    }
}
