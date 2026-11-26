

using Tyuiu.ZaitsSD.Sprint5.Task6.V22.Lib;
namespace Tyuiu.ZaitsSD.Sprint5.Task6.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckFile()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V22.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);
        }
        [TestMethod]
        public void Check_Num()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V22.txt");
            int res = ds.LoadFromDataFile(path);
            int wait_res = 2;
            Assert.AreEqual(res, wait_res);
        }
    }
}