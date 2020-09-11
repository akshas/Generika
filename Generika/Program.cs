using System;
using System.Collections.Generic;

namespace Generika
{
    class Bisher
    {
        public List<int> intListe = new List<int>();
        public List<string> stringListe = new List<string>();
        public List<bool> boolListe = new List<bool>();

        public Bisher()
        {
            
        }
    }

    public interface DuDarfst
    {
        
    }
    class Klasse1 : DuDarfst
    {

    }

    class Klasse2 : DuDarfst
    {
        
    }
    class Klasse3 
    {
        
    }
    class Klasse4 : Klasse1
    {
    
    }


    class GenericshMitCOnstraint<T> where T : DuDarfst
    {

    }

    class BrandNeu<T> //Ein generische klasse mit dem "Parameter" <T>
    {
        public Type MeinTyp;
        public List<T> AllZweckListe = new List<T>();

        public BrandNeu()
        {
            MeinTyp = typeof(T);
            Console.WriteLine(MeinTyp);
        }

        public void Methode1(int wert)
        {

        }
        public void Methode1(string wert)
        {

        }
        public void Methode1()
        {

        }
        public void Methode1(T wert)
        {

        }
        public void Methode2<egalWas>(egalWas wert)
        {
            Console.WriteLine(wert);
        }
        public egal Met3<egal>(egal wert)
        {
           int NewWert = ((int)Convert.ChangeType(wert, typeof(egal))) * 2;

           return (egal)Convert.ChangeType(NewWert, typeof(egal));
        }

        public void Met4<T_wert1, T_wert2, T_wert3> (T_wert1 w1, T_wert2 w2, T_wert3 w3, int w4)
        {
            Console.WriteLine($"{w1}, {w2}, {w3}, {w4}"); 
        }
    }

    class CurryWurst
    {
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            Bisher Alte_Weise = new Bisher();
            Alte_Weise.intListe.Add(123);
            Alte_Weise.intListe.Add(234);
            Alte_Weise.stringListe.Add("Susi");
            Alte_Weise.stringListe.Add("Paul");
            Alte_Weise.boolListe.Add(true);
            Alte_Weise.boolListe.Add(false);
            

            // BRANDNEU
            BrandNeu<int> GenericObj = new BrandNeu<int>();
            GenericObj.AllZweckListe.Add(111);
            GenericObj.AllZweckListe.Add(222);
            GenericObj.AllZweckListe.Add(333);
            BrandNeu<string> GenericObj2 = new BrandNeu<string>();
            GenericObj2.AllZweckListe.Add("sdflkj");


            CurryWurst Lecker = new CurryWurst();
            CurryWurst SuperLecker = new CurryWurst();

            BrandNeu<CurryWurst> NewGenObj = new BrandNeu<CurryWurst>();

            NewGenObj.AllZweckListe.Add(Lecker);
            NewGenObj.AllZweckListe.Add(SuperLecker);

            BrandNeu<int> NochEineGen = new BrandNeu<int>();
            NochEineGen.Methode1(2);
            NochEineGen.Methode1("Susi");
            NochEineGen.Methode1();
            NochEineGen.Methode2("Pups");
            //NochEineGen.Met3("someString");
            //NochEineGen.Met3(1111111);
            //NochEineGen.Met3(true);

            int IchWeisNicht = NochEineGen.Met3(3);
            NochEineGen.Methode2("333");
            Console.WriteLine(IchWeisNicht);

            NochEineGen.Met4(1, "string", 'c', 223);



            Klasse1 objekt1 = new Klasse1();
            Klasse2 objekt2 = new Klasse2();
            Klasse3 objekt3 = new Klasse3();

            // Generi vererbt sich von dem Interface GenericshMitCOnstraint
            GenericshMitCOnstraint<Klasse1> Generi = new GenericshMitCOnstraint<Klasse1>();
            GenericshMitCOnstraint<Klasse2> Generi2 = new GenericshMitCOnstraint<Klasse2>();

            // Klasse vererbt nicht einen Interface
           // GenericshMitCOnstraint<Klasse3> Generi3 = new GenericshMitCOnstraint<Klasse3>();
            GenericshMitCOnstraint<Klasse4> Generi4 = new GenericshMitCOnstraint<Klasse4>();

        }
    }
}
