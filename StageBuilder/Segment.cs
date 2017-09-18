using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScriptRunner;

namespace StageBuilder
{
    internal class Segment
    {
        private const double _slowPercent = 0.8;
        private const double _speedPercent = 1.2;


        public Segment(char state)
        {
            switch (state)
            {
                case '1': //Black FW
                    OnCollision = SlowDown;
                    break;

                case '2': //Red FW
                    OnCollision = (P => CheckColor(Player.Color.Red)(P));
                    break;

                case '3': //Green FW
                    OnCollision = (P => CheckColor(Player.Color.Green)(P));
                    break;

                case '4': //Blue FW
                    OnCollision = (P => CheckColor(Player.Color.Blue)(P));
                    break;

                case '5': //Yellow FW
                    OnCollision = (P => CheckColor(Player.Color.Yellow)(P));
                    break;

                case '6': //Diverge Path
                    //TODO
                    break;

                default: //Empty
                    break;

            }
        }

        public Action<Player> OnCollision;

        private Func<Player, Action<Player>> CheckColor(Player.Color FWColor) =>
            (P => P.CurrentColor == FWColor ? SpeedUp : SlowDown);

        private Action<Player> SpeedUp = (P => P.Speed = (int)(P.Speed * _speedPercent));
        private Action<Player> SlowDown = (P => P.Speed = (int)(P.Speed * _slowPercent));
    }
}
