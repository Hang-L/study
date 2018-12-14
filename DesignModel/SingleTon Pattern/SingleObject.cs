using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.SingleTon_Pattern
{
    class SingleObject
    {
        /// <summary>
        /// 创建SingleObject对象
        /// </summary>
        private static SingleObject instance = new SingleObject();

        /// <summary>
        /// 对象不会被实力化
        /// </summary>
        private SingleObject() { }
        /// <summary>
        /// 唯一获取对象的方式
        /// </summary>
        /// <returns></returns>
        public static SingleObject GetSingleObject()
        {
            return instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
