namespace Chess_Logic
{
    public class Direction
    {
        public readonly static Direction North = new Direction(-1, 0);    //North
        public readonly static Direction South = new Direction(1, 0);
        public readonly static Direction East = new Direction(0, 1);
        public readonly static Direction West = new Direction(0, -1);
        public readonly static Direction NorthEast = North + East;
        public readonly static Direction NorthWest = North + West;
        public readonly static Direction SouthEast = South + East;
        public readonly static Direction SouthWest = South + West;
        public int RowDelta { get; }                //CHange in row and column from a given position
        public int ColumnDelta { get; }
    
    public Direction(int rowDelta, int columnDelta)
        {
            RowDelta = rowDelta;
            ColumnDelta = columnDelta;

        }

        public static Direction operator +(Direction dir1, Direction dir2) {                            //Used for moving pieces that can move multiple squares in one turn. Overload operator 
            return new Direction(dir1.RowDelta + dir2.RowDelta, dir1.ColumnDelta + dir2.ColumnDelta);
        }
        public static Direction operator *(int scalar, Direction dir)
        {
            return new Direction(scalar * dir.RowDelta, scalar * dir.ColumnDelta);
        }
    }
}
