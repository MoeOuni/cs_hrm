﻿namespace hrm
{
    partial class AllLeaves
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
            button3 = new Button();
            dataGridViewAllLeaves = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllLeaves).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(14, 15);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Retour";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridViewAllLeaves
            // 
            dataGridViewAllLeaves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllLeaves.Location = new Point(14, 63);
            dataGridViewAllLeaves.Name = "dataGridViewAllLeaves";
            dataGridViewAllLeaves.RowHeadersWidth = 51;
            dataGridViewAllLeaves.Size = new Size(814, 368);
            dataGridViewAllLeaves.TabIndex = 5;
            // 
            // AllLeaves
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dataGridViewAllLeaves);
            Controls.Add(button3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AllLeaves";
            Text = "AllLeaves";
            Load += AllLeaves_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllLeaves).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private DataGridView dataGridViewAllLeaves;
    }
}