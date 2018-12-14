using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.Build_Pattern
{
    class ChickenBurger : Burger
    {
        public override string Name()
        {
            return "ChickenBurger";
        }

        public override float price()
        {
            return 50.5f;
        }
    }
}
