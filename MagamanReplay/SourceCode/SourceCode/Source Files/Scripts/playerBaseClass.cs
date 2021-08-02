using System;
using System.Collections.Generic;
using GameNamespace;

namespace GameNamespace
{
    public class playerBaseClass
    {
        public CAnimateSprite playerSprite = new CAnimateSprite("player_idle");
        public float[] playerPosition = new float[2];

        public void Walk(string dir)
        {
            switch(dir)
            {
                case "Left":
                {
                    break;
                }
                case "Right":
                {
                    break;
                }
            }
        }
    }
}