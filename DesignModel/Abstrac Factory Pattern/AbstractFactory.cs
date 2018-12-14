using DesignModel.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.Abstrac_Factory_Pattern
{
    abstract class AbstractFactory
    {
        public abstract Sharp GetSharp(string sharpType);

        public abstract IColor GetColor(string colorType);
    }
}
