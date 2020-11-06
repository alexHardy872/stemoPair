using System;
using System.Collections.Generic;
using System.Text;

namespace HardyStemoPairProgram.Hardy
{
    public class Monster : Card
    {
        // MEMBER VARIABLES

        public int Attack;

        public int Defense;

        public bool HasEffect;

        public Position Position;

        // CONSTRUCTOR

        public Monster(string name, string description, int attack, int defense, bool hasEffect, Position position)
        {
            Name = name; // this.Name = name
            Description = description;
            Attack = attack;
            Defense = defense;
            HasEffect = hasEffect;
            Position = position;
        }

        // METHODS

    }

    public enum Position
    {
        AttackPosition,
        DefensePosition
    }
}
