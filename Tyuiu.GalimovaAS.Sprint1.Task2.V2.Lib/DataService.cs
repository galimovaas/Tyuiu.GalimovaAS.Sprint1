using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GalimovaAS.Sprint1.Task2.V2.Lib
{
    public class DataService : ISprint1Task2V2

    {
        public double ConvertAngleToRad(int value)
        {
            return Math.Round( (value / 57.295779), 3);
        }
    }
}
