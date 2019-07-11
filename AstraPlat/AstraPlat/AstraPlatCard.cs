using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstraPlat
{
    class AstraPlatCard
    {
        private int wallet;
        private int id;
        private static int numberForID = 111;

        public AstraPlatCard()
        {
            id = numberForID++;
        }

        public int GetId()
        {
            return id;
        }
        public int GetWallet()
        {
            return wallet;
        }

        public bool Valid()
        {
            if (wallet > 90)
            {
                wallet -= 90;
                return true;
            }
            return false;
        }

        public bool Refill(int cash)
        {
            if (cash > 0 && cash <= 10000)
            {
                wallet += cash;
                return true;
            }
            return false;
        }
    }
}
