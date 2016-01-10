using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIDSOFT.Klasy
{
    class Zamowienie
    {
        Kontrahent _Zamawiajacy;
        DateTime _DataZlozeniaZamowienia;
        DateTime _DataRealizacji;
        Towar _TowarZamawiany;
        int _IloscZamowienia;
        decimal _KwotaZamowienia;
        int _IdZamowienia;
    }
}
