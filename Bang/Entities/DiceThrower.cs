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
        private int dynamite;
        private int arrows;

        public DiceThrower()
        {
            this.dice = new Dice();

        }

        // Lanza los dados
        public void Throw(List<int> index = null)
        {
            if (this.moves < 3 && this.dynamite < 3)
            {
                if (index == null)
                {
                    index = new List<int>(6);
                    for (int i = 0; i < 5; ++i)
                    {
                        index.Insert(i, i);
                    }
                }

                this.arrows = 0;
                // Lanzamiento random
                index.ForEach((int indices) =>
                {

                    DieFace temp = this.dice.DieList.ElementAt(indices).Throw();

                    if (temp == DieFace.Flecha)
                        this.arrows++;

                    if (temp == DieFace.Dinamita)
                        this.dynamite++;

                });
                this.moves++;
            }
        }

        public void Restart() 
        {
            this.arrows = 0;
            this.dynamite = 0;
            this.moves = 0;
        }
    }
}
