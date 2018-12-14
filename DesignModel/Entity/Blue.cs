using DesignModel.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.Entity
{
    class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("blue fill......");
        }
    }
}
