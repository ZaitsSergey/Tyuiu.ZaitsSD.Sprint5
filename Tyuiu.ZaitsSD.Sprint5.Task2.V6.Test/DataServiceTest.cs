using Tyuiu.ZaitsSD.Sprint5.Task2.V6.Lib;
namespace Tyuiu.ZaitsSD.Sprint5.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckFile()
        {
            int[,] matrix = { { -2, 1, 8 }, { -4, -7, 8 }, { 6, 5, 5 } };
            string path = ds.SaveToFileTextData(matrix);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);
            string[] wait_res = { "0;1;1", "0;0;1", "1;1;1" };
            CollectionAssert.AreEqual(wait_res, File.ReadAllLines(path));
        }
    }
}
