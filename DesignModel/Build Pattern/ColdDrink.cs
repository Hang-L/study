using DesignModel.Entity;
using DesignModel.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.Build_Pattern
{
    abstract class ColdDrink : Item
    {
        public abstract string Name();
      

        public Packing packing()
        {
            return new Bottle();
        }

        public abstract float price();
       
    }
}
