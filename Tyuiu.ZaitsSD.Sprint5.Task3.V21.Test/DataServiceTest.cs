using Tyuiu.ZaitsSD.Sprint5.Task3.V21.Lib;
namespace Tyuiu.ZaitsSD.Sprint5.Task3.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckFile()
        {
            int x = 3;
            string path = ds.SaveToFileTextData(x);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);
            using (BinaryReader reader = new BinaryReader(File.OpenRead(path)))
            {
                Assert.AreEqual(1.741, reader.ReadDouble());
            }
        }
    }
}
