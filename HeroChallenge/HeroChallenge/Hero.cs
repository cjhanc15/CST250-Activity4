using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace HeroChallenge
{
    public class Hero
    {
        public string name = "";
        public string race = "";
        public string[] features = { "" };
        public DateTime dateOfBirth;
        public int age;
        public int speed;
        public int strength;
        public int stamina;
        public string favoriteColor;
        public int darkSide;
        public string skill;

        // Constructor
        public Hero(string name, string race, string[] features, DateTime dateOfBirth, int age, int speed, int strength, int stamina, string favoriteColor, int darkSide, string skill)
        {
            this.name = name;
            this.race = race;
            this.features = features;
            this.dateOfBirth = dateOfBirth;
            this.age = age;
            this.speed = speed;
            this.strength = strength;
            this.stamina = stamina;
            this.favoriteColor = favoriteColor;
            this.darkSide = darkSide;
            this.skill = skill;
        }
    }
}

