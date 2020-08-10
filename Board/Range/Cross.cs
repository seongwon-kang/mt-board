using System;
using System.Collections.Generic;

public class Cross {
    public static List<IUnit> GetUnitOn(IBoard board, int x, int y, int range) {
        List<IUnit> targets = new List<IUnit>();
        
        foreach(IUnit item in board.Units) {
            if (range > Math.Abs(item.X - x) + Math.Abs(item.Y - y)) {
                targets.Add(item);
            }
        }

        return targets;
    }
}