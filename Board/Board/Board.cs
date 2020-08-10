using System.Collections.Generic;

namespace MtBoard {
    public class Board : IBoard
    {
        private List<IUnit> units = new List<IUnit>();

        public List<IUnit> Units { get => units; set => units = value; }
    }

}