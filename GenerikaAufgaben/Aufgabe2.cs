using System;
using System.Collections.Generic;
using System.Text;

namespace GenerikaAufgaben
{
    
    public  class ArrayToList<T>
    {
        T[] MeineListe = { }; 

        public  void Add<wert>(ref wert[] arr, wert w) 
        {
            Array.Resize(ref arr, arr.Length + 1);
            int length = arr.Length;
            arr[length-1] = w;
        }
     
        public void Remove<wert>(ref wert[]arr, wert w)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i].Equals(w))
                {
                    for (int j = i; j<arr.Length-1;j++)
                    {
                        (arr[j], arr[j+1]) = (arr[j+1], arr[j]);
                    }
                    Array.Resize(ref arr, arr.Length - 1);
                }
            }
        }
    }


    public class Aufgabe2
    {
        
    }
}
