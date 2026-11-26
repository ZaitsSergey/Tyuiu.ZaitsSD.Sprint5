using Tyuiu.ZaitsSD.Sprint5.Task5.V24.Lib;
namespace Tyuiu.ZaitsSD.Sprint5.Task5.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckSum()
        {
            string path = Path.GetTempFileName();
            try
            {
                File.WriteAllText(path, "8 10 -20 99 100 5.75\n -9 -100");
                double res = ds.LoadFromDataFile(path);
                Assert.AreEqual(89.0, res);
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
