using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Slime : Enemy
    {
        public Slime()
        {
            name = "slime";
            health = 10;
            DodgeChance = 10;
            HitChance = 10;
            weakness = "Fire";
        }
    }
}
