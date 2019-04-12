using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;

namespace Logic
{
    public class Play
    {
        int RemainingArrows ;
        List<Player> Players;
        int turn;
        DiceThrower Dices;
        int Sheriff;
        short Outlaw;
        short Renegade;
        short Deputy;


        public Play(int players)
        {
            this.RemainingArrows = 15;
            this.RolsQuantity(players);
            this.Players = new List<Player>(players);
            this.DistributeCharacters();
            this.Dices = new DiceThrower();
        }

        private void RolsQuantity(int players)
        {
            this.Sheriff = 1;
            switch (players)
            {
                case 4:
                    this.Renegade = 1;
                    this.Outlaw = 2;
                    this.Deputy = 0;
                    break;
                case 5:
                    this.Renegade = 1;
                    this.Outlaw = 2;
                    this.Deputy = 1;
                    break;
                case 6:
                    this.Renegade = 1;
                    this.Outlaw = 3;
                    this.Deputy = 1;
                    break;
                case 7:
                    this.Renegade = 1;
                    this.Outlaw = 3;
                    this.Deputy = 2;
                    break;
                case 8:
                    this.Renegade = 2;
                    this.Outlaw = 3;
                    this.Deputy = 2;
                    break;
            }
        }

        private void DistributeCharacters()
        {
            
            List<Character> characters= CharacterList.getCharacters();
            Array rols = Enum.GetValues(typeof(Rols));
            Random random=new Random();
            int tempSherrif=0,tempOutlaw=0,tempDeputy=0,tempRenegade=0;
            for (int i = 0; i < this.Players.Capacity; ++i)
            {
                int rol= random.Next(4);
                while((rol==0 && tempSherrif==1) || (rol==1 && this.Outlaw==tempOutlaw) || (rol==2 && this.Renegade==tempRenegade) || (rol==3 && this.Deputy==tempDeputy))
                {
                    rol++;
                    if (rol == 3)
                        rol = 0;
                }
                switch (rol)
                {
                    case 0:
                        tempSherrif++;
                        break;
                    case 1:
                        tempOutlaw++;
                        break;
                    case 2:
                        tempRenegade++;
                        break;
                    case 3:
                        tempDeputy++;
                        break;

                }
                int indice=random.Next(characters.Capacity);
                this.Players.Insert(i,new Player(characters.ElementAt<Character>(indice),(Rols)rols.GetValue(rol)));
                characters.RemoveAt(indice);
            }
        }

        public void Throw()
        {
            this.Dices.Throw();
            this.AttackIndians();
            //this.Players.ElementAt<Player>(turn).Arrows+=this.Dices.arrows;
        }

        public void UseDice(int dice,int player)
        {

        }

        public void EndTurn()
        {
            this.Dices.Restart();
            
            this.turn++;
        }

        private void AttackIndians()
        {
            int RArrows= this.Dices.arrows- this.RemainingArrows;
            if (RArrows>=0)
            {
                this.Players.ElementAt<Player>(turn).Arrows += this.RemainingArrows;
                for(int i = 0; i < this.Players.Capacity; ++i)
                {
                    this.Players.ElementAt<Player>(i).Life=-this.Players.ElementAt<Player>(i).Arrows;
                    this.Players.ElementAt<Player>(i).Arrows = 0;
                    if (this.Players.ElementAt<Player>(i).Life <= 0)
                    {
                        if (this.Players.ElementAt<Player>(i) == this.Players.ElementAt<Player>(turn))
                            RArrows = 0;
                        this.DiePlayer(i);
                        i--;
                    }
                }
                this.RemainingArrows = 15 - RArrows;
                this.Players.ElementAt<Player>(turn).Arrows += RArrows;
            }
            else
                this.Players.ElementAt<Player>(turn).Arrows = this.Dices.arrows;
        }

        private bool EndGame()
        {

            if (this.Sheriff == 0)
                return true;

            if (this.Sheriff==0 && this.Outlaw == 0)
                return true;

            if (this.Outlaw == 0 && this.Renegade==0)
                return true;
            
            return false;
        }

        private void DiePlayer(int index)
        {
            switch (this.Players.ElementAt<Player>(index).Rol)
            {
                case Rols.RolA: Sheriff = 0;
                    break;

                case Rols.RolB: this.Deputy--;
                    break;

                case Rols.RolC: this.Outlaw--;
                    break;

                case Rols.RolD: this.Renegade--;
                    break;
            }

            this.RemainingArrows+=this.Players.ElementAt<Player>(index).Arrows;

            if (index <= turn)
                turn--;

            this.Players.RemoveAt(index);

        }


    }
}
