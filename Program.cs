namespace Jogo;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Pedra, Papel e Tesoura ===");
        Console.WriteLine("");

        Console.WriteLine("Escolha: pedra, papel ou tesoura");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Erro: entrada inválida");
            return;
        }

        string escolha_player1 = input.Trim().ToLower();

        Console.WriteLine("");

        if(escolha_player1 == "papel" || escolha_player1 == "pedra" || escolha_player1 == "tesoura")
        {
            string escolha_player2 = Player2.Random_Choice();

            Console.WriteLine($"Você escolheu: {escolha_player1}");
            Console.WriteLine($"Seu oponente escolheu: {escolha_player2}");

            if (
                (escolha_player1 == "pedra" && escolha_player2 == "tesoura") ||
                (escolha_player1 == "papel" && escolha_player2 == "pedra") ||
                (escolha_player1 == "tesoura" && escolha_player2 == "papel")
            )
            {
                Console.WriteLine("Resultado: Você venceu");
            }
            
            else if (escolha_player1 == escolha_player2)
            {
                Console.WriteLine("Resultado: Empate");
            }

            else
            {
                Console.WriteLine("Resultado: Você foi derrotado");
            }
        }
        else
        {
            Console.WriteLine("Erro: Resposta não esperada e inválida para o proseguimento do jogo");
            return;
        }
    }
}