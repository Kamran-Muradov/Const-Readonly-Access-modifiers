using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Readonly_Access_modifiers.Models
{
    internal class Test : Car
    {
        public int bestSpeed;
        //public Test() : base(5)
        //{
        //    speed = 100;
        //}

        public Test() : base(5)
        {
            bestSpeed = speed;
        }
    }
}
