using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientAgence
{
    public partial class Form2 : Form
    {
        public Form2(JArray offresJson, DateTime dArriv, DateTime dDepart)
        {
            InitializeComponent();
            this.dateArrivee = dArriv;
            this.dateDepart = dDepart;
            this.listOffres = offresJson;
            List<string> listeOffresStr = new List<string>();
            double nbNuits = (dDepart - dArriv).TotalDays;

            foreach (var item in this.listOffres)
            {
                foreach (var ch in item["chambres"]) 
                { 
                    listeOffresStr.Add("Nom Hotel : "+item["nomHotel"]+", payes : "+ item["payes"] + ", ville : " + item["ville"] + ", cartier : " + item["rue"]+
                        ", nombre lits : "+ch["nbLits"] +", prix nuit : "+ch["prix"]+"euro, prix total : "+(nbNuits * Convert.ToInt32(ch["prix"]))+" euro.");
                    this.listImagsStr.Add(ch["imageStr"].ToString());
                }
            }
            listBoxOffres.DataSource = listeOffresStr;
            
        }

        public JArray listOffres { set; get; }
        public DateTime dateArrivee { set; get; }
        public DateTime dateDepart { set; get; }
        List<string> listImagsStr = new List<string>();

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonReserver_Click(object sender, EventArgs e)
        {
            string nomClient = textBoxNom.Text;
            string prenomClient = textBoxPrenom.Text;
            string cbClient = textBoxCB.Text;

            if (nomClient == "" || prenomClient == "" || cbClient == "")
            {
                MessageBox.Show("Veuillez remplir tout les champs pour effectuer une reservation");
            }
            else
            {
                var request = System.Net.HttpWebRequest.Create(string.Format(@"https://localhost:44367/api/Hotel/PostReserv"));
                request.ContentType = "application/json";
                request.Method = "POST";

                JObject reservationObject = new JObject();
                reservationObject["nomClient"] = nomClient;
                reservationObject["numCarte"] = cbClient;
                reservationObject["prenomClient"] = prenomClient;
                reservationObject["dateArrivee"] = this.dateArrivee;
                reservationObject["dateDepart"] = this.dateDepart;


                JArray reservation = new JArray();
                reservation.Add(reservationObject);
                byte[] sentData = Encoding.UTF8.GetBytes(reservation.ToString());
                request.ContentLength = sentData.Length;

                using (System.IO.Stream sendStream = request.GetRequestStream())
                {
                    sendStream.Write(sentData, 0, sentData.Length);
                    sendStream.Close();

                }


                using (HttpWebResponse reponse = request.GetResponse() as HttpWebResponse)
                {
                    if (reponse.StatusCode != HttpStatusCode.OK)
                    {
                        Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", reponse.StatusCode);
                    }

                    using (StreamReader reader = new StreamReader(reponse.GetResponseStream()))
                    {
                        var content = reader.ReadToEnd();
                        if (string.IsNullOrWhiteSpace(content))
                        {
                            MessageBox.Show("Aucun Hotel disponible pour l'instant");
                        }
                        else
                        {
                            MessageBox.Show("Chambre résérvé avec succé, voici votre code de résérvation : "+content);
                        }
                    }
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageForm imageform = new ImageForm(listImagsStr[this.listBoxOffres.SelectedIndex]);
            imageform.Show();
        }
    }
}
