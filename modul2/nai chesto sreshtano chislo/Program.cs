int[] array = { 1, 1, 2, 2, 2, 0, -2, 1, 3, 2, 1, 0, 0, 0, -2, -2, -2, -2, -2 };
int StartIndex = 0, CurrentIndex = 1;
int TopFrequent = array[0];
int CurrentFrequent = array[0]; //top frequent of the current pass of current index
int TopFrequency = 1; //number of occurancies of the most common
int CurrentFrequency = 1; //number of occurancies of the most common of the current pass

while (StartIndex < array.Length - 1)
{
    //set the StartIndex
    while (StartIndex < array.Length - 1 && array[StartIndex] == int.MinValue)
        StartIndex++;
    CurrentIndex = StartIndex + 1;
    //set the CurrentIndex
    while (CurrentIndex <= array.Length - 1 && array[CurrentIndex] == int.MinValue)
        CurrentIndex++;
    while (CurrentIndex < array.Length)
    {
        if (array[StartIndex] == array[CurrentIndex])
        {
            CurrentFrequent = array[StartIndex];
            CurrentFrequency++;
            array[CurrentIndex] = int.MinValue; //excluding for next pass?
        }
        CurrentIndex++;
    }
    if (CurrentFrequency >= TopFrequency)
    {
        TopFrequency = CurrentFrequency;
        TopFrequent = CurrentFrequent;
    }
    CurrentFrequency = 1; StartIndex++;
}
Console.WriteLine($"topFrequency = {TopFrequency}, topfrequent = {TopFrequent}");