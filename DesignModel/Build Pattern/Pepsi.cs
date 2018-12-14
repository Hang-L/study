using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.Build_Pattern
{
    class Pepsi : ColdDrink
    {
        public override string Name()
        {
            return "pepsi";
        }

        public override float price()
        {
            return 32.5f;
        }
    }
}
