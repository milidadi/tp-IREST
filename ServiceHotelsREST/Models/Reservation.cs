using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceHotelsREST
{
    public class Reservation
    {
        public Reservation( )
        {
            
        }
        public Reservation(Client client, DateTime arriv, DateTime depart)
        {
            this.client = client;
            this.dateArrivee = arriv;
            this.dateDepart = depart;
        }

        public Client client { get; set; }
        public DateTime dateArrivee { get; set; }
        public DateTime dateDepart { get; set; }
        public string nomHotel { get; set; }
        public int numChambre { get; set; }

    }
}