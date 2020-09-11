using System;
using System.Collections.Generic;
using System.Text;

namespace GenerikaAufgaben
{
    /// <summary>
    /// Schreibt eine generische Methode
    /// Diese Methode nimt 2 Parameter vom Typ T an
    /// Tauscht die Werte
    /// Testen mit INT, DOUBLE, STRING, BOOL, egal was noch
    /// </summary>
    class Aufgabe1<T>
    {
        public void EineGenerischeMethode<T_wert>(ref T_wert wert, ref T_wert wert2)
        {
            //T_wert tmp = wert;
            //wert = wert2;
            //wert2 = tmp;

            (wert, wert2) = (wert2, wert);
        }
    }
}
