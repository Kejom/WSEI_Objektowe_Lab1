using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSEI_Objektowe_Lab1
{
    interface IShape
    {
        public string Name { get;}
        void GetData();
        void CalculateArea();
    }
}
