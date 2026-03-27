using Tyuiu.StachinskiiVS.Sprint3.Task3.V4.Lib;

namespace Tyuiu.StachinskiiVS.Sprint3.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService ds = new DataService();
            string str = "plkjjdw cvjkl";
            char letter = 'j';
            string res = ds.DeleteCharInString(str, letter);
            string wait = "plkdw cvkl";
            Assert.AreEqual(wait, res);
        }
    }
}