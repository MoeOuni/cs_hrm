namespace hrm
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            email = new TextBox();
            password = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // email
            // 
            email.Location = new Point(43, 105);
            email.Name = "email";
            email.Size = new Size(237, 27);
            email.TabIndex = 0;
            // 
            // password
            // 
            password.Location = new Point(43, 158);
            password.Name = "password";
            password.Size = new Size(237, 27);
            password.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(77, 207);
            button1.Name = "button1";
            button1.Size = new Size(160, 47);
            button1.TabIndex = 2;
            button1.Text = "Se Connecter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(77, 46);
            label1.Name = "label1";
            label1.Size = new Size(162, 28);
            label1.TabIndex = 3;
            label1.Text = "Connectez-vous";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(319, 298);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(email);
            DoubleBuffered = true;
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox email;
        private TextBox password;
        private Button button1;
        private Label label1;
    }
}