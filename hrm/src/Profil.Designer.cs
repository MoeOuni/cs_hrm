namespace hrm
{
    partial class Profil
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            fullName = new Label();
            matricule = new Label();
            leaveBalance = new Label();
            post = new Label();
            role = new Label();
            email = new Label();
            phone = new Label();
            cin = new Label();
            adr = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 36);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 0;
            label1.Text = "Nom et Prénom : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 80);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 1;
            label2.Text = "Matricule : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 124);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 2;
            label3.Text = "Sold de congé : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 167);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 3;
            label4.Text = "Poste : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 209);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 4;
            label5.Text = "Rôle : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 248);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 5;
            label6.Text = "Email : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 291);
            label7.Name = "label7";
            label7.Size = new Size(106, 25);
            label7.TabIndex = 6;
            label7.Text = "Télèphone : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 333);
            label8.Name = "label8";
            label8.Size = new Size(51, 25);
            label8.TabIndex = 7;
            label8.Text = "Cin : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 370);
            label9.Name = "label9";
            label9.Size = new Size(89, 25);
            label9.TabIndex = 8;
            label9.Text = "Adresse : ";
            // 
            // fullName
            // 
            fullName.AutoSize = true;
            fullName.Location = new Point(228, 36);
            fullName.Name = "fullName";
            fullName.Size = new Size(0, 25);
            fullName.TabIndex = 9;
            // 
            // matricule
            // 
            matricule.AutoSize = true;
            matricule.Location = new Point(228, 80);
            matricule.Name = "matricule";
            matricule.Size = new Size(0, 25);
            matricule.TabIndex = 10;
            // 
            // leaveBalance
            // 
            leaveBalance.AutoSize = true;
            leaveBalance.Location = new Point(228, 124);
            leaveBalance.Name = "leaveBalance";
            leaveBalance.Size = new Size(0, 25);
            leaveBalance.TabIndex = 11;
            // 
            // post
            // 
            post.AutoSize = true;
            post.Location = new Point(228, 167);
            post.Name = "post";
            post.Size = new Size(0, 25);
            post.TabIndex = 12;
            post.Click += label13_Click;
            // 
            // role
            // 
            role.AutoSize = true;
            role.Location = new Point(228, 209);
            role.Name = "role";
            role.Size = new Size(0, 25);
            role.TabIndex = 13;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(228, 248);
            email.Name = "email";
            email.Size = new Size(0, 25);
            email.TabIndex = 14;
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Location = new Point(228, 291);
            phone.Name = "phone";
            phone.Size = new Size(0, 25);
            phone.TabIndex = 15;
            // 
            // cin
            // 
            cin.AutoSize = true;
            cin.Location = new Point(228, 333);
            cin.Name = "cin";
            cin.Size = new Size(0, 25);
            cin.TabIndex = 16;
            // 
            // adr
            // 
            adr.AutoSize = true;
            adr.Location = new Point(228, 370);
            adr.Name = "adr";
            adr.Size = new Size(0, 25);
            adr.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(937, 36);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 18;
            button1.Text = "Retour";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Profil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(button1);
            Controls.Add(adr);
            Controls.Add(cin);
            Controls.Add(phone);
            Controls.Add(email);
            Controls.Add(role);
            Controls.Add(post);
            Controls.Add(leaveBalance);
            Controls.Add(matricule);
            Controls.Add(fullName);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Profil";
            Text = "Profil";
            Load += Profil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label fullName;
        private Label matricule;
        private Label leaveBalance;
        private Label post;
        private Label role;
        private Label email;
        private Label phone;
        private Label cin;
        private Label adr;
        private Button button1;
    }
}