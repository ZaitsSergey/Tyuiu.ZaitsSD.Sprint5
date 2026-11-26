
using Tyuiu.ZaitsSD.Sprint5.Task1.V7.Lib;
namespace Tyuiu.ZaitsSD.Sprint5.Task1.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckFile()
        {
            string path = ds.SaveToFileTextData(1, 3);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);
        }
    }
}
