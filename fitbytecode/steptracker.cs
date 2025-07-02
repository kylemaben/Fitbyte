using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace fitbytecode
{
    internal class steptracker
    {
        private int stepstaken; // field

        public int Stepstaken   // property
        {
            get { return stepstaken; }   // get method
            set { stepstaken = value; }  // set method

        }
        private string name; // field

        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method


        }
        public steptracker()
        {
            name = "boop";
            this.stepstaken = 0;
            Console.WriteLine(" DEFAULT you've taken 0 steps today");
        }
        public steptracker(int stepstakentoday,string name)

        {
            this.name = name;
            this.stepstaken = stepstakentoday;
            stepstakentoday = 1000;
            Console.WriteLine(" you've taken " + stepstakentoday + " steps today");
        }
        public void stepsyeah()   // method
        {
            Console.WriteLine("WOW THATS A LOT OF STEPS");
        }
        public int stepsback()   // method
        {
            return stepstaken;
        }
    }
}



