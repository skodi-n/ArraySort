using RadioApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    // Main Method
    public static void Main(String[] args)
    {
        int lautstärke = 10;
        double frequenz = 110.0;
        bool zustand = true;


        Radio radio = new Radio(zustand, lautstärke, frequenz);
        Console.WriteLine(radio.GetInfo());


    }
}
