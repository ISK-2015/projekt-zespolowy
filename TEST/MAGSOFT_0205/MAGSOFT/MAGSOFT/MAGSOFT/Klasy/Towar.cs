using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MAGSOFT.Klasy
{
    class Towar
    {
        int _idTowar;
        int _Waga; //jeśli waga <= 1 to komperta; jeśli 1 < waga <=30 to poczka; jeśli waga >30 to paleta;
        int _Gabaryt; // wyrażony w m3; trzeba wprowadzić kiedy waga > 30kg;
        int _RodzajOpakowania; // 1 - paleta; 2 - paczka; 3 - koperta;
        GrupaTowarow _Grupa; // 1 - elektronika; 2 - motoryzacja; 3 - spożywcze; 4 - odzież; 5 - chemia; 6 - pozostałe; tylko get
        int _Jednostka; // 1 - sztuka; 2 - kg; 3 - paleta;
        int _CenaBrutto;
    }
}
