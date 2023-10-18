using Project_65030109;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestProjectMembersCount()
        {
            Assert.IsTrue(Enum.GetNames(typeof(Project.Members)).Length == 4);
        }
    }
}