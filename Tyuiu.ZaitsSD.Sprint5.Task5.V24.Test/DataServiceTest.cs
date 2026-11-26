
using Tyuiu.ZaitsSD.Sprint5.Task5.V24.Lib;
namespace Tyuiu.ZaitsSD.Sprint5.Task5.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckFile()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V24.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);
        }
    }
}