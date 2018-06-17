using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZakazuvanjeTermin.Models
{
    public class Pacient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  EMBG { get; set; }
        public string KrvnaGrupa { get; set; }
        public Doctor Doctor { get; set; }
        public List<Recepta> recepti { get; set; }
        public Pacient()
        {
            Doctor = new Doctor();
            recepti = new List<Recepta>();
        }
    }
}