namespace HeroChallenge
{
    partial class HeroMaker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            heroName = new TextBox();
            heroNameLabel = new Label();
            raceSelector = new GroupBox();
            orc = new RadioButton();
            human = new RadioButton();
            goblin = new RadioButton();
            gnome = new RadioButton();
            fairy = new RadioButton();
            elf = new RadioButton();
            dwarf = new RadioButton();
            centaur = new RadioButton();
            featureSelector = new GroupBox();
            honest = new CheckBox();
            antisocial = new CheckBox();
            charismatic = new CheckBox();
            comical = new CheckBox();
            mischievious = new CheckBox();
            good = new CheckBox();
            skillSelector = new ListBox();
            speedSlider = new HScrollBar();
            DOBPicker = new DateTimePicker();
            darkSlider = new TrackBar();
            agePicker = new NumericUpDown();
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            darkLabel = new Label();
            speedLabel = new Label();
            statsBox = new GroupBox();
            staminaLabel = new Label();
            staminaSlider = new HScrollBar();
            strengthLabel = new Label();
            strengthSlider = new HScrollBar();
            colorDialog1 = new ColorDialog();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label5 = new Label();
            raceSelector.SuspendLayout();
            featureSelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)darkSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agePicker).BeginInit();
            statsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // heroName
            // 
            heroName.Location = new Point(194, 31);
            heroName.Name = "heroName";
            heroName.Size = new Size(420, 39);
            heroName.TabIndex = 0;
            // 
            // heroNameLabel
            // 
            heroNameLabel.AutoSize = true;
            heroNameLabel.Location = new Point(34, 31);
            heroNameLabel.Name = "heroNameLabel";
            heroNameLabel.Size = new Size(142, 32);
            heroNameLabel.TabIndex = 1;
            heroNameLabel.Text = "Hero Name:";
            // 
            // raceSelector
            // 
            raceSelector.Controls.Add(orc);
            raceSelector.Controls.Add(human);
            raceSelector.Controls.Add(goblin);
            raceSelector.Controls.Add(gnome);
            raceSelector.Controls.Add(fairy);
            raceSelector.Controls.Add(elf);
            raceSelector.Controls.Add(dwarf);
            raceSelector.Controls.Add(centaur);
            raceSelector.Location = new Point(34, 103);
            raceSelector.Name = "raceSelector";
            raceSelector.Size = new Size(580, 260);
            raceSelector.TabIndex = 2;
            raceSelector.TabStop = false;
            raceSelector.Text = "Race:";
            // 
            // orc
            // 
            orc.AutoSize = true;
            orc.Location = new Point(320, 202);
            orc.Name = "orc";
            orc.Size = new Size(82, 36);
            orc.TabIndex = 7;
            orc.TabStop = true;
            orc.Text = "Orc";
            orc.UseVisualStyleBackColor = true;
            // 
            // human
            // 
            human.AutoSize = true;
            human.Location = new Point(320, 150);
            human.Name = "human";
            human.Size = new Size(123, 36);
            human.TabIndex = 6;
            human.TabStop = true;
            human.Text = "Human";
            human.UseVisualStyleBackColor = true;
            // 
            // goblin
            // 
            goblin.AutoSize = true;
            goblin.Location = new Point(320, 92);
            goblin.Name = "goblin";
            goblin.Size = new Size(115, 36);
            goblin.TabIndex = 5;
            goblin.TabStop = true;
            goblin.Text = "Goblin";
            goblin.UseVisualStyleBackColor = true;
            // 
            // gnome
            // 
            gnome.AutoSize = true;
            gnome.Location = new Point(320, 38);
            gnome.Name = "gnome";
            gnome.Size = new Size(123, 36);
            gnome.TabIndex = 4;
            gnome.TabStop = true;
            gnome.Text = "Gnome";
            gnome.UseVisualStyleBackColor = true;
            // 
            // fairy
            // 
            fairy.AutoSize = true;
            fairy.Location = new Point(77, 202);
            fairy.Name = "fairy";
            fairy.Size = new Size(94, 36);
            fairy.TabIndex = 3;
            fairy.TabStop = true;
            fairy.Text = "Fairy";
            fairy.UseVisualStyleBackColor = true;
            // 
            // elf
            // 
            elf.AutoSize = true;
            elf.Location = new Point(77, 150);
            elf.Name = "elf";
            elf.Size = new Size(71, 36);
            elf.TabIndex = 2;
            elf.TabStop = true;
            elf.Text = "Elf";
            elf.UseVisualStyleBackColor = true;
            // 
            // dwarf
            // 
            dwarf.AutoSize = true;
            dwarf.Location = new Point(77, 92);
            dwarf.Name = "dwarf";
            dwarf.Size = new Size(107, 36);
            dwarf.TabIndex = 1;
            dwarf.TabStop = true;
            dwarf.Text = "Dwarf";
            dwarf.UseVisualStyleBackColor = true;
            // 
            // centaur
            // 
            centaur.AutoSize = true;
            centaur.Location = new Point(77, 38);
            centaur.Name = "centaur";
            centaur.Size = new Size(129, 36);
            centaur.TabIndex = 0;
            centaur.TabStop = true;
            centaur.Text = "Centaur";
            centaur.UseVisualStyleBackColor = true;
            // 
            // featureSelector
            // 
            featureSelector.Controls.Add(honest);
            featureSelector.Controls.Add(antisocial);
            featureSelector.Controls.Add(charismatic);
            featureSelector.Controls.Add(comical);
            featureSelector.Controls.Add(mischievious);
            featureSelector.Controls.Add(good);
            featureSelector.Location = new Point(640, 103);
            featureSelector.Name = "featureSelector";
            featureSelector.Size = new Size(400, 200);
            featureSelector.TabIndex = 3;
            featureSelector.TabStop = false;
            featureSelector.Text = "Features:";
            // 
            // honest
            // 
            honest.AutoSize = true;
            honest.Location = new Point(210, 124);
            honest.Name = "honest";
            honest.Size = new Size(122, 36);
            honest.TabIndex = 5;
            honest.Text = "Honest";
            honest.UseVisualStyleBackColor = true;
            // 
            // antisocial
            // 
            antisocial.AutoSize = true;
            antisocial.Location = new Point(210, 82);
            antisocial.Name = "antisocial";
            antisocial.Size = new Size(148, 36);
            antisocial.TabIndex = 4;
            antisocial.Text = "Antisocial";
            antisocial.UseVisualStyleBackColor = true;
            // 
            // charismatic
            // 
            charismatic.AutoSize = true;
            charismatic.Location = new Point(210, 38);
            charismatic.Name = "charismatic";
            charismatic.Size = new Size(169, 36);
            charismatic.TabIndex = 3;
            charismatic.Text = "Charismatic";
            charismatic.UseVisualStyleBackColor = true;
            // 
            // comical
            // 
            comical.AutoSize = true;
            comical.Location = new Point(19, 124);
            comical.Name = "comical";
            comical.Size = new Size(131, 36);
            comical.TabIndex = 2;
            comical.Text = "Comical";
            comical.UseVisualStyleBackColor = true;
            // 
            // mischievious
            // 
            mischievious.AutoSize = true;
            mischievious.Location = new Point(19, 82);
            mischievious.Name = "mischievious";
            mischievious.Size = new Size(184, 36);
            mischievious.TabIndex = 1;
            mischievious.Text = "Mischievious";
            mischievious.UseVisualStyleBackColor = true;
            // 
            // good
            // 
            good.AutoSize = true;
            good.Location = new Point(19, 39);
            good.Name = "good";
            good.Size = new Size(104, 36);
            good.TabIndex = 0;
            good.Text = "Good";
            good.UseVisualStyleBackColor = true;
            // 
            // skillSelector
            // 
            skillSelector.FormattingEnabled = true;
            skillSelector.ItemHeight = 32;
            skillSelector.Items.AddRange(new object[] { "Charisma", "Sneaking", "Fighting", "Strength", "Magic" });
            skillSelector.Location = new Point(640, 347);
            skillSelector.Name = "skillSelector";
            skillSelector.Size = new Size(400, 164);
            skillSelector.TabIndex = 4;
            // 
            // speedSlider
            // 
            speedSlider.Location = new Point(-2, 76);
            speedSlider.Name = "speedSlider";
            speedSlider.Size = new Size(580, 53);
            speedSlider.TabIndex = 5;
            speedSlider.Scroll += speedSlider_Scroll;
            // 
            // DOBPicker
            // 
            DOBPicker.Location = new Point(214, 380);
            DOBPicker.Name = "DOBPicker";
            DOBPicker.Size = new Size(400, 39);
            DOBPicker.TabIndex = 6;
            // 
            // darkSlider
            // 
            darkSlider.Location = new Point(640, 583);
            darkSlider.Minimum = 1;
            darkSlider.Name = "darkSlider";
            darkSlider.Size = new Size(400, 90);
            darkSlider.TabIndex = 8;
            darkSlider.Value = 1;
            darkSlider.Scroll += darkSlider_Scroll;
            // 
            // agePicker
            // 
            agePicker.Location = new Point(214, 453);
            agePicker.Name = "agePicker";
            agePicker.Size = new Size(240, 39);
            agePicker.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 387);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 10;
            label1.Text = "Player DOB:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 455);
            label3.Name = "label3";
            label3.Size = new Size(120, 32);
            label3.TabIndex = 12;
            label3.Text = "Hero Age:";
            // 
            // button1
            // 
            button1.Location = new Point(835, 784);
            button1.Name = "button1";
            button1.Size = new Size(235, 87);
            button1.TabIndex = 13;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(640, 312);
            label4.Name = "label4";
            label4.Size = new Size(72, 32);
            label4.TabIndex = 14;
            label4.Text = "Skills:";
            // 
            // darkLabel
            // 
            darkLabel.AutoSize = true;
            darkLabel.Location = new Point(640, 544);
            darkLabel.Name = "darkLabel";
            darkLabel.Size = new Size(240, 32);
            darkLabel.TabIndex = 15;
            darkLabel.Text = "Dark Side Propensity:";
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            speedLabel.Location = new Point(-2, 44);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new Size(86, 32);
            speedLabel.TabIndex = 16;
            speedLabel.Text = "Speed:";
            // 
            // statsBox
            // 
            statsBox.Controls.Add(staminaLabel);
            statsBox.Controls.Add(staminaSlider);
            statsBox.Controls.Add(strengthLabel);
            statsBox.Controls.Add(strengthSlider);
            statsBox.Controls.Add(speedLabel);
            statsBox.Controls.Add(speedSlider);
            statsBox.Location = new Point(36, 520);
            statsBox.Name = "statsBox";
            statsBox.Size = new Size(578, 330);
            statsBox.TabIndex = 17;
            statsBox.TabStop = false;
            statsBox.Text = "Stats";
            // 
            // staminaLabel
            // 
            staminaLabel.AutoSize = true;
            staminaLabel.Location = new Point(-2, 232);
            staminaLabel.Name = "staminaLabel";
            staminaLabel.Size = new Size(104, 32);
            staminaLabel.TabIndex = 20;
            staminaLabel.Text = "Stamina:";
            // 
            // staminaSlider
            // 
            staminaSlider.Location = new Point(-2, 264);
            staminaSlider.Name = "staminaSlider";
            staminaSlider.Size = new Size(580, 53);
            staminaSlider.TabIndex = 19;
            staminaSlider.Scroll += staminaSlider_Scroll;
            // 
            // strengthLabel
            // 
            strengthLabel.AutoSize = true;
            strengthLabel.Location = new Point(-2, 138);
            strengthLabel.Name = "strengthLabel";
            strengthLabel.Size = new Size(110, 32);
            strengthLabel.TabIndex = 18;
            strengthLabel.Text = "Strength:";
            // 
            // strengthSlider
            // 
            strengthSlider.Location = new Point(-2, 170);
            strengthSlider.Name = "strengthSlider";
            strengthSlider.Size = new Size(580, 53);
            strengthSlider.TabIndex = 17;
            strengthSlider.Scroll += strengthSlider_Scroll;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(813, 643);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 100);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(505, 425);
            label2.Name = "label2";
            label2.Size = new Size(72, 32);
            label2.TabIndex = 19;
            label2.Text = "Skills:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(640, 641);
            label5.Name = "label5";
            label5.Size = new Size(167, 32);
            label5.TabIndex = 20;
            label5.Text = "Favorite Color:";
            // 
            // HeroMaker
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 883);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(statsBox);
            Controls.Add(darkLabel);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(agePicker);
            Controls.Add(darkSlider);
            Controls.Add(DOBPicker);
            Controls.Add(skillSelector);
            Controls.Add(featureSelector);
            Controls.Add(raceSelector);
            Controls.Add(heroNameLabel);
            Controls.Add(heroName);
            Name = "HeroMaker";
            Text = "Hero Maker";
            raceSelector.ResumeLayout(false);
            raceSelector.PerformLayout();
            featureSelector.ResumeLayout(false);
            featureSelector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)darkSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)agePicker).EndInit();
            statsBox.ResumeLayout(false);
            statsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox heroName;
        private Label heroNameLabel;
        private GroupBox raceSelector;
        private RadioButton orc;
        private RadioButton human;
        private RadioButton goblin;
        private RadioButton gnome;
        private RadioButton fairy;
        private RadioButton elf;
        private RadioButton dwarf;
        private RadioButton centaur;
        private GroupBox featureSelector;
        private CheckBox honest;
        private CheckBox antisocial;
        private CheckBox charismatic;
        private CheckBox comical;
        private CheckBox mischievious;
        private CheckBox good;
        private ListBox skillSelector;
        private HScrollBar speedSlider;
        private DateTimePicker DOBPicker;
        private PictureBox avatarImg;
        private TrackBar darkSlider;
        private NumericUpDown agePicker;
        private Label label1;
        private Label strengthLabel;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label darkLabel;
        private Label speedLabel;
        private GroupBox statsBox;
        private Label staminaLabel;
        private HScrollBar staminaSlider;
        private HScrollBar strengthSlider;
        private ColorDialog colorDialog1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label5;
    }
}