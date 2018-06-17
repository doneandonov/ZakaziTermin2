using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZakazuvanjeTermin.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Pacient> pacients { get; set; }
        public Doctor()
        {
            pacients = new List<Pacient>();
        }

    }
}