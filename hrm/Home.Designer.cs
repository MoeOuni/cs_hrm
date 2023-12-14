namespace hrm
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            button3 = new Button();
            button4 = new Button();
            button7 = new Button();
            button2 = new Button();
            button1 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(51, 53);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(288, 50);
            button3.TabIndex = 2;
            button3.Text = "Mon Profil";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(51, 121);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(288, 50);
            button4.TabIndex = 3;
            button4.Text = "Historiques";
            button4.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(51, 328);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(288, 50);
            button7.TabIndex = 6;
            button7.Text = "Demandes de Mes Subordonnées";
            button7.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(51, 258);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(288, 50);
            button2.TabIndex = 1;
            button2.Text = "Mes Demandes De Congés/Autorisatioin";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(51, 190);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(288, 50);
            button1.TabIndex = 0;
            button1.Text = "Nouvelle Demande de Congé/Autorisation";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatAppearance.BorderColor = Color.FromArgb(41, 132, 255);
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(51, 399);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(288, 50);
            button5.TabIndex = 4;
            button5.Text = "Liste des Utilisateurs";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(379, 586);
            Controls.Add(button5);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button2);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
        private Button button4;
        private Button button7;
        private Button button2;
        private Button button1;
        private Button button5;
    }
}