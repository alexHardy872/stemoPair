using System;
using System.Collections.Generic;
using System.Text;

namespace HardyStemoPairProgram.Stemo
{
    public class Monster : Card
    {
        //Member Variables
        public int Attack;
        public int Defense;
        public bool HasEffect;
        public Position Position;

        //Constructor
        public Monster(string name, string description, int attack, int defense, bool hasEffect, Position position)
        {
            Name = name;
            Description = description;
            Attack = attack;
            Defense = defense;
            HasEffect = hasEffect;
            Position = position;

        }

        //Methods
    }
    public enum Position
    {
        AttackPosition,
        DefensePosition
    }
}
