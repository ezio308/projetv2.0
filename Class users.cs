using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    class users
    {
        string login;
        string Motdepasse;
        string email;
        string name;
        string lastname;
        string adresse;
        int grade;
        string numtel;
        string codecn;
        string etatcivil;
        string nomconjoint;
        string prenomconjoint;
        int nbrenfants;
        int role;
        DateTime datedenaissance;
        float plafond;

        public users(string login, string motdepasse, string email, string name, string lastname, string adresse, int grade, string numtel, string codecn, string etatcivil, string nomconjoint, string prenomconjoint, int nbrenfants, int role, DateTime datedenaissance, float plafond)
        {
            this.Login = login;
            Motdepasse1 = motdepasse;
            this.Email = email;
            this.Name = name;
            this.Lastname = lastname;
            this.Adresse = adresse;
            this.Grade = grade;
            this.Numtel = numtel;
            this.Codecn = codecn;
            this.Etatcivil = etatcivil;
            this.Nomconjoint = nomconjoint;
            this.Prenomconjoint = prenomconjoint;
            this.Nbrenfants = nbrenfants;
            this.Role = role;
            this.Datedenaissance = datedenaissance;
            this.Plafond = plafond;
        }

        public string Login { get => login; set => login = value; }
        public string Motdepasse1 { get => Motdepasse; set => Motdepasse = value; }
        public string Email { get => email; set => email = value; }
        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int Grade { get => grade; set => grade = value; }
        public string Numtel { get => numtel; set => numtel = value; }
        public string Codecn { get => codecn; set => codecn = value; }
        public string Etatcivil { get => etatcivil; set => etatcivil = value; }
        public string Nomconjoint { get => nomconjoint; set => nomconjoint = value; }
        public string Prenomconjoint { get => prenomconjoint; set => prenomconjoint = value; }
        public int Nbrenfants { get => nbrenfants; set => nbrenfants = value; }
        public int Role { get => role; set => role = value; }
        public DateTime Datedenaissance { get => datedenaissance; set => datedenaissance = value; }
        public float Plafond { get => plafond; set => plafond = value; }
    }
}
