using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApp
{
    internal class Radio
    {

        const double DEFAULT_FREQUENCY = 99.9;

        bool _isOn;
        int _volume;
        double _frequency;


        public double Frequency 
        {
            set 
            {
                if (value >= 85 && value <= 110)
                {

                    _frequency = value;

                }

                else 
                { 
                
                    _frequency = DEFAULT_FREQUENCY;
                
                }




            }

            
        
        
        }

        int Volume
        {
            set
            {
                if ((value >= 0) && (value <= 10))
                {

                    _volume = value;

                }


            }

            get {

                return _volume;
            }
        }



        public Radio()
        {
            _isOn = false;
            Volume = 5;
            Frequency = 111;


        }

        public Radio(bool ison, int volume, double frequency)
        {
            Frequency = frequency;
            _isOn = ison;
            Volume = volume;

        }

  

        public void TurnOff()
        {

            _isOn = false;

        }

        public void TurnOn()
        {

            _isOn = true;

        }

        



        public void TurnUp()
        {

            if (_isOn == true)
            {


                Volume++;


            }

        }

        public void TurnDown()
        {
            if (_isOn == true)
            {
                Volume--;
            }
        }

        public string GetInfo()
        {
            if (_isOn == true)
            {

                return "Radio an: Freq: " + _frequency + ", " + "Laut: " + _volume;
            }

            else
            {

                return "Radio ist aus!";
            }




        }




    }


}
