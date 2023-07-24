using System;
using System.Windows.Forms;

namespace HeroChallenge
{
    public partial class DisplayHeros : Form
    {
        public HeroList heroList; // Assuming you have a HeroList instance

        public DisplayHeros()
        {
            InitializeComponent();
        }

        // Event handler for the SelectedIndexChanged event of heroNames ListBox
        private void HeroNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if any item is selected (clicked)
            if (heroNames.SelectedIndex != -1)
            {
                // Get the selected hero name
                string selectedHeroName = heroNames.SelectedItem.ToString();

                // Find the corresponding Hero object in the HeroList
                var selectedHero = heroList.GetAllHeroes().Find(hero => hero.name == selectedHeroName);

                // Call the HeroData() method with the selected hero
                HeroData(selectedHero);
            }
        }

        // Method to populate hero data when a hero name is clicked
        public void HeroData(Hero hero)
        {
            // Clear the TextBox first to display new data
            heroData.Clear();

            // Display the hero's data in the TextBox
            heroData.AppendText("Name: " + hero.name + Environment.NewLine);
            heroData.AppendText("Race: " + hero.race + Environment.NewLine);
            heroData.AppendText("Date of Birth: " + hero.dateOfBirth.ToShortDateString() + Environment.NewLine);
            heroData.AppendText("Age: " + hero.age + Environment.NewLine);
            heroData.AppendText("Speed: " + hero.speed + Environment.NewLine);
            heroData.AppendText("Strength: " + hero.strength + Environment.NewLine);
            heroData.AppendText("Stamina: " + hero.stamina + Environment.NewLine);
            heroData.AppendText("Favorite Color: " + hero.favoriteColor + Environment.NewLine);
            heroData.AppendText("Dark Side Propensity: " + hero.darkSide + Environment.NewLine);
            heroData.AppendText("Skill: " + hero.skill + Environment.NewLine);
        }

        // Method to populate hero names in the heroNames ListBox
        private void DisplayHeros_Load(object sender, EventArgs e)
        {
            // Clear the ListBox first to avoid duplicates
            heroNames.Items.Clear();

            // Get all the heroes from the HeroList
            var heroes = heroList.GetAllHeroes();

            // Add each hero's name to the heroNames ListBox
            foreach (var hero in heroes)
            {
                heroNames.Items.Add(hero.name);
            }

            // Attach the SelectedIndexChanged event handler
            heroNames.SelectedIndexChanged += HeroNames_SelectedIndexChanged;

            // Call the HeroData() method to display the data of the first hero
            if (heroNames.Items.Count > 0)
            {
                heroNames.SelectedIndex = 0; // Select the first hero
                HeroData(heroes[0]); // Display the data of the first hero
            }
        }
    }
}
