using System;
using System.Collections.Generic;
using System.Text;

namespace HardyStemoPairProgram.Hardy
{
    public static class Actions
    {
        // STATIC METHODS

        public static string CalculateDamage(Monster attackingMonster, Monster defendingMonster)
        {
            if (defendingMonster.Position == Position.AttackPosition)
            {
                var difference = attackingMonster.Attack - defendingMonster.Attack;

                if (difference > 0)
                { 
                    return $"{attackingMonster.Name}'s attack destroyed {defendingMonster.Name} and inflicted battle damage of {difference} LP";
                }
                if (difference == 0)
                {
                    return $"{attackingMonster.Name} and {defendingMonster.Name} have the same attack, both are destroyed";
                }
              
                return $"{attackingMonster.Name} was destroyed while attacking {defendingMonster.Name} inflicted battle damage of {difference*-1} LP";
            }
            else
            {
                var difference = attackingMonster.Attack - defendingMonster.Defense;

                if (difference > 0)
                {
                    return $"{attackingMonster.Name}'s attack destroyed {defendingMonster.Name}. No Damage";
                }
                if (difference == 0)
                {
                    return $"{attackingMonster.Name}'s attack was not enough to destroy {defendingMonster.Name}";
                }
      
                return $"{attackingMonster.Name}'s attack was lower than {defendingMonster.Name}'s defense resulting in {difference * -1} LP Damage to the Attacker";
            }
        }
    }
}
