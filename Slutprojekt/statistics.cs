using System;

namespace Slutprojekt
{

    public class statistics
    {
        public string race;
        public string build;
        public int level;
        public int hp;
        public int maxHp;

        public void setRace(string text)
        {
            race = text; 
        }

        public string getRace()
        {
            return race;
        }

    }

}
