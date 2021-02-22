using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.backend
{
    public class Aplikacja
    {

        public List<Pracownik> UtworzBazePracownikow()
        {
            string sciezka = @"C:\Users\patrky\source\repos\AplikacjaDzialKadriPlac\AplikacjaDzialKadriPlac\BazaPracownikow.json";

            string tekstpliku = File.ReadAllText(sciezka);

            return JsonConvert.DeserializeObject<List<Pracownik>>(tekstpliku);
        }
    }
}