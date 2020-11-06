using System;
using System.Collections.Generic;
using System.Text;

namespace HardyStemoPairProgram.Stemo
{
    class StemoHelpers
    {
        public static void Run()
        {
            var MonsterOne = new Monster("Red Eyes Black Dragon", null, 2400, 200, false, Position.AttackPosition);
            var MonsterTwo = new Monster("Dark Magician", null, 2500, 200, false, Position.AttackPosition);

            var cards = new List<Card>() 
            {
                MonsterOne, MonsterTwo
            };

        }

    }
}
