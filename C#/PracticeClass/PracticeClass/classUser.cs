using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClass
{
    abstract class classUser
    {
        public abstract string GetID();
        public abstract string GetFullName();
        public abstract int GetAccessLevel();
    }
}
