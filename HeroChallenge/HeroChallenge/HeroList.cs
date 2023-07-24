using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace HeroChallenge
{
    public partial class HeroList
    {
        public List<Hero> heroes; // List to store the heroes

        // Constructor
        public HeroList()
        {
            heroes = new List<Hero>();
        }

        // Method to add a hero to the list
        public void AddHero(Hero hero)
        {
            heroes.Add(hero);
        }

        // Method to remove a hero from the list
        public void RemoveHero(Hero hero)
        {
            heroes.Remove(hero);
        }

        // Method to get all heroes in the list
        public List<Hero> GetAllHeroes()
        {
            return heroes;
        }
    }
}

