using Tyuiu.StachinskiiVS.Sprint3.Task0.V12.Lib;

namespace Tyuiu.StachinskiiVS.Sprint3.Task0.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 1;
            int st = 1;
            int en = 13;
            double res = ds.GetMultiplySeries(value, st, en);
            double wait = 7.5;
            Assert.AreEqual(wait, res);
        }
    }
}