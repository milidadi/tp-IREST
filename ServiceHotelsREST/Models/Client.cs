using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceHotelsREST
{
    public class Client
    {
        public Client() { }
        public Client(string nom, string prenom, string numCarte)
        {
            this.nomCLient = nom;
            this.prenomCLient = prenom;
            this.numCarte = numCarte;
        }


        public string nomCLient { get; set; }
        public string prenomCLient { get; set; }
        public string numCarte { get; set; }
       
    }
}