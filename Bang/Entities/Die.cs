using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Die
    {
        private DieFace dieFace;

        public Die()
        {
            this.dieFace = DieFace.Ninguno;
        }

        public Die(DieFace dieFace)
        {
            this.dieFace = dieFace;
        }

        // Lanza el dado
        public void Throw()
        {
            // Semilla para el número random
            Random random = new Random(DateTime.Now.Millisecond);
            Array values = Enum.GetValues(typeof(DieFace));
            this.dieFace = (DieFace)values.GetValue(random.Next(6));
            Console.WriteLine(this.dieFace);
        }
    }
}
