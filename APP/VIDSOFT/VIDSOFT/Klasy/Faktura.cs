using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIDSOFT.Klasy
{
    class Faktura
    {
        string _NrFaktury;

        DateTime _DataWystawienia;
        DateTime _Data;
        int _TypFaktury; // 1- faktura sprzedaży; 2 - faktura zakupu
        Kontrahent _Klient;
        decimal _KwotaBrutto; //tutaj tylko get; decimal - zmienno przecinkowa double 
        decimal _KwotaNetto; //tylko get
        decimal _KwotaVat; // tylko get
        string _Uwagi;
        OperatorSystemu _Wystawiajacy;
        IList<Pozycja> _PozycjeFaktury;


        void obliczWartoscBrutto()
        {
            foreach (Pozycja o in _PozycjeFaktury)
            {
                this._KwotaBrutto += o.WartoscBrutto;
            }


        }



    }
}
