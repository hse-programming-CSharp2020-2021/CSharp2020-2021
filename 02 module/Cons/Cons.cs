using System;

//C# -> IL -> ML
//JIT

//a, b
//comp(a, b) -> {-1, 0, 1}
//-1 - a < bф
//0 - a == b
//1 - a > b

class A {}

class B {
  A a;
  public B() {
    a = new A();
  }
}

class D : A {}

abstract class C {
  A a;
  public C(A a) {
    this.a = a;
  }
}

class Point {
 readonly Random random = new Random();
  readonly int xx;
  static Point() {

  }

  public Point(int x, int y) {
    this.x = x;
    this.y = y;

    random = new Random();
    random = new Random();
    xx = int.Parse(Console.ReadLine());
  }

  void Kek() {
  }

  public int x, y;
  // public int X {get {return x;} set {x = value;}}

  public int X {private get; set;}
}

class CoolPoint : Point {
  public int x;

  public CoolPoint(int x, int y) : base(x, y) {
    this.x = x + 1;
  }
}

class MainClass {
  public static int comp(int a, int b) {
    if (a == b)
      return 0;

    if (a < b)
      return -1;

    return 1;
  }

  public static void Main (string[] args) {
    var arr = new[] {new Point(1, 5), new Point(6, 4), new Point(5, 4)};

    // Array.Sort(arr, comp);

    Array.Sort(arr, (a,b) => {
      var comp1 = a.y.CompareTo(b.y);
      return (comp1 == 0)
        ? a.x.CompareTo(b.x) 
        : (comp1);
    });

    Point point = new CoolPoint(1, 2);
    Console.WriteLine(point.x);

    foreach (var a in arr)
      Console.WriteLine(a.x + " " + a.y);
    
    
    // int kek;
    // Console.WriteLine(kek);
  }
}
