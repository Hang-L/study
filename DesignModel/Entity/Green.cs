using DesignModel.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.Entity
{
    class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("green fill");
        }
    }
}
