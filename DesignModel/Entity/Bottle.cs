using DesignModel.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.Entity
{
    class Bottle : Packing
    {
        public string pack()
        {
            return "Bottle";
        }
    }
}
