namespace hrm
{
    partial class LeaveList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveList));
            dataGridView = new DataGridView();
            btn1 = new Button();
            cancelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(15, 140);
            dataGridView.Margin = new Padding(4, 4, 4, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(970, 464);
            dataGridView.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Location = new Point(15, 13);
            btn1.Margin = new Padding(4, 4, 4, 4);
            btn1.Name = "btn1";
            btn1.Size = new Size(148, 53);
            btn1.TabIndex = 1;
            btn1.Text = "Retour";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(837, 79);
            cancelBtn.Margin = new Padding(4);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(148, 53);
            cancelBtn.TabIndex = 2;
            cancelBtn.Text = "Annuler";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // LeaveList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1002, 647);
            Controls.Add(cancelBtn);
            Controls.Add(btn1);
            Controls.Add(dataGridView);
            Margin = new Padding(4, 4, 4, 4);
            Name = "LeaveList";
            Text = "LeaveList";
            Load += LeaveList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Button btn1;
        private Button cancelBtn;
    }
}