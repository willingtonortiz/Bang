using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Player
    {
        public Character Character { get; set; }
        public Rols Rol { get; set; }
        public int Life { get; set; }
        public int Arrows { get; set; }

        public Player(Character Character, Rols rol)
        {
            this.Character = Character;
            this.Arrows = 0;
            this.Rol = rol;
            this.Life = this.Character.MaxLife;
        }

        public void Init()
        {

        }

        public void Point()
        {

        }

        public void ModifyLife(int a)
        {

        }
    }
}
