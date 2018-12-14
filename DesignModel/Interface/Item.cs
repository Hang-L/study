using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.Interface
{
    interface Item
    {
        string Name();
        Packing packing();
        float price();
    }
}
