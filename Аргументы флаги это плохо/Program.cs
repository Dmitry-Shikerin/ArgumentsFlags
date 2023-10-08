using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Аргументы_флаги_это_плохо
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public void OnEnable()
        {
            _effects.StartEnableAnimation();
        }

        public void OnDisable() 
        {
            _pool.Free(this);
        }
    }
}
