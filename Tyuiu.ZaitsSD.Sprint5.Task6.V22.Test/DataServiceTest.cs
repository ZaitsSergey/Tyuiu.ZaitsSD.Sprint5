using Tyuiu.ZaitsSD.Sprint5.Task6.V22.Lib;
namespace Tyuiu.ZaitsSD.Sprint5.Task6.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckPairs()
        {
            string path = Path.GetTempFileName();
            try
            {
                File.WriteAllText(path, "сумма мама грамм");
                int res = ds.LoadFromDataFile(path);
                Assert.AreEqual(2, res);
            }
            finally
            {
                File.Delete(path);
            }
        }

        [TestMethod]
        public void CheckNoPairs()
        {
            string path = Path.GetTempFileName();
            try
            {
                File.WriteAllText(path, "мама");
                int res = ds.LoadFromDataFile(path);
                Assert.AreEqual(0, res);
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
