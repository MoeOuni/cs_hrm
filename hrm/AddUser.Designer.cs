namespace hrm
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            textBoxName = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxPassword = new TextBox();
            label5 = new Label();
            button1 = new Button();
            label4 = new Label();
            textBoxMatricule = new TextBox();
            textBoxPoste = new TextBox();
            textBoxLeaveBalance = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dataGridViewUsers = new DataGridView();
            label8 = new Label();
            comboBoxRole = new ComboBox();
            textBoxCin = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxAdresse = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button2 = new Button();
            comboBoxUsers = new ComboBox();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(83, 116);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(186, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(359, 113);
            textBoxFirstName.Margin = new Padding(3, 4, 3, 4);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(186, 27);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(83, 236);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(186, 27);
            textBoxEmail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(83, 89);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "Nom :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(359, 89);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 5;
            label2.Text = "Prénom :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(359, 211);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 6;
            label3.Text = "Mot de passe :";
            label3.Click += label3_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(359, 236);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(186, 27);
            textBoxPassword.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(83, 150);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 9;
            label5.Text = "Matricule :";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(83, 344);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 10;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(83, 211);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 11;
            label4.Text = "Email :";
            // 
            // textBoxMatricule
            // 
            textBoxMatricule.Location = new Point(83, 174);
            textBoxMatricule.Margin = new Padding(3, 4, 3, 4);
            textBoxMatricule.Name = "textBoxMatricule";
            textBoxMatricule.Size = new Size(186, 27);
            textBoxMatricule.TabIndex = 12;
            textBoxMatricule.TextChanged += textBox4_TextChanged;
            // 
            // textBoxPoste
            // 
            textBoxPoste.Location = new Point(359, 174);
            textBoxPoste.Margin = new Padding(3, 4, 3, 4);
            textBoxPoste.Name = "textBoxPoste";
            textBoxPoste.Size = new Size(186, 27);
            textBoxPoste.TabIndex = 13;
            // 
            // textBoxLeaveBalance
            // 
            textBoxLeaveBalance.Location = new Point(634, 174);
            textBoxLeaveBalance.Margin = new Padding(3, 4, 3, 4);
            textBoxLeaveBalance.Name = "textBoxLeaveBalance";
            textBoxLeaveBalance.Size = new Size(186, 27);
            textBoxLeaveBalance.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(359, 150);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 15;
            label6.Text = "Poste :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(634, 150);
            label7.Name = "label7";
            label7.Size = new Size(165, 20);
            label7.TabIndex = 16;
            label7.Text = "Solde De Congé Initial :";
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(41, 392);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.Size = new Size(833, 260);
            dataGridViewUsers.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(634, 89);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 19;
            label8.Text = "Rôle :";
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Collaborateur", "Chef de Projet", "Administrateur" });
            comboBoxRole.Location = new Point(634, 112);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(186, 28);
            comboBoxRole.TabIndex = 20;
            // 
            // textBoxCin
            // 
            textBoxCin.Location = new Point(83, 297);
            textBoxCin.Margin = new Padding(3, 4, 3, 4);
            textBoxCin.Name = "textBoxCin";
            textBoxCin.Size = new Size(186, 27);
            textBoxCin.TabIndex = 21;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(634, 236);
            textBoxPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(186, 27);
            textBoxPhoneNumber.TabIndex = 22;
            // 
            // textBoxAdresse
            // 
            textBoxAdresse.Location = new Point(359, 297);
            textBoxAdresse.Margin = new Padding(3, 4, 3, 4);
            textBoxAdresse.Name = "textBoxAdresse";
            textBoxAdresse.Size = new Size(186, 27);
            textBoxAdresse.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(634, 211);
            label9.Name = "label9";
            label9.Size = new Size(106, 20);
            label9.TabIndex = 24;
            label9.Text = "N° Télèphone :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(83, 272);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 25;
            label10.Text = "CIN :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(359, 272);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 26;
            label11.Text = "Adresse :";
            // 
            // button2
            // 
            button2.Location = new Point(83, 28);
            button2.Name = "button2";
            button2.Size = new Size(94, 32);
            button2.TabIndex = 27;
            button2.Text = "Retour";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBoxUsers
            // 
            comboBoxUsers.FormattingEnabled = true;
            comboBoxUsers.Items.AddRange(new object[] { "Collaborateur", "Chef de Projet", "Administrateur" });
            comboBoxUsers.Location = new Point(634, 296);
            comboBoxUsers.Name = "comboBoxUsers";
            comboBoxUsers.Size = new Size(186, 28);
            comboBoxUsers.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(634, 273);
            label12.Name = "label12";
            label12.Size = new Size(100, 20);
            label12.TabIndex = 29;
            label12.Text = "Responsable :";
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(945, 666);
            Controls.Add(label12);
            Controls.Add(comboBoxUsers);
            Controls.Add(button2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBoxAdresse);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxCin);
            Controls.Add(comboBoxRole);
            Controls.Add(label8);
            Controls.Add(dataGridViewUsers);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBoxLeaveBalance);
            Controls.Add(textBoxPoste);
            Controls.Add(textBoxMatricule);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxName);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddUser";
            Text = "AddUser";
            Load += AddUser_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxFirstName;
        private TextBox textBoxEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxPassword;
        private Label label5;
        private Button button1;
        private Label label4;
        private TextBox textBoxMatricule;
        private TextBox textBoxPoste;
        private TextBox textBoxLeaveBalance;
        private Label label6;
        private Label label7;
        private DataGridView dataGridViewUsers;
        private Label label8;
        private ComboBox comboBoxRole;
        private TextBox textBoxCin;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxAdresse;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button2;
        private ComboBox comboBoxUsers;
        private Label label12;
    }
}