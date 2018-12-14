using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.Build_Pattern
{
    class Coke : ColdDrink
    {
        public override string Name()
        {
            return "coke";

        }

        public override float price()
        {
            return 30.2f;
        }
    }
}

