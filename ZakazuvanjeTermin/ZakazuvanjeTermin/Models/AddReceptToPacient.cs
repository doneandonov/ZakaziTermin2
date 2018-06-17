using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZakazuvanjeTermin.Models
{
    public class AddReceptToPacient
    {
        public int PacientID { get; set; }
        public int ReceptID { get; set; }
        public List<Recepta> recepti { get; set; }

        public AddReceptToPacient()
        {
            recepti = new List<Recepta>();
        }
    }
}