using System;
using System.Collections.Generic;
using System.Text;

namespace Forms_LinQ
{
    class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }
        public override string ToString()
        {
            return "{" + Name + " | " + Score + "}";
        }
    }
}
