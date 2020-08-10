using Mtdata;
using NUnit.Framework;

namespace External
{
    public class MtDataTest
    {
        [SetUp]
        public void Setup()
        {
            string unitData = System.IO.File.ReadAllText("../../../Resources/MtUnit.txt");
            UnitDB.Init(unitData);
        }

        [Test]
        [Ignore("Update to version 1.0.2")]
        public void Test1()
        {
            var unit = UnitDB.Instance["[Character]akizuki_ritsukoA"];
            TestContext.WriteLine(unit.Name);
        }
    }
}