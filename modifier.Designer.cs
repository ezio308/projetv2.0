
namespace projet
{
    partial class modifier
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
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.numtel = new System.Windows.Forms.TextBox();
            this.codecn = new System.Windows.Forms.TextBox();
            this.prenomconjoint = new System.Windows.Forms.TextBox();
            this.nomconjoint = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.grade = new System.Windows.Forms.TextBox();
            this.nbrenf = new System.Windows.Forms.TextBox();
            this.role = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.etatcivil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.CustomFormat = "yyyy-MM-dd";
            this.Date.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date.Location = new System.Drawing.Point(400, 54);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(124, 23);
            this.Date.TabIndex = 98;
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(619, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 47);
            this.button1.TabIndex = 97;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(586, 246);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 17);
            this.label16.TabIndex = 96;
            this.label16.Text = "role";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(586, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 17);
            this.label15.TabIndex = 95;
            this.label15.Text = "nbr enf";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(530, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 17);
            this.label14.TabIndex = 94;
            this.label14.Text = "prenom conjoint ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(551, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 17);
            this.label13.TabIndex = 93;
            this.label13.Text = "nom conjoint ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(290, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 17);
            this.label12.TabIndex = 92;
            this.label12.Text = "etat civil";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(290, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 91;
            this.label11.Text = "codecn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(290, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 90;
            this.label10.Text = "num tel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(290, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 89;
            this.label9.Text = "grade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(285, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 88;
            this.label8.Text = "adresse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(257, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 17);
            this.label7.TabIndex = 87;
            this.label7.Text = "date naissance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 86;
            this.label6.Text = "nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 85;
            this.label5.Text = "prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 84;
            this.label4.Text = "email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 83;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 82;
            this.label2.Text = "num CIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 81;
            this.label1.Text = "login";
            // 
            // nom
            // 
            this.nom.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(137, 376);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 23);
            this.nom.TabIndex = 80;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(137, 109);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 23);
            this.password.TabIndex = 79;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(137, 171);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 23);
            this.id.TabIndex = 78;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(137, 243);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 23);
            this.email.TabIndex = 77;
            // 
            // prenom
            // 
            this.prenom.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.Location = new System.Drawing.Point(137, 299);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(100, 23);
            this.prenom.TabIndex = 76;
            // 
            // adresse
            // 
            this.adresse.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresse.Location = new System.Drawing.Point(414, 109);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(100, 23);
            this.adresse.TabIndex = 75;
            // 
            // numtel
            // 
            this.numtel.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numtel.Location = new System.Drawing.Point(414, 243);
            this.numtel.Name = "numtel";
            this.numtel.Size = new System.Drawing.Size(100, 23);
            this.numtel.TabIndex = 74;
            // 
            // codecn
            // 
            this.codecn.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codecn.Location = new System.Drawing.Point(414, 299);
            this.codecn.Name = "codecn";
            this.codecn.Size = new System.Drawing.Size(100, 23);
            this.codecn.TabIndex = 73;
            // 
            // prenomconjoint
            // 
            this.prenomconjoint.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomconjoint.Location = new System.Drawing.Point(699, 109);
            this.prenomconjoint.Name = "prenomconjoint";
            this.prenomconjoint.Size = new System.Drawing.Size(100, 23);
            this.prenomconjoint.TabIndex = 71;
            // 
            // nomconjoint
            // 
            this.nomconjoint.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomconjoint.Location = new System.Drawing.Point(699, 56);
            this.nomconjoint.Name = "nomconjoint";
            this.nomconjoint.Size = new System.Drawing.Size(100, 23);
            this.nomconjoint.TabIndex = 70;
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(137, 54);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 23);
            this.login.TabIndex = 69;
            // 
            // grade
            // 
            this.grade.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade.Location = new System.Drawing.Point(414, 174);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(100, 23);
            this.grade.TabIndex = 99;
            // 
            // nbrenf
            // 
            this.nbrenf.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbrenf.Location = new System.Drawing.Point(699, 174);
            this.nbrenf.Name = "nbrenf";
            this.nbrenf.Size = new System.Drawing.Size(100, 23);
            this.nbrenf.TabIndex = 100;
            // 
            // role
            // 
            this.role.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.Location = new System.Drawing.Point(699, 243);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(100, 23);
            this.role.TabIndex = 101;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "marié ",
            "celibataire"});
            this.listBox1.Location = new System.Drawing.Point(450, 415);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 20);
            this.listBox1.TabIndex = 102;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(245, 415);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(186, 17);
            this.label17.TabIndex = 103;
            this.label17.Text = "etat civil a modifier";
            // 
            // etatcivil
            // 
            this.etatcivil.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etatcivil.Location = new System.Drawing.Point(414, 352);
            this.etatcivil.Name = "etatcivil";
            this.etatcivil.Size = new System.Drawing.Size(100, 23);
            this.etatcivil.TabIndex = 104;
            // 
            // modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(901, 496);
            this.Controls.Add(this.etatcivil);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.role);
            this.Controls.Add(this.nbrenf);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.password);
            this.Controls.Add(this.id);
            this.Controls.Add(this.email);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.numtel);
            this.Controls.Add(this.codecn);
            this.Controls.Add(this.prenomconjoint);
            this.Controls.Add(this.nomconjoint);
            this.Controls.Add(this.login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modifier";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.modifier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.TextBox numtel;
        private System.Windows.Forms.TextBox codecn;
        private System.Windows.Forms.TextBox prenomconjoint;
        private System.Windows.Forms.TextBox nomconjoint;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox grade;
        private System.Windows.Forms.TextBox nbrenf;
        private System.Windows.Forms.TextBox role;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox etatcivil;
    }
}