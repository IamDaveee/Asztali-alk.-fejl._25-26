using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztályokű
{
    class UjEmber
    {
        public string neve;
        public int testho;

        public UjEmber(string neve, int testho)
        {
            this.neve = neve;
            this.testho = testho;
        }

        public void PeldanyAdatok()
        {
            Console.WriteLine($"{neve} {testho}");
        }
    }
}
