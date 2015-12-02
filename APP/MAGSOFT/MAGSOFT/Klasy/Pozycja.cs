using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MAGSOFT.Klasy
{
        class Pozycja
        {
            Towar _TowarPozycji;
            decimal _Ilosc;
            decimal _WartoscNetto;
            decimal _WartoscVat;
            decimal _WartoscBrutto;
            public decimal WartoscBrutto
            {
                get
                {
                    return this._WartoscBrutto;
                }

            }

        }
}
