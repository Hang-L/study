using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.Abstrac_Factory_Pattern
{
    class FactoryProducer
    {
        public static AbstractFactory GetFactory(string factoryType)
        {
            if (factoryType=="sharp")
            {
                return new SharpFactory();
            }
            else
            {
                return new ColorFactory();
            }
        }
    }
}
