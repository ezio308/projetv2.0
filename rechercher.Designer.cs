
namespace projet
{
    partial class rechercher
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clear = new System.Windows.Forms.Button();
            this.valider = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(688, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.SteelBlue;
            this.clear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clear.Location = new System.Drawing.Point(72, 305);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(191, 64);
            this.clear.TabIndex = 1;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // valider
            // 
            this.valider.BackColor = System.Drawing.Color.SteelBlue;
            this.valider.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.valider.Location = new System.Drawing.Point(322, 305);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(191, 64);
            this.valider.TabIndex = 2;
            this.valider.Text = "valider";
            this.valider.UseVisualStyleBackColor = false;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(542, 322);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(123, 22);
            this.ID.TabIndex = 3;
            // 
            // rechercher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rechercher";
            this.Text = "rechercher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.TextBox ID;
    }
}