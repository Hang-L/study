using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.Build_Pattern
{
    class VegBurger : Burger
    {
        public override string Name()
        {
            return "VegBurger";
        }

        public override float price()
        {
            return 25.0f;
        }
    }
}
