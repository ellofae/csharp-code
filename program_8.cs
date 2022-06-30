using System;

class Program
{
    public struct Distance
    {
        public int feet;
        public float inches;

        public Distance(int feet, float inches)
        {
            this.feet = feet;
            this.inches = inches;
        }
    }

    public static void Main()
    {
        Distance RoomWidth = new Distance(16, Convert.ToSingle(3.5));
        Distance RoomHeight = new Distance(12, Convert.ToSingle(6.25));
        Distance RoomLength = new Distance(8, Convert.ToSingle(12.0));

        double w, h, l;
        w = RoomWidth.feet + RoomWidth.inches / 12.0;
        h = RoomHeight.feet + RoomHeight.inches / 12.0;
        l = RoomLength.feet + RoomLength.inches / 12.0;

        Console.WriteLine($"Volume: {Convert.ToSingle(w * h * l)}");

    }
}
