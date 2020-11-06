using System;
using System.Collections.Generic;
using System.Text;

namespace HardyStemoPairProgram.Hardy
{
    public static class HardyHelpers
    {
        // howdy howdy

        public static void Run()
        {
            var MonsterOne = 
                new Monster("Blue Eyes White Dragon", null,
                    3000, 2500, false, Position.AttackPosition);

            var MonsterTwo =
                new Monster("Dark Magician", null,
                    2500, 2100, false, Position.AttackPosition);

            var cards = new List<Card>()
            {
                MonsterOne, MonsterTwo
            };

            var result = Actions.CalculateDamage(MonsterOne, MonsterTwo);

        }
    }
}
