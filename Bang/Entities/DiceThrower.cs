using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DiceThrower
    {
        private Dice dice;
        private int moves;

        public DiceThrower()
        {
            this.dice = new Dice();

        }

        // Lanza los dados
        public void Throw()
        {
            dice.DieList.ForEach((Die die) => {
                die.Throw();
            });
        }
    }
}
