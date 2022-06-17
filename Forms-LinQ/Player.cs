using System;
using System.Collections.Generic;
using System.Text;

namespace Forms_LinQ
{

    class PlayerList
    {
        public List<Player> players { get; set; }
    }
    class Player
    {
        public string name { get; set; }
        public int score { get; set; }

        public override string ToString()
        {
            return "{" + name + " | " + score + "}";
        }
    }
}
