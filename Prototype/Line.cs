using System;

  namespace Coding.Exercise
  {
    public class Point
    {
      public int X, Y;

      public Point() {}

      public Point(Point other)
      {
        X = other.X;
        Y = other.Y;
      }
    }

    public class Line
    {
      public Point Start, End;

      public Line() {}

      public Line(Line other) {
        Start = new Point(other.Start);
        End = new Point(other.End);
      }

      public Line DeepCopy()
      {
        return new Line(this);
      }

      public override string ToString()
      {
        return $"Point.Start: ({Start.X},{Start.Y}) Point.End: ({End.X},{End.Y})";
      }
    }

    public class Exercise
    {
      static void Main(string[] args)
      {
        var p1 = new Line() { Start = new Point() { X = 0, Y = 0}, End = new Point() { X = 5, Y = 5}};
        var p2 = p1.DeepCopy();
        p2.Start.X = 1;
        p2.Start.Y = 1;
        p1.End.X = 3;
        p1.End.Y = 3;
        Console.WriteLine(p1);
        Console.WriteLine(p2);
      }
    }
  }
