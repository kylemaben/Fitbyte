using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace fitbytecode
{
    internal class Program
    {
        static void Main(string[] args)
        {//new object person
            FitByte name = new FitByte(26, 80);
            // calls from new person and refrences heartrate
            double THR = name.TargetHeartRate(190);
            // uses new persons data and pulls the static fitness tips
            name.DisplayFitnessTips();

            steptracker step = new steptracker(100, "mike");

            step.stepsyeah();

            step.stepsback();
            
        }
    }
}
