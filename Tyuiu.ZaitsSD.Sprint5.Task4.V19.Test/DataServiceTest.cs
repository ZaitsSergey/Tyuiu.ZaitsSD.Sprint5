
using Tyuiu.ZaitsSD.Sprint5.Task4.V19.Lib;
namespace Tyuiu.ZaitsSD.Sprint5.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckFile()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V19.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);
        }
        [TestMethod]
        public void CheckNum()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V19.txt");
            double res_wait = 2.67;
            double res = double.Parse(File.ReadAllText(path).Trim(), System.Globalization.CultureInfo.InvariantCulture);
            Assert.AreEqual(res, res_wait);
        }
    }
}
