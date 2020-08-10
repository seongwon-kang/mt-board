using System;
using System.Collections.Generic;
using Mtdata;

namespace MtBoard
{
    public class LinearRange
    {

        static int[] directionX = { 0, 0, -1, 1 };
        static int[] directionY = { 1, -1, 0, 0 };

        public static List<IUnit> GetUnitOn(IBoard board, int x, int y, int range, Direction direction, bool containsSelf = true)
        {
            List<IUnit> targets = new List<IUnit>();
            MtSkill skill = new MtSkill();
            skill.
            foreach (IUnit item in board.Units)
            {
                if (!containsSelf && item.X == x && item.Y == y) continue;

                switch (direction)
                {
                    case Direction.UP:
                    case Direction.DOWN:
                        if (range > (Math.Abs(item.Y) - y) * directionY[(int)direction])
                        {
                            targets.Add(item);
                        }
                        break;

                    case Direction.LEFT:
                    case Direction.RIGHT:
                        if (range > (Math.Abs(item.X) - x) * directionX[(int)direction])
                        {
                            targets.Add(item);
                        }
                        break;
                }
            }

            return targets;
        }
    }

}