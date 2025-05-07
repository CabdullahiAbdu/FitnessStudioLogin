using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using PropertyChanged;

namespace NutzerLogin
{
    [AddINotifyPropertyChangedInterface]
    internal class User
    {
        public User(int id, string vorname, string nachname, string email, DateOnly geburtstag, string straße, int pLZ, string ort, string rolle)
        {
            Id = id;
            Vorname = vorname;
            Nachname = nachname;
            Email = email;
            Geburtstag = geburtstag;
            Straße = straße;
            PLZ = pLZ;
            Ort = ort;
            Rolle = rolle;
        }

        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Email { get; set; }
        public DateOnly Geburtstag { get; set; }
        public string Straße { get; set; }  
        public int PLZ  { get; set; }
        public string Ort { get; set; }
        public string Rolle { get; set; }



    }
}
