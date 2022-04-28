using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    class bulletins
    {
        string numbull;
        DateTime datedepot;
        string actedesc;
        float actefrais;
        string login;
        int reponse;

        public bulletins(string numbull, DateTime datedepot, string actedesc, float actefrais, string login, int reponse)
        {
            this.Numbull = numbull;
            this.Datedepot = datedepot;
            this.Actedesc = actedesc;
            this.Actefrais = actefrais;
            this.Login = login;
            this.Reponse = reponse;
        }

        public string Numbull { get => numbull; set => numbull = value; }
        public DateTime Datedepot { get => datedepot; set => datedepot = value; }
        public string Actedesc { get => actedesc; set => actedesc = value; }
        public float Actefrais { get => actefrais; set => actefrais = value; }
        public string Login { get => login; set => login = value; }
        public int Reponse { get => reponse; set => reponse = value; }
    }
}
