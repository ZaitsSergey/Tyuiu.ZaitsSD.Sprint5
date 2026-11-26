using Tyuiu.ZaitsSD.Sprint5.Task4.V19.Lib;
namespace Tyuiu.ZaitsSD.Sprint5.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckNum()
        {
            string path = Path.GetTempFileName();
            try
            {
                File.WriteAllText(path, "1");
                double res = ds.LoadFromDataFile(path);
                Assert.AreEqual(3.426, res);
            }
            finally
            {
                File.Delete(path);
            }
        }

        [TestMethod]
        public void CheckZero()
        {
            string path = Path.GetTempFileName();
            try
            {
                File.WriteAllText(path, "0,0");
                double res = ds.LoadFromDataFile(path);
                Assert.AreEqual(0.0, res);
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
