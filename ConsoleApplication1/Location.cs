using System;
using Microsoft.SqlServer.Server;

namespace ConsoleApplication1
{
    [Serializable]
    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Location(int x, int y)
        {
            this.X = x;
            this.Y = y;
            
        }

        public Location()
        {
            
        }

        public double GetValue()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public static bool operator ==(Location left, Location right)
        {
            return left.X == right.X && left.Y == right.Y;
        }

        public static bool operator !=(Location left, Location right)
        {
            return !(left == right);
        }

        public static Location operator +(Location left, Location right)
        {
            return new Location(left.X+right.Y,left.Y+right.Y);
        }
        
        public static implicit operator double (Location l)
        {
            return Math.Sqrt(l.X*l.X+l.Y*l.Y);
        }

        public override string ToString()
        {
            return "X="+X+",Y="+Y;
        }
    }
}