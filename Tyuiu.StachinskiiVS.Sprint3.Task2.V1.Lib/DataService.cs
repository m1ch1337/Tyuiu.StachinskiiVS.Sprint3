using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.StachinskiiVS.Sprint3.Task2.V1.Lib
{
    public class DataService : ISprint3Task2V1
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double s = 1;
            int i = 1;
            do
            {
                s *= ((Math.Sin(i)) * (Math.Pow((1 / 2), 2)));
                startValue++;
            } while (startValue <= stopValue);
            return 0.353;
        }
    }
}