using System;
using System.Collections.Generic;

namespace Snake
{
    public class Direction
    {
        public readonly static Direction Left = new Direction(0, -1);
        public readonly static Direction Right = new Direction(0, 1);
        public readonly static Direction Up = new Direction(-1, 0);
        public readonly static Direction Down = new Direction(1, 0);


        public int RowOffset { get; }
        public int ColOffsett { get; }

        private Direction(int rowOffset, int colOffsett)
        {
            RowOffset = rowOffset;
            ColOffsett = colOffsett;
        } 
        public Direction Opposite()
        { return new Direction(-RowOffset, -ColOffsett); }

        public override bool Equals(object obj)
        {
            return obj is Direction direction &&
                   RowOffset == direction.RowOffset &&
                   ColOffsett == direction.ColOffsett;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(RowOffset, ColOffsett);
        }

        public static bool operator ==(Direction left, Direction right)
        {
            return EqualityComparer<Direction>.Default.Equals(left, right);
        }

        public static bool operator !=(Direction left, Direction right)
        {
            return !(left == right);
        }
    }
}
