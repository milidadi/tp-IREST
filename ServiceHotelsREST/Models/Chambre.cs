using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceHotelsREST
{
    public class Chambre
    {
        public Chambre () { }
        public Chambre(int num, int nbLits, long prix)
        {
            this.num = num;
            this.nbLits = nbLits;
            this.prix = prix;
            this.reservations = new List<Reservation>();
        }

        public int num { get; set; }
        public int nbLits { get; set; }
        public long prix { get; set; }
        public string imageStr { get; set; }
        public List<Reservation> reservations;


        public Boolean getDisponibilite(DateTime dA, DateTime dD)
        {
            Boolean dispo = true;
            foreach (Reservation r in reservations)
            {
                if (DateTime.Compare(dA, r.dateDepart) < 0 || DateTime.Compare(r.dateArrivee, dD) <= 0)
                {
                    dispo = false;
                }
            }
            return dispo;
        }
    }
}