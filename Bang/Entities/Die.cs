using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Die
    {
        private DieFace Face { get; set; }
        // Sep, pero se la sintáxis ahora será ponerlo en mayúscula

        public Die()
        {
            this.Face = DieFace.Ninguno;
        }

        public Die(DieFace dieFace)
        {
            this.Face = dieFace;
        }

        // Lanza el dado
        public DieFace Throw()
        {
            // Semilla para el número random
            Random random = new Random(DateTime.Now.Millisecond);
            Array values = Enum.GetValues(typeof(DieFace));
            this.Face = (DieFace)values.GetValue(random.Next(6));
            Console.WriteLine(this.Face);
            return this.Face;

        }
    }
}
