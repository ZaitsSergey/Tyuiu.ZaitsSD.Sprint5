
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
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V3.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);
        }
    }
}
