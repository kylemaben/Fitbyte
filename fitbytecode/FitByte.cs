using System; // For console output
namespace fitbytecode
{




    public class FitByte
    {
        // Private storage for age
        private int _age;
        // Private storage for resting heart rate
        private int _restingHeartRate;

        public int Age
        {
            // Get age
            get { return _age; }
            // Set age
            set { _age = value; }
        }

        public int RestingHeartRate
        {
            // Get resting heart rate
            get { return _restingHeartRate; }
            // Set resting heart rate
            set { _restingHeartRate = value; }
        }

        public FitByte()
        {
            // Default age 25
            this._age = 25;
            // Default resting HR 70
            this._restingHeartRate = 70;
            // Default FitByte created
            Console.WriteLine("FitByte object created with default values (Age: 25, Resting HR: 70)");
        }

        public FitByte(int age, int restingHR)
        {
            // Set age from input
            this._age = age;
            // Set resting HR from input
            this._restingHeartRate = restingHR;
            // Custom FitByte created
            Console.WriteLine($"FitByte object created with custom values (Age: {age}, Resting HR: {restingHR})");
        }

        public double TargetHeartRate(double percentageOfMaximum)
        {
            // Calculate max heart rate
            double maxHR = 206.3 - (0.711 * _age);
            // Apply Karvonen formula
            double targetHR = (maxHR - _restingHeartRate) * percentageOfMaximum + _restingHeartRate;
            // Return target HR
            return targetHR;
        }

        public void DisplayFitnessTips()
        {
            // Fitness tips header
            Console.WriteLine("\n--- Fitness Tips from FitByte ---");
            // Tip 1
            Console.WriteLine("1 Aim for at least 30 minutes of moderate-intensity exercise most days");
            // Tip 2
            Console.WriteLine("2 Stay hydrated by drinking plenty of water daily");
            // Tip 3
            Console.WriteLine("3 Combine cardio and strength training");
            // Tip 4
            Console.WriteLine("4 Listen to your body allow for rest and recovery");
            // Tips footer
            Console.WriteLine("---------------------------------");
        }
    }
}

