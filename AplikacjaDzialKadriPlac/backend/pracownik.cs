using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.backend
{
	public class Pracownik
	{
                public int id { get; set; }
                public string imie { get; set; }
                public string nazwisko { get; set; }

                public bool fizyczny { get; set; }

                public int stawka { get; set; }
                public int iloscPrzepracowanychDni { get; set; }
                public int iloscDniNaZwolnieniu { get; set; }
                public int podatekdochodowy { get; set; }
                public int zus { get; set; }
                public int netto { get; set; }
                public int brutto { get; set; }
                public int dowyplaty { get; set; }
	}
}