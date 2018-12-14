using DesignModel.Factory_Pattern;
using DesignModel.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.Entity
{
    class Circle : Sharp
    {
        public void Draw()
        {
            Console.WriteLine("Circle draw......");
        }
    }
}
