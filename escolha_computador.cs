namespace Jogo;

public class Player2
{
    public static string Random_Choice()
    {
        Random random = new Random();
        int numero = random.Next(3);

        string computador = "";

        if (numero == 0)
        {
            computador = "pedra";
        }
        else if (numero == 1)
        {
            computador = "papel";
        }
        else if (numero == 2)
        {
            computador = "tesoura";
        }
        
        return computador;
    }
}