using System;
using System.Collections.Generic;
using System.Text;
using DesignModel.Entity;
using DesignModel.Interface;

namespace DesignModel.Abstrac_Factory_Pattern
{
    class ColorFactory : AbstractFactory
    {
        public override IColor GetColor(string colorType)
        {
            switch (colorType)
            {
                case "R":
                    return new Red();
                case "G":
                    return new Green();
                case "B":
                    return new Blue();
            }
            return null;
        }

        public override Sharp GetSharp(string sharpType)
        {
            return null;
        }
    }
}
