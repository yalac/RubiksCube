namespace RubiksCube;

public class Tuile
{
    public string Couleur { get; set; }
    public ConsoleColor ConsoleColor { get; set; }
    public int HauteurTuile { get; set; }
    public int LargeurTuile { get; set; }
    
    public int Numero { get; set; }

    public Tuile(string couleur, int largeurTuile, int hauteurTuile, int numero)
    {
        Couleur = couleur;
        ConsoleColor = GetColor(couleur);
        HauteurTuile = hauteurTuile;
        LargeurTuile = largeurTuile;
        Numero = numero;
    }

    public void Display(int x, int y)
    {
        Console.BackgroundColor = ConsoleColor;

        for (int k = 0; k < HauteurTuile; k++)
        {
            Console.SetCursorPosition(x, y + k);
            Console.Write(new string(' ', LargeurTuile));
        }
        Console.SetCursorPosition(x + (LargeurTuile/2), y + (HauteurTuile/2)); // numéroter les lignes
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write(Numero);
    }
    public ConsoleColor GetColor(string codeCouleur)
    {
        return codeCouleur switch
        {
            "W" => ConsoleColor.White,
            "R" => ConsoleColor.Red,
            "Y" => ConsoleColor.Yellow,
            "G" => ConsoleColor.Green,
            "B" => ConsoleColor.Blue,
            "O" => ConsoleColor.DarkMagenta,
            _ => ConsoleColor.Black,
        };
    }
}