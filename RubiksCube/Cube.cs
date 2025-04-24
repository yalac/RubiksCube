public class Cube
{
    public Face Top { get; set; }
    public Face Front { get; set; }
    public Face Bottom { get; set; }
    public Face Left { get; set; }
    public Face Right { get; set; }
    public Face Back { get; set; }

    public int HauteurTuile { get; set; }
    public int LargeurTuile { get; set; }
    public List<string> Mouvement { get; set; }

    public Cube(int largeurTuile, int hauteurTuile)
    {
        LargeurTuile = largeurTuile;
        HauteurTuile = hauteurTuile;
        AfficherFace();
    }

    public void AfficherFace()
    {
        Top = new Face("W", LargeurTuile, HauteurTuile);
        Front = new Face("R", LargeurTuile, HauteurTuile);
        Bottom = new Face("Y", LargeurTuile, HauteurTuile);
        Left = new Face("G", LargeurTuile, HauteurTuile);
        Right = new Face("B", LargeurTuile, HauteurTuile);
        Back = new Face("O", LargeurTuile, HauteurTuile);
    }

    public void Display()
    {
        Top.Display(3 * LargeurTuile, 2);
        Left.Display(0, 3 * HauteurTuile + 2);
        Front.Display(3 * LargeurTuile, 3 * HauteurTuile + 2);
        Right.Display(6 * LargeurTuile, 3 * HauteurTuile + 2); 
        Back.Display(9 * LargeurTuile, 3 * HauteurTuile + 2);
        Bottom.Display(3 * LargeurTuile, 6 * HauteurTuile + 2);
        Thread.Sleep(50);
    }

    public void F()
    {
        Front.RotateHoraire();
         (Right.Tuiles[0, 2], Bottom.Tuiles[0, 0], Left.Tuiles[2, 0], Top.Tuiles[2, 2])
             = (Top.Tuiles[2, 2], Right.Tuiles[0, 2], Bottom.Tuiles[0, 0], Left.Tuiles[2, 0]);
         (Right.Tuiles[0, 1], Bottom.Tuiles[1, 0], Left.Tuiles[2, 1], Top.Tuiles[1, 2])
             = (Top.Tuiles[1, 2], Right.Tuiles[0, 1], Bottom.Tuiles[1, 0], Left.Tuiles[2, 1]);
         (Right.Tuiles[0, 0], Bottom.Tuiles[2, 0], Left.Tuiles[2, 2], Top.Tuiles[0, 2])
             = (Top.Tuiles[0, 2], Right.Tuiles[0, 0], Bottom.Tuiles[2, 0], Left.Tuiles[2, 2]);
    }

    public void Fp()
    {
        F();
        F();
        F();
    }

    public void B()
    {
        Back.RotateHoraire();
        (Top.Tuiles[2, 0], Right.Tuiles[2, 2], Bottom.Tuiles[0, 2], Left.Tuiles[0, 0])
            = (Right.Tuiles[2, 2], Bottom.Tuiles[0, 2], Left.Tuiles[0, 0], Top.Tuiles[2, 0]);
        (Top.Tuiles[1, 0], Right.Tuiles[2, 1], Bottom.Tuiles[1, 2], Left.Tuiles[0, 1])
            = (Right.Tuiles[2, 1], Bottom.Tuiles[1, 2], Left.Tuiles[0, 1], Top.Tuiles[1, 0]);
        (Top.Tuiles[0, 0], Right.Tuiles[2, 0], Bottom.Tuiles[2, 2], Left.Tuiles[0, 2])
            = (Right.Tuiles[2, 0], Bottom.Tuiles[2, 2], Left.Tuiles[0, 2], Top.Tuiles[0, 0]);
    }

    public void Bp()
    {
        B();
        B();
        B();
    }
    
    public void R()
    {
        Right.RotateHoraire();
        (Top.Tuiles[2, 2], Back.Tuiles[0, 0], Bottom.Tuiles[2, 2], Front.Tuiles[2, 2])
            = (Front.Tuiles[2, 2], Top.Tuiles[2, 2], Back.Tuiles[0, 0], Bottom.Tuiles[2, 2]);
        (Top.Tuiles[2, 1], Back.Tuiles[0, 1], Bottom.Tuiles[2, 1], Front.Tuiles[2, 1])
            = (Front.Tuiles[2, 1], Top.Tuiles[2, 1], Back.Tuiles[0, 1], Bottom.Tuiles[2, 1]);
        (Top.Tuiles[2, 0], Back.Tuiles[0, 2], Bottom.Tuiles[2, 0], Front.Tuiles[2, 0])
            = (Front.Tuiles[2, 0], Top.Tuiles[2, 0], Back.Tuiles[0, 2], Bottom.Tuiles[2, 0]);

    }
    
    public void Rp()
    {
        R();
        R();
        R();
    }
    
    public void L()
    {
        Left.RotateHoraire();
        (Bottom.Tuiles[0, 2], Back.Tuiles[2, 0], Top.Tuiles[0, 2], Front.Tuiles[0, 2])
            = (Front.Tuiles[0, 2], Bottom.Tuiles[0, 2], Back.Tuiles[2, 0], Top.Tuiles[0, 2]);
        (Bottom.Tuiles[0, 1], Back.Tuiles[2, 1], Top.Tuiles[0, 1], Front.Tuiles[0, 1])
            = (Front.Tuiles[0, 1], Bottom.Tuiles[0, 1], Back.Tuiles[2, 1], Top.Tuiles[0, 1]);
        (Bottom.Tuiles[0, 0], Back.Tuiles[2, 2], Top.Tuiles[0, 0], Front.Tuiles[0, 0])
            = (Front.Tuiles[0, 0], Bottom.Tuiles[0, 0], Back.Tuiles[2, 2], Top.Tuiles[0, 0]);

    }
    
    public void Lp()
    {
        L();
        L();
        L();
    }
    
    public void D()
    {
        Bottom.RotateHoraire();
        (Right.Tuiles[0, 2], Back.Tuiles[0, 2], Left.Tuiles[0, 2], Front.Tuiles[0, 2])
            = (Front.Tuiles[0, 2], Right.Tuiles[0, 2], Back.Tuiles[0, 2], Left.Tuiles[0, 2]);
        (Right.Tuiles[1, 2], Back.Tuiles[1, 2], Left.Tuiles[1, 2], Front.Tuiles[1, 2])
            = (Front.Tuiles[1, 2], Right.Tuiles[1, 2], Back.Tuiles[1, 2], Left.Tuiles[1, 2]);
        (Right.Tuiles[2, 2], Back.Tuiles[2, 2], Left.Tuiles[2, 2], Front.Tuiles[2, 2])
            = (Front.Tuiles[2, 2], Right.Tuiles[2, 2], Back.Tuiles[2, 2], Left.Tuiles[2, 2]);

    }
    
    public void Dp()
    {
        D();
        D();
        D();
    }
    
    public void U()
    {
        Top.RotateHoraire();
        (Left.Tuiles[2, 0], Back.Tuiles[2, 0], Right.Tuiles[2, 0], Front.Tuiles[2, 0])
            = (Front.Tuiles[2, 0], Left.Tuiles[2, 0], Back.Tuiles[2, 0], Right.Tuiles[2, 0]);
        (Left.Tuiles[1, 0], Back.Tuiles[1, 0], Right.Tuiles[1, 0], Front.Tuiles[1, 0])
            = (Front.Tuiles[1, 0], Left.Tuiles[1, 0], Back.Tuiles[1, 0], Right.Tuiles[1, 0]);
        (Left.Tuiles[0, 0], Back.Tuiles[0, 0], Right.Tuiles[0, 0], Front.Tuiles[0, 0])
            = (Front.Tuiles[0, 0], Left.Tuiles[0, 0], Back.Tuiles[0, 0], Right.Tuiles[0, 0]);
    }
    
    public void Up()
    {
        U();
        U();
        U();
    }
    
    public void Shuffle()
    {
        List<string> mouvement = ["F", "Fp", "B", "Bp", "R", "Rp", "L", "Lp", "U", "Up", "D", "Dp"];
        
        Random rnd = new();
        int aleatoire = rnd.Next(10, 20);
        Mouvement = new List<string>();

        for (int i = 0; i < aleatoire; i++)
        {
            string move = mouvement[rnd.Next(mouvement.Count)];
            Mouvement.Add(move);
            
            switch (move)
            {
                case "F":
                    F();
                    break;

                case "Fp":
                    Fp();
                    break;

                case "B":
                    B();
                    break;

                case "Bp":
                    Bp();
                    break;

                case "R":
                    R();
                    break;

                case "Rp":
                    Rp();
                    break;

                case "L":
                    L();
                    break;

                case "Lp":
                    Lp();
                    break;

                case "U":
                    U();
                    break;

                case "Up":
                    Up();
                    break;

                case "D":
                    D();
                    break;

                case "Dp":
                    Dp();
                    break;
            }
            Display();
        }
    }

    public void UnShuffle()
    {
        for (int i = Mouvement.Count - 1; i >= 0; i--)
        {
            string move = Mouvement[i];
            
            switch (move)
            {
                case "F":
                    Fp();
                    break;

                case "Fp":
                    F();
                    break;

                case "B":
                    Bp();
                    break;

                case "Bp":
                    B();
                    break;

                case "R":
                    Rp();
                    break;

                case "Rp":
                    R();
                    break;

                case "L":
                    Lp();
                    break;

                case "Lp":
                    L();
                    break;

                case "U":
                    Up();
                    break;

                case "Up":
                    U();
                    break;

                case "D":
                    Dp();
                    break;

                case "Dp":
                    D();
                    break;
            }
            Display();
        }
    }
}
