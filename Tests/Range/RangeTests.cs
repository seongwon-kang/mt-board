using NUnit.Framework;
using MtBoard;
using System.Collections.Generic;

namespace Tests
{
    public class RangeTests
    {
        private MtBoard.Board board;

        [SetUp]
        public void Setup()
        {
            board = new MtBoard.Board();
            IUnit unit1 = new Unit();
            
            unit1.X = 1;
            unit1.Y = 0;
            board.Units.Add(unit1);

            IUnit unit2 = new Unit();
            unit2.X = 0;
            unit2.Y = 1;
            board.Units.Add(unit2);
        }

        [Test]
        public void Test1()
        {
            List<IUnit> targets = LinearRange.GetUnitOn(board, 0, 0, 2, Direction.UP);

            Assert.AreEqual(1, targets.Count);
        }
    }
}