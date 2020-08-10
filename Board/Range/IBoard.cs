using System.Collections.Generic;

public interface IBoard
{
    List<IUnit> Units { get; set; }
}