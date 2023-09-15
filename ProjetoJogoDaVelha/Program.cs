
Console.WriteLine("       ____   ___    ____   ___       ___     ____      __ __    ___  _      __ __   ____ ");
Console.WriteLine("      |    | /   \\  /    | /   \\     |   \\   /    |    |  |  |  /  _]| |    |  |  | /    |");
Console.WriteLine("      |__  ||     ||   __||     |    |    \\ |  o  |    |  |  | /  [_ | |    |  |  ||  o  |");
Console.WriteLine("      __|  ||  O  ||  |  ||  O  |    |  D  ||     |    |  |  ||    _]| |___ |  _  ||     |");
Console.WriteLine("     /  |  ||     ||  |_ ||     |    |     ||  _  |    |  :  ||   [_ |     ||  |  ||  _  |");
Console.WriteLine("     \\  `  ||     ||     ||     |    |     ||  |  |     \\   / |     ||     ||  |  ||  |  |");
Console.WriteLine("      \\____j \\___/ |___,_| \\___/     |_____||__|__|      \\_/  |_____||_____||__|__||__|__|");
Console.WriteLine("\n\n                                         ##         ##");
Console.WriteLine("                                         ##         ##");
Console.WriteLine("                                         ##         ##");
Console.WriteLine("                                  ###########################");
Console.WriteLine("                                         ##         ##");
Console.WriteLine("                                         ##         ##");
Console.WriteLine("                                         ##         ##");
Console.WriteLine("                                  ###########################");
Console.WriteLine("                                         ##         ##");
Console.WriteLine("                                         ##         ##");
Console.WriteLine("                                         ##         ##");

Console.Write("\nAperte Enter para iniciar ");
Console.ReadKey();
Console.Clear();

Console.Write(" Nome do jogador 1: ");
string jogardor1 = Console.ReadLine();
Console.Write(" Nome do jogador 2: ");
string jogardor2 = Console.ReadLine();

string sorteio;
int numeroAleatorio;

do
{
    Console.WriteLine("Deseja sortear quem deve começar? 'S' Sim / 'N' Não");
    sorteio = Console.ReadLine();
    Console.WriteLine();
}
while (!string.Equals(sorteio, "S", StringComparison.OrdinalIgnoreCase) && !string.Equals(sorteio, "N", StringComparison.OrdinalIgnoreCase));


if (string.Equals(sorteio, "S", StringComparison.OrdinalIgnoreCase))
{
    Random randNum = new Random();
    numeroAleatorio = randNum.Next(1, 3);

    if (numeroAleatorio == 1)
    {
        Console.WriteLine($"Jogador(a) {jogardor1} você começa a primeira jogada");
    }
    else
    {
        Console.WriteLine($"Jogador(a) {jogardor2} você começa a primeira jogada");
    }
}

else if (string.Equals(sorteio, "N", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine($"Jogador(a) {jogardor1} você começa a primeira jogada");
    numeroAleatorio = 1;
}


string[,] matriz = new string[3, 3] { 
    { "1", "2", "3" }, 
    { "4", "5", "6" }, 
    { "7", "8", "9" } };

bool vezDoJogador1 = true;
string posicao = "0";

for (int iteracao = 0; iteracao < 9; iteracao++)
{
    bool jogadaInvalida = false;
    ExibirTabuleiro(matriz);

    if (!jogadaInvalida)
    {        
        if (vezDoJogador1)
        {
            Console.WriteLine($"\n-> {jogardor1} Digite o número da posição conforme os números acima: ");
            posicao = Console.ReadLine();
            Console.Clear();

            bool numeroEncontrado = false;
            numeroEncontrado = ProcuraNumeroDigitado(matriz, posicao, numeroEncontrado);

            if (!numeroEncontrado)
            {

                while (!numeroEncontrado)
                {
                    Console.Clear();
                    ExibirTabuleiro(matriz);
                    jogadaInvalida = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("***** Posição escolhida não existe ou já foi escolhida! *****");
                    Console.ResetColor();

                    Console.WriteLine($"\n-> {jogardor1} Digite o número da posição conforme os números acima: ");
                    posicao = Console.ReadLine();

                    Console.Clear();
                    numeroEncontrado = ProcuraNumeroDigitado(matriz, posicao, numeroEncontrado);
                }
            }
        }
        else
        {
            Console.WriteLine($"\n-> {jogardor2} Digite o número da posição conforme os números acima: ");
            posicao = Console.ReadLine();
            Console.Clear();


            bool numeroEncontrado = false;
            numeroEncontrado = ProcuraNumeroDigitado(matriz, posicao, numeroEncontrado);

            if (!numeroEncontrado)
            {

                while (!numeroEncontrado)
                {
                    Console.Clear();
                    ExibirTabuleiro(matriz);
                    jogadaInvalida = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("***** Posição escolhida não existe ou já foi escolhida! *****");
                    Console.ResetColor();

                    Console.WriteLine($"\n-> {jogardor2} Digite o número da posição conforme os números acima: ");
                    posicao = Console.ReadLine();

                    Console.Clear();
                    numeroEncontrado = ProcuraNumeroDigitado(matriz, posicao, numeroEncontrado);
                }
            }
        }
    }

    vezDoJogador1 = PreencherTabuleiro(matriz, posicao, vezDoJogador1);


    bool fimJogo = false;
    if (!fimJogo)
    {
        //Verificação de vitória horizontal
        for (int linha = 0; linha < 3; linha++)
        {
            int coluna0 = 0;
            int coluna1 = 1;
            int coluna2 = 2;

            bool vencedorHorizontalLetraX = (matriz[linha, coluna0] == "X" && matriz[linha, coluna1] == "X" && matriz[linha, coluna2] == "X");
            bool vencedorHorizontalLextraO = (matriz[linha, coluna0] == "O" && matriz[linha, coluna1] == "O" && matriz[linha, coluna2] == "O");

            if (vencedorHorizontalLetraX || vencedorHorizontalLextraO)
            {
                if (vencedorHorizontalLetraX)
                {
                    Console.WriteLine($"Fim do jogo o vencedor é {jogardor1}\n");
                    fimJogo = true;
                }
                else if (vencedorHorizontalLextraO)
                {
                    Console.WriteLine($"Fim do jogo o vencedor é {jogardor2}\n");
                    fimJogo = true;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                ExibirTabuleiro(matriz);
                Console.ResetColor();
            }
        }

        //Verificação de vitória vertical
        for (int coluna = 0; coluna < 3; coluna++)
        {            
            int linha0 = 0;
            int linha1 = 1;
            int linha2 = 2;

            bool vencedorVerticalLetraX = (matriz[linha0, coluna] == "X" && matriz[linha1, coluna] == "X" && matriz[linha2, coluna] == "X");
            bool vencedorVerticalLextraO = (matriz[linha0, coluna] == "O" && matriz[linha1, coluna] == "O" && matriz[linha2, coluna] == "O");

            if (vencedorVerticalLetraX || vencedorVerticalLextraO)
            {
                if (vencedorVerticalLetraX)
                {
                    Console.WriteLine($"Fim do jogo o vencedor é {jogardor1}\n");
                    fimJogo = true;
                }
                else if (vencedorVerticalLextraO)
                {
                    Console.WriteLine($"Fim do jogo o vencedor é {jogardor2}\n");
                    fimJogo = true;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                ExibirTabuleiro(matriz);
                Console.ResetColor();
            }
        }
        
        //Verificação de vitória diagonais
        bool vencedorDiagonal = ((matriz[0, 0] == "X" && matriz[1, 1] == "X" && matriz[2, 2] == "X") || (matriz[0, 0] == "O" && matriz[0, 0] == "O" && matriz[0, 0] == "O"));
        if (vencedorDiagonal)
        {
            if (vencedorDiagonal == (matriz[0, 0] == "X" && matriz[1, 1] == "X" && matriz[2, 2] == "X"))
            {
                Console.WriteLine($"Fim do jogo o vencedor é {jogardor1}\n");
                fimJogo = true;
            }
            else if (vencedorDiagonal == (matriz[0, 0] == "O" && matriz[1, 1] == "O" && matriz[2, 2] == "O"))
            {
                Console.WriteLine($"Fim do jogo o vencedor é {jogardor2}\n");
                fimJogo = true;
            }
        }

        bool vencedorDiagonal2 = ((matriz[0, 2] == "X" && matriz[1, 1] == "X" && matriz[2, 0] == "X") || (matriz[0, 2] == "O" && matriz[1, 1] == "O" && matriz[2, 0] == "O"));
        if (vencedorDiagonal2)
        {
            if (vencedorDiagonal2 == (matriz[0, 2] == "X" && matriz[1, 1] == "X" && matriz[2, 0] == "X"))
            {
                Console.WriteLine($"Fim do jogo o vencedor é {jogardor1}\n");
                fimJogo = true;
            }
            else if (vencedorDiagonal2 == (matriz[0, 2] == "O" && matriz[1, 1] == "O" && matriz[2, 0] == "O"))
            {
                Console.WriteLine($"Fim do jogo o vencedor é {jogardor2}\n");
                fimJogo = true;
            }
        }
     

    }

    if (iteracao == 8)
    {
        Console.WriteLine("Deu empate!");
        Console.ForegroundColor = ConsoleColor.Red;
        ExibirTabuleiro(matriz);
        Console.ResetColor();
    }
    else if (fimJogo == true)
       break;
   
}



static void ExibirTabuleiro(string[,] array)
{
    string p1 = array[0, 0];
    string p2 = array[0, 1];
    string p3 = array[0, 2];
    string p4 = array[1, 0];
    string p5 = array[1, 1];
    string p6 = array[1, 2];
    string p7 = array[2, 0];
    string p8 = array[2, 1];
    string p9 = array[2, 2];

    Console.WriteLine("                |     |     ");
    Console.WriteLine($"              {p1} |  {p2}  |  {p3}  ");
    Console.WriteLine("                |     |     ");
    Console.WriteLine("            ----------------");
    Console.WriteLine("                |     |     ");
    Console.WriteLine($"              {p4} |  {p5}  |  {p6}  ");
    Console.WriteLine("                |     |     ");
    Console.WriteLine("            ----------------");
    Console.WriteLine("                |     |     ");
    Console.WriteLine($"              {p7} |  {p8}  |  {p9}  ");
    Console.WriteLine("                |     |     ");
}

static bool PreencherTabuleiro(string[,] array, string posicao, bool vezDoJogador1)
{
    if (int.Parse(posicao) == 1)
    {
        if (vezDoJogador1)
        {
            array[0, 0] = "X";
            vezDoJogador1 = false;
        }
        else
        {
            array[0, 0] = "O";
            vezDoJogador1 = true;
        }
    }
    else if (int.Parse(posicao) == 2)
    {
        if (vezDoJogador1)
        {
            array[0, 1] = "X";
            vezDoJogador1 = false;
        }
        else
        {
            array[0, 1] = "O";
            vezDoJogador1 = true;
        }
    }
    else if (int.Parse(posicao) == 3)
    {
        if (vezDoJogador1)
        {
            array[0, 2] = "X";
            vezDoJogador1 = false;
        }
        else
        {
            array[0, 2] = "O";
            vezDoJogador1 = true;
        }

    }
    else if (int.Parse(posicao) == 4)
    {
        if (vezDoJogador1)
        {
            array[1, 0] = "X";
            vezDoJogador1 = false;
        }
        else
        {
            array[1, 0] = "O";
            vezDoJogador1 = true;
        }
    }
    else if (int.Parse(posicao) == 5)
    {
        if (vezDoJogador1)
        {
            array[1, 1] = "X";
            vezDoJogador1 = false;
        }
        else
        {
            array[1, 1] = "O";
            vezDoJogador1 = true;
        }
    }
    else if (int.Parse(posicao) == 6)
    {
        if (vezDoJogador1)
        {
            array[1, 2] = "X";
            vezDoJogador1 = false;
        }
        else
        {
            array[1, 2] = "O";
            vezDoJogador1 = true;
        }
    }
    else if (int.Parse(posicao) == 7)
    {
        if (vezDoJogador1)
        {
            array[2, 0] = "X";
            vezDoJogador1 = false;
        }
        else
        {
            array[2, 0] = "O";
            vezDoJogador1 = true;
        }
    }
    else if (int.Parse(posicao) == 8)
    {
        if (vezDoJogador1)
        {
            array[2, 1] = "X";
            vezDoJogador1 = false;
        }
        else
        {
            array[2, 1] = "O";
            vezDoJogador1 = true;
        }
    }
    else if (int.Parse(posicao) == 9)
    {
        if (vezDoJogador1)
        {
            array[2, 2] = "X";
            vezDoJogador1 = false;
        }
        else
        {
            array[2, 2] = "O";
            vezDoJogador1 = true;
        }

    }

    return vezDoJogador1;
}

static bool ProcuraNumeroDigitado(string[,] array, string posicao, bool numeroEncontrado)
{
    foreach (var item in array)
    {
        if (item == posicao)
        {
            numeroEncontrado = true;
            break;
        }
    }

    return numeroEncontrado;
}


