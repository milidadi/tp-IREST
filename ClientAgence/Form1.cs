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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonChercher_Click(object sender, EventArgs e)
        {
            int nbLits = comboBox1.SelectedIndex;
            string dateArriveString = dateTimePickerArrivee.Value.ToString("yyyy/MM/dd");
            string dateDepartString = dateTimePickerDepart.Value.ToString("yyyy-MM-dd");
            DateTime dateArrive = DateTime.Parse(dateArriveString);
            DateTime dateDepart = DateTime.Parse(dateDepartString);
            DateTime dateNow = DateTime.Now;



            if (nbLits == -1)
            {
                MessageBox.Show("Veuillez choisir un nombre de lits");
            }
            else
            {
                if (dateArrive.Date < dateNow.Date)
                {
                    MessageBox.Show("Date Arrivée incorrecte");
                }
                else if (dateArrive.Date >= dateDepart.Date)
                {
                    MessageBox.Show("Date Depart ne doit pas etre inferieur a la date d'arriveé");
                }
                else
                {
                    nbLits++;

                    var request = System.Net.HttpWebRequest.Create(string.Format(@"https://localhost:44367/api/Hotel/GetHotel/"+nbLits));
                    request.ContentType = "application/json";
                    request.Method = "GET";
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
                                
                                JArray arrayRep = JArray.Parse(content);

                                Form2 f2 = new Form2(arrayRep,dateArrive,dateDepart);
                                f2.Show();
                                this.Hide();
                                
                            }
                        }
                    }
                }
            }
        }
    }
}
