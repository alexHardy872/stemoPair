using System;
using System.Collections.Generic;
using System.Text;

namespace HardyStemoPairProgram.Stemo
{
    static class Actions
    {
        //Static Methods

        public static string CalculateDamage(Monster attackingMonster, Monster defendingMonster)
        {
            if (defendingMonster.Position == Position.AttackPosition)
            {
                var difference = attackingMonster.Attack - defendingMonster.Attack;
                //attacking monster is higher
                if (difference > 0)
                {
                    return $"{attackingMonster.Name}'s attack destroyed {defendingMonster.Name} and inflicted battle damage of {difference}LP";
                }
                //defending moster is higher
                if (difference == 0)
                {
                    return $"{attackingMonster.Name}'s attack destroyed both monsters. No LP lost";
                }
                //same attack power of both
                return $"{defendingMonster.Name} destroyed {attackingMonster.Name} while defending itself and inflicted battle damage of {difference}LP";

            }
            else
            {
                var difference = attackingMonster.Attack - defendingMonster.Defense;
                //attacking monster is higher
                if (difference > 0)
                {
                    return $"{attackingMonster.Name}'s attack destroyed {defendingMonster.Name}";
                }
                //defending moster is higher
                if (difference == 0)
                {
                    return $"{attackingMonster.Name}'s attack was the same as{defendingMonster.Name}'s defense No LP lost";
                }
                //same attack power of both
                return $"{defendingMonster.Name}'s defense was greater than {attackingMonster.Name}'s attack. The attacking player lost {difference}LP";

            }
        }
    }
}
