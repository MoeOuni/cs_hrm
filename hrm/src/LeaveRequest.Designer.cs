namespace hrm
{
    partial class LeaveRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveRequest));
            type = new ComboBox();
            startDate = new DateTimePicker();
            endDate = new DateTimePicker();
            motif = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            submit = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // type
            // 
            type.FormattingEnabled = true;
            type.Items.AddRange(new object[] { "Congé Annuel", "Congé Sans Solde", "Congé Maladie", "Autorisation", "Télétravail", "Autre Absence" });
            type.Location = new Point(44, 150);
            type.Margin = new Padding(4, 6, 4, 6);
            type.Name = "type";
            type.Size = new Size(478, 33);
            type.TabIndex = 0;
            // 
            // startDate
            // 
            startDate.Location = new Point(44, 244);
            startDate.Margin = new Padding(4, 6, 4, 6);
            startDate.Name = "startDate";
            startDate.Size = new Size(478, 31);
            startDate.TabIndex = 1;
            // 
            // endDate
            // 
            endDate.Location = new Point(44, 347);
            endDate.Margin = new Padding(4, 6, 4, 6);
            endDate.Name = "endDate";
            endDate.Size = new Size(478, 31);
            endDate.TabIndex = 2;
            // 
            // motif
            // 
            motif.Location = new Point(44, 454);
            motif.Margin = new Padding(4, 6, 4, 6);
            motif.Name = "motif";
            motif.Size = new Size(478, 158);
            motif.TabIndex = 3;
            motif.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(44, 111);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(219, 28);
            label1.TabIndex = 4;
            label1.Text = "Type de la demande : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(44, 207);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 28);
            label2.TabIndex = 5;
            label2.Text = "Date de début :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(44, 311);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 6;
            label3.Text = "Date de fin :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(44, 417);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 7;
            label4.Text = "Motif";
            // 
            // submit
            // 
            submit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            submit.Location = new Point(44, 642);
            submit.Margin = new Padding(4, 6, 4, 6);
            submit.Name = "submit";
            submit.Size = new Size(142, 49);
            submit.TabIndex = 8;
            submit.Text = "Soumettre";
            submit.UseVisualStyleBackColor = true;
            submit.Click += SubmitLeaveRequest;
            // 
            // button1
            // 
            button1.Location = new Point(44, 29);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(129, 50);
            button1.TabIndex = 9;
            button1.Text = "Retour";
            button1.UseVisualStyleBackColor = true;
            button1.Click += NavigateToHome;
            // 
            // LeaveRequest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(582, 807);
            Controls.Add(button1);
            Controls.Add(submit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(motif);
            Controls.Add(endDate);
            Controls.Add(startDate);
            Controls.Add(type);
            DoubleBuffered = true;
            Margin = new Padding(4, 6, 4, 6);
            Name = "LeaveRequest";
            Text = "LeaveRequest";
            Load += LeaveRequest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox type;
        private DateTimePicker startDate;
        private DateTimePicker endDate;
        private RichTextBox motif;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button submit;
        private Button button1;
    }
}