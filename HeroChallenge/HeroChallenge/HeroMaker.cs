using System;
using System.Windows.Forms;

namespace HeroChallenge
{
    public partial class HeroMaker : Form
    {
        public HeroList heroList;

        public HeroMaker()
        {
            InitializeComponent();
            heroList = new HeroList(); // Initialize the HeroList
        }

        // Creates hero based on user inputs and add it to the HeroList
        public void CreateHero()
        {
            string name = heroName.Text;
            string race = GetSelectedRace();
            string[] features = GetSelectedFeatures();
            DateTime dateOfBirth = DOBPicker.Value;
            int age = (int)agePicker.Value;
            int speed = speedSlider.Value;
            int strength = darkSlider.Value;
            int stamina = staminaSlider.Value;
            string favoriteColor = pictureBox1.BackColor.ToString();
            int darkSide = darkSlider.Value;
            string skill = skillSelector.Text;

            // Create a new Hero object based on user inputs
            Hero newHero = new Hero(name, race, features, dateOfBirth, age, speed, strength, stamina, favoriteColor, darkSide, skill);

            // Add the new hero to the HeroList
            heroList.AddHero(newHero);
        }

        // Helper method to get the selected race from radio buttons
        private string GetSelectedRace()
        {
            if (centaur.Checked) return "Centaur";
            else if (dwarf.Checked) return "Dwarf";
            else if (elf.Checked) return "Elf";
            else if (fairy.Checked) return "Fairy";
            else if (gnome.Checked) return "Gnome";
            else if (goblin.Checked) return "Goblin";
            else if (human.Checked) return "Human";
            else return "Orc";
        }

        // Helper method to get selected features from checkboxes
        private string[] GetSelectedFeatures()
        {
            List<string> selectedFeatures = new List<string>();
            if (good.Checked) selectedFeatures.Add("Good");
            if (mischievious.Checked) selectedFeatures.Add("Mischievious");
            if (comical.Checked) selectedFeatures.Add("Comical");
            if (charismatic.Checked) selectedFeatures.Add("Charismatic");
            if (antisocial.Checked) selectedFeatures.Add("Antisocial");
            if (honest.Checked) selectedFeatures.Add("Honest");

            return selectedFeatures.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckOverallValues();
        }

        // Update the dark label with the current value of the darkSlider
        private void darkSlider_Scroll(object sender, EventArgs e)
        {
            darkLabel.Text = "Dark Side Propensity: " + darkSlider.Value.ToString();
        }

        // Update the speed label with the current value of the speedSlider
        private void speedSlider_Scroll(object sender, ScrollEventArgs e)
        {
            speedLabel.Text = "Speed: " + speedSlider.Value.ToString();
        }

        // Update the strength label with the current value of the strengthSlider
        private void strengthSlider_Scroll(object sender, ScrollEventArgs e)
        {
            strengthLabel.Text = "Strength: " + strengthSlider.Value.ToString();
        }

        // Update the stamina label with the current value of the staminaSlider
        private void staminaSlider_Scroll(object sender, ScrollEventArgs e)
        {
            staminaLabel.Text = "Stamina: " + staminaSlider.Value.ToString();
        }

        private void CheckOverallValues()
        {
            int overallValue = strengthSlider.Value + speedSlider.Value + staminaSlider.Value;

            if (overallValue > 100)
            {
                // Display an error message
                MessageBox.Show("Overall value cannot exceed 100!");
            }
            else
            //if everything is OK, create character and show dialog
            {
                CreateHero();
                DisplayHeros displayHeroes = new DisplayHeros();
                displayHeroes.heroList = heroList;
                displayHeroes.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Show the color dialog to let the user select a color
            // Set the background color of pictureBox1 to the selected color
            if (colorDialog1.ShowDialog() == DialogResult.OK) pictureBox1.BackColor = colorDialog1.Color;
        }
    }
}
