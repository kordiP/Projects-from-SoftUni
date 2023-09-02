namespace EgyptianDecimals
{
    internal class Program
    {
        static void Main()
        {
            List<int> lowersNeeded = new List<int>();
            int givenUpper = 7;
            int givenLower = 9;

            int newLower = SearchForLowerWithUpperEqualToOne(givenUpper, givenLower);
            lowersNeeded.Add(newLower);

            int diffUpper = UpperResultDifferenceOriginalDecimalAndCurrent(givenUpper, givenLower, newLower);
            int diffLower = LowerResultDifferenceOriginalDecimalAndCurrent(givenLower, newLower); 

            if (!IsDivisible(diffUpper, diffLower))
            {
                lowersNeeded.Add(SearchForLowerWithUpperEqualToOne(diffUpper, diffLower));
            }
            

            diffUpper = UpperResultDifferenceOriginalDecimalAndCurrent(diffUpper, diffLower, newLower);
            diffLower = LowerResultDifferenceOriginalDecimalAndCurrent(diffLower, newLower);

            if (!IsDivisible(diffUpper, diffLower))
            {
                lowersNeeded.Add(SearchForLowerWithUpperEqualToOne(diffUpper, diffLower));
            }

            foreach (int lower in lowersNeeded) { Console.WriteLine(lower + " "); }
        }
        static int SearchForLowerWithUpperEqualToOne(int upper, int lower)
        {
            return (upper + lower) / upper;
        }
        static int UpperResultDifferenceOriginalDecimalAndCurrent(int upper, int lower, int wantedLower)
        {
            return wantedLower * upper - lower;
        }
        static int LowerResultDifferenceOriginalDecimalAndCurrent(int lower, int wantedLower)
        {
            return wantedLower * lower;
        }
        static bool IsDivisible(int up, int down)
        {
            return true ? down % up == 0 : false;
        }
    }
}