using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfDotNet
{
    internal class Bird
    {
        public string name;
        public float weight;
        public string CommonRegion;
        
        public void DisplayBird() 
        {
            Console.WriteLine(name);
            Console.WriteLine(CommonRegion);    
            Console.Write(weight);
        }

        public void DetermineType()
        {
            string[] arr = { "penguin", "duck", "chicken", "ostrich" };
            string str ="";
            for(int i=0;i<=arr.Length;i++)
            {
                if (name == arr[0])
                {
                    str = "The bird can not fly.";
                }
                else
                {
                    str = "The bird can fly.";
                }
            }
            Console.WriteLine(str);
        }        
    }

    internal class Flightless : Bird
    {
        public void Display()
        {   

            Console.WriteLine("Added to flightlessbird");
        }
    }

    internal class Flight : Bird
    {
        public void Display()
        {
            Console.WriteLine("Added to birds that can fly");
        }
    }


}
