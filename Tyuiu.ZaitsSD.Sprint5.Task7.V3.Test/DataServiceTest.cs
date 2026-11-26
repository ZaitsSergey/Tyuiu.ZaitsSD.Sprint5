using Tyuiu.ZaitsSD.Sprint5.Task7.V3.Lib;
namespace Tyuiu.ZaitsSD.Sprint5.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckFile()
        {
            string path = Path.GetTempFileName();
            try
            {
                File.WriteAllText(path, "Ёж abc!\nЯ+ё");
                string res = ds.LoadDataAndSave(path);
                Assert.AreEqual(" abc!\n+", File.ReadAllText(res));
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
