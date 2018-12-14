using DesignModel.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.Entity
{
    class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("color fill");
        }
    }
}
