namespace HeroChallenge
{
    partial class DisplayHeros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            heroNames = new ListBox();
            heroData = new TextBox();
            SuspendLayout();
            // 
            // heroNames
            // 
            heroNames.FormattingEnabled = true;
            heroNames.ItemHeight = 32;
            heroNames.Location = new Point(57, 92);
            heroNames.Name = "heroNames";
            heroNames.Size = new Size(374, 452);
            heroNames.TabIndex = 0;
            // 
            // heroData
            // 
            heroData.Location = new Point(514, 93);
            heroData.Multiline = true;
            heroData.Name = "heroData";
            heroData.Size = new Size(533, 451);
            heroData.TabIndex = 1;
            // 
            // DisplayHeros
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 718);
            Controls.Add(heroData);
            Controls.Add(heroNames);
            Name = "DisplayHeros";
            Text = "DisplayHeros";
            Load += DisplayHeros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox heroNames;
        private TextBox heroData;
    }
}