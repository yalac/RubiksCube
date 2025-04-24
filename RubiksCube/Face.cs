using RubiksCube;

public class Face
{
    public Tuile[,] Tuiles { get; set; }
    public int HauteurTuile { get; set; }
    public int LargeurTuile { get; set; }

    public Face(string color, int largeurTuile, int hauteurTuile)
    {
        Tuiles = new Tuile[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Tuiles[i, j] = new Tuile(color, largeurTuile, hauteurTuile, (3 * j) + i + 1);
                }
            }
        
        LargeurTuile = largeurTuile;
        HauteurTuile = hauteurTuile;
    }

    public void Display(int x, int y)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Tuiles[i, j].Display(x + (i * LargeurTuile), y + (j * HauteurTuile));
            }
        }
    }

    public void RotateHoraire()
    {
        //coin
        (Tuiles[0, 0], Tuiles[0, 2], Tuiles[2, 2], Tuiles[2, 0]) 
            = (Tuiles[0, 2], Tuiles[2, 2], Tuiles[2, 0], Tuiles[0, 0]);
        
        //arêtes
        (Tuiles[0, 1], Tuiles[1, 2], Tuiles[2, 1], Tuiles[1, 0]) 
            = (Tuiles[1, 2], Tuiles[2, 1], Tuiles[1, 0], Tuiles[0, 1]);
        
        /*
        Tuile Tump = Tuiles[0, 0];
        Tuiles[0, 0] = Tuiles[0, 2];
        Tuiles[0, 2] = Tuiles[2, 2];
        Tuiles[2, 2] = Tuiles[2, 0];
        Tuiles[2, 0] = Tump;
        
        Tump = Tuiles[0, 1];
        Tuiles[0, 1] = Tuiles[1, 2];
        Tuiles[1, 2] = Tuiles[2, 1];
        Tuiles[2, 1] = Tuiles[1, 0];
        Tuiles[1, 0] = Tump;
        */
    }
}
