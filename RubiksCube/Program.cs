class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Rubik's Cube :)");
        Console.WriteLine("F : face, B : back, R : right, L : left, D : down, U : up, P : random, Escape : quitter");

        Cube cube = new Cube(5, 3);
        cube.Display();

        var keyInfo = Console.ReadKey();
        while (keyInfo.Key != ConsoleKey.Escape)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.F:
                    Thread.Sleep(500);
                    if (keyInfo.Modifiers.HasFlag(ConsoleModifiers.Shift))
                        cube.Fp();
                    else
                        cube.F();
                    break;
                    
                case ConsoleKey.B:
                    Thread.Sleep(500);
                    if (keyInfo.Modifiers.HasFlag(ConsoleModifiers.Shift))
                        cube.Bp();
                    else
                        cube.B();
                    break;
                
                case ConsoleKey.R:
                    Thread.Sleep(500);
                    if (keyInfo.Modifiers.HasFlag(ConsoleModifiers.Shift))
                        cube.Rp();
                    else
                        cube.R();
                    break;
                
                case ConsoleKey.L:
                    Thread.Sleep(500);
                    if (keyInfo.Modifiers.HasFlag(ConsoleModifiers.Shift))
                        cube.Lp();
                    else
                        cube.L();
                    break;
                
                case ConsoleKey.D:
                    Thread.Sleep(500);
                    if (keyInfo.Modifiers.HasFlag(ConsoleModifiers.Shift))
                        cube.Dp();
                    else
                        cube.D();
                    break;
                
                case ConsoleKey.U:
                    Thread.Sleep(500);
                    if (keyInfo.Modifiers.HasFlag(ConsoleModifiers.Shift))
                        cube.Up();
                    else
                        cube.U();
                    break;
                
                case ConsoleKey.N:
                    Thread.Sleep(500);
                    cube.AfficherFace();
                    break;
                
                case ConsoleKey.P:
                    Thread.Sleep(500);
                    if (keyInfo.Modifiers.HasFlag(ConsoleModifiers.Shift))
                        cube.UnShuffle();
                    else
                        cube.Shuffle();
                    break;
            }
            
            cube.Display();
            keyInfo = Console.ReadKey();
        }

        Console.ReadKey();
    }
}
