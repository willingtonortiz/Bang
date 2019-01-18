using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace Logic
{
    public class Play
    {
        int RemainingArrows ;
        List<Player> Players;
        int turn;
        DiceThrower Dices;
        bool Sheriff;
        short Outlaw;
        short Renegade;
        short Deputy;


        public Play(int players)
        {
            this.RemainingArrows = 15;
            this.Players = new List<Player>(players);
            this.DistributeCharacters();
            this.Dices = new DiceThrower();
        }

        private void DistributeCharacters()
        {

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
            if (!this.Sheriff && this.Outlaw == 0)
                return true;

            if (!this.Sheriff)
                return true;

            if (this.Outlaw == 0 && this.Renegade==0)
                return true;
            
            return false;
        }

        private void DiePlayer(int index)
        {
            switch (this.Players.ElementAt<Player>(index).Rol)
            {
                case Rols.RolA: Sheriff = false;
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
