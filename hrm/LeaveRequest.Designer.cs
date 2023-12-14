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
            type.Location = new Point(35, 108);
            type.Margin = new Padding(3, 4, 3, 4);
            type.Name = "type";
            type.Size = new Size(383, 26);
            type.TabIndex = 0;
            // 
            // startDate
            // 
            startDate.Location = new Point(35, 176);
            startDate.Margin = new Padding(3, 4, 3, 4);
            startDate.Name = "startDate";
            startDate.Size = new Size(383, 27);
            startDate.TabIndex = 1;
            // 
            // endDate
            // 
            endDate.Location = new Point(35, 250);
            endDate.Margin = new Padding(3, 4, 3, 4);
            endDate.Name = "endDate";
            endDate.Size = new Size(383, 27);
            endDate.TabIndex = 2;
            endDate.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // motif
            // 
            motif.Location = new Point(35, 327);
            motif.Margin = new Padding(3, 4, 3, 4);
            motif.Name = "motif";
            motif.Size = new Size(383, 115);
            motif.TabIndex = 3;
            motif.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(35, 80);
            label1.Name = "label1";
            label1.Size = new Size(180, 20);
            label1.TabIndex = 4;
            label1.Text = "Type de la demande : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(35, 149);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 5;
            label2.Text = "Date de début :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(35, 224);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 6;
            label3.Text = "Date de fin :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(35, 300);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "Motif";
            // 
            // submit
            // 
            submit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            submit.Location = new Point(35, 462);
            submit.Margin = new Padding(3, 4, 3, 4);
            submit.Name = "submit";
            submit.Size = new Size(114, 35);
            submit.TabIndex = 8;
            submit.Text = "Soumettre";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(35, 21);
            button1.Name = "button1";
            button1.Size = new Size(103, 36);
            button1.TabIndex = 9;
            button1.Text = "Retour";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LeaveRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(466, 581);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "LeaveRequest";
            Text = "LeaveRequest";
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