namespace projet
{
    partial class somme
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
            this.date = new System.Windows.Forms.ComboBox();
            this.s = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.annee = new System.Windows.Forms.ComboBox();
            this.mois = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.FormattingEnabled = true;
            this.date.Items.AddRange(new object[] {
            "un mois",
            "une année"});
            this.date.Location = new System.Drawing.Point(135, 110);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(169, 26);
            this.date.TabIndex = 0;
            this.date.SelectedIndexChanged += new System.EventHandler(this.date_SelectedIndexChanged);
            // 
            // s
            // 
            this.s.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.Location = new System.Drawing.Point(228, 347);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(129, 26);
            this.s.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "pendant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "la somme est :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "année";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(81, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "calculer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // annee
            // 
            this.annee.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annee.FormattingEnabled = true;
            this.annee.Location = new System.Drawing.Point(444, 110);
            this.annee.Name = "annee";
            this.annee.Size = new System.Drawing.Size(121, 26);
            this.annee.TabIndex = 7;
            // 
            // mois
            // 
            this.mois.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mois.FormattingEnabled = true;
            this.mois.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.mois.Location = new System.Drawing.Point(657, 110);
            this.mois.Name = "mois";
            this.mois.Size = new System.Drawing.Size(121, 26);
            this.mois.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(583, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "mois";
            // 
            // somme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mois);
            this.Controls.Add(this.annee);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.s);
            this.Controls.Add(this.date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "somme";
            this.Text = "somme";
            this.Load += new System.EventHandler(this.somme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox date;
        private System.Windows.Forms.TextBox s;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox annee;
        private System.Windows.Forms.ComboBox mois;
        private System.Windows.Forms.Label label4;
    }
}