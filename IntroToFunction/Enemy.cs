﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Enemy
    {
        Random random = new Random();
        public string name = " ";
        public int health = 10;
        public int DodgeChance = 10;
        public int HitChance = 10;
        public string weakness = "None";
        
        public Enemy()
        {

        }
    }
}
