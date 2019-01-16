using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Dice
    {
        private List<Die> dieList;
        public List<Die> DieList { get => dieList; set => dieList = value; }

        public Dice()
        {
            // Creación de dados
            DieList = new List<Die>
            {
                new Die(),
                new Die(),
                new Die(),
                new Die(),
                new Die()
            };
        }


        // ¿Función?
        private void Check()
        {
            this.DieList.ForEach((Die die) =>
            {
                //se checkea los estados
            });
        }
    }
}
