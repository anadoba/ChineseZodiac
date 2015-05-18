using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Chinski_Zodiak.Model
{
    public class Znak
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }

        public Znak()
        {
        }

        public Znak(string nazwa, string opis)
        {
            Nazwa = nazwa;
            Opis = opis;
        }
    }
}
