using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace ServiceHotelsREST.Controllers
{
    public class HotelController : ApiController
    {

        //GET api/Chambre/GetHotel
        //https://localhost:44367/api/Hotel/GetHotel/nbLits
        public Hotel[] GetHotel(long id)
        {
            string imageStr1 = "";
            System.Drawing.Image image1 = System.Drawing.Image.FromFile(System.Web.HttpContext.Current.Server.MapPath("~/img") + @"\chambre1.png");
            System.IO.MemoryStream stream1 = new System.IO.MemoryStream();
            image1.Save(stream1, System.Drawing.Imaging.ImageFormat.Png);
            byte[] imageByte1 = stream1.ToArray();
            imageStr1 = Convert.ToBase64String(imageByte1);
            stream1.Dispose();
            image1.Dispose();

            string imageStr2 = "";
            System.Drawing.Image image2 = System.Drawing.Image.FromFile(System.Web.HttpContext.Current.Server.MapPath("~/img") + @"\chambre2.png");
            System.IO.MemoryStream stream2 = new System.IO.MemoryStream();
            image2.Save(stream2, System.Drawing.Imaging.ImageFormat.Png);
            byte[] imageByte2 = stream2.ToArray();
            imageStr2 = Convert.ToBase64String(imageByte2);
            stream2.Dispose();
            image2.Dispose();

            if (id == 1)
            {
                

                return new Hotel[]
                {
                new Hotel
                {
                    id = 04,
                    nomHotel = "f1",
                    categorie = "bien",
                    payes = "France",
                    ville = "Montpellier",
                    rue = "triolet",
                    numeroRue = 21,
                    nbEtoiles = 4,
                    chambres = new Chambre[]
                    {
                        new Chambre
                        {
                            num = 1,
                            nbLits = 1,
                            prix = 45,
                            imageStr = imageStr1
                        },
                        new Chambre
                        {
                            num = 3,
                            nbLits = 1,
                            prix = 30,
                            imageStr = imageStr1
                        },
                        new Chambre
                        {
                            num = 2,
                            nbLits = 1,
                            prix = 35,
                            imageStr = imageStr1
                        }

                    }
                },
                new Hotel
                {
                    id = 03,
                    nomHotel = "IBIS",
                    categorie = "cool",
                    payes = "France",
                    ville = "Paris",
                    rue = "Sarcelle",
                    numeroRue = 41,
                    nbEtoiles = 2,
                    chambres = new Chambre[]
                    {
                        new Chambre
                        {
                            num = 1,
                            nbLits = 1,
                            prix = 45,
                            imageStr = imageStr2
                        },
                        new Chambre
                        {
                            num = 3,
                            nbLits = 1,
                            prix = 30,
                            imageStr = imageStr2
                        },
                        new Chambre
                        {
                            num = 2,
                            nbLits = 1,
                            prix = 35,
                            imageStr = imageStr2
                        }

                    }
                }
                };
            }
            else if (id == 2)
            {
                return new Hotel[]
            {
                new Hotel
                {
                    id = 04,
                    nomHotel = "f1",
                    categorie = "bien",
                    payes = "France",
                    ville = "Montpellier",
                    rue = "triolet",
                    numeroRue = 21,
                    nbEtoiles = 4,
                    chambres = new Chambre[]
                    {
                        new Chambre
                        {
                            num = 1,
                            nbLits = 2,
                            prix = 55,
                            imageStr = imageStr1
                        },
                        new Chambre
                        {
                            num = 3,
                            nbLits = 2,
                            prix = 40,
                            imageStr = imageStr1
                        },
                        new Chambre
                        {
                            num = 2,
                            nbLits = 2,
                            prix = 45,
                            imageStr = imageStr1
                        }

                    }
                },
                new Hotel
                {
                    id = 03,
                    nomHotel = "IBIS",
                    categorie = "cool",
                    payes = "France",
                    ville = "Paris",
                    rue = "Sarcelle",
                    numeroRue = 41,
                    nbEtoiles = 2,
                    chambres = new Chambre[]
                    {
                        new Chambre
                        {
                            num = 1,
                            nbLits = 2,
                            prix = 55,
                            imageStr = imageStr2
                        },
                        new Chambre
                        {
                            num = 3,
                            nbLits = 2,
                            prix = 40,
                            imageStr = imageStr2
                        },
                        new Chambre
                        {
                            num = 2,
                            nbLits = 2,
                            prix = 75,
                            imageStr = imageStr2
                        }

                    }
                }
            };

            }
            else if (id == 3)
            {
                return new Hotel[]
            {
                new Hotel
                {
                    id = 04,
                    nomHotel = "f1",
                    categorie = "bien",
                    payes = "France",
                    ville = "Montpellier",
                    rue = "triolet",
                    numeroRue = 21,
                    nbEtoiles = 4,
                    chambres = new Chambre[]
                    {
                        new Chambre
                        {
                            num = 1,
                            nbLits = 3,
                            prix = 70,
                            imageStr = imageStr1
                        },
                        new Chambre
                        {
                            num = 3,
                            nbLits = 3,
                            prix = 45,
                            imageStr = imageStr1
                        },
                        new Chambre
                        {
                            num = 2,
                            nbLits = 3,
                            prix = 55,
                            imageStr = imageStr1
                        }

                    }
                },
                new Hotel
                {
                    id = 03,
                    nomHotel = "IBIS",
                    categorie = "cool",
                    payes = "France",
                    ville = "Paris",
                    rue = "Sarcelle",
                    numeroRue = 41,
                    nbEtoiles = 2,
                    chambres = new Chambre[]
                    {
                        new Chambre
                        {
                            num = 1,
                            nbLits = 3,
                            prix = 75,
                            imageStr = imageStr2
                        },
                        new Chambre
                        {
                            num = 3,
                            nbLits = 3,
                            prix = 50,
                            imageStr = imageStr2
                        },
                        new Chambre
                        {
                            num = 2,
                            nbLits = 3,
                            prix = 80,
                            imageStr = imageStr2
                        }

                    }
                }
            };


            }
            else { return null; }
        }

        //https://localhost:44367/api/Hotel/PostReserv
        [HttpPost]
        public string PostReserv(JArray res)
        {
            string numeroREser = "";
            foreach (var reserv in res)
            {
                new Reservation
                {
                    client = new Client
                    {
                        nomCLient = reserv["nomClient"].ToString(),
                        numCarte = reserv["numCarte"].ToString(),
                        prenomCLient = reserv["prenomClient"].ToString()
                    },
                    dateArrivee = DateTime.Parse(reserv["dateArrivee"].ToString()),
                    dateDepart = DateTime.Parse(reserv["dateDepart"].ToString())
                };
                numeroREser = reserv["nomClient"].ToString() + DateTime.Parse(reserv["dateArrivee"].ToString()).Day + DateTime.Parse(reserv["dateDepart"].ToString()).Day;
            }
            return numeroREser;
        }
    }
}
        
    
