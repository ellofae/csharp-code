using System;

class Program
{
    public struct Coord
    {
        public int x;
        public int y;

        public Coord(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void CoordsSummery(Coord c1, Coord c2, Coord c3)
        {
            this.x = c1.x + c2.x + c3.x;
            this.y = c1.y + c2.y + c3.y;
        }

        public readonly void Display()
        {
            Console.WriteLine($"Point: ({this.x}, {this.y})");
        }
    }

    public static void Main()
    {
        Coord point_1 = new Coord(1, 3);
        Coord point_2 = new Coord(5, 8);
        Coord point_3 = new Coord(3, -4);
        Coord finalPoint = new Coord();

        finalPoint.CoordsSummery(point_1, point_2, point_3);

        finalPoint.Display();
    }
}
