using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaProgram
{
    internal class Triangle
    {
        public float Base;
        public float Height;

        public float Area (float Base,float Height)
        {
            return Base * Height / 2;

        }
    }
}
