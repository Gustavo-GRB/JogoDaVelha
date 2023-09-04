using System.Numerics;
using System;

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
    Console.WriteLine("Deseja sortear quem deve começar? 'S' Sim / 'N' Não ");
    sorteio = Console.ReadLine();
}
while (!string.Equals(sorteio, "S", StringComparison.OrdinalIgnoreCase) && !string.Equals(sorteio, "N", StringComparison.OrdinalIgnoreCase));


if (string.Equals(sorteio, "S", StringComparison.OrdinalIgnoreCase))
{
    Random randNum = new Random();
    numeroAleatorio = randNum.Next(1, 3);

    if (numeroAleatorio == 1)
    {
        Console.WriteLine($"Jogador {jogardor1} você começa a primeira jogada");
    }
    else
    {
        Console.WriteLine($"Jogador {jogardor2} você começa a primeira jogada");
    }    
}

else if (string.Equals(sorteio, "N", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine($"Jogador {jogardor1} você começa a primeira jogada");
    numeroAleatorio = 1;
}


//se o numeroAleatorio == 1 jogardor1 comeca senão jogador2 comeca
//se o jogador digita numero 1, == linha 1 coluna1...


//int[,] array = new int[3, 3] { {1, 2 ,3},{4, 5, 6}, {7, 8, 9 } } ; //substituir para string
string[,] array = new string[3, 3] { { "1", "2" ,"3"},{"4", "5", "6"}, {"7", "8", "9" } };

Console.WriteLine("                |     |     ");
Console.WriteLine("              1 |  2  |  3  ");
Console.WriteLine("                |     |     ");
Console.WriteLine("            ----------------");
Console.WriteLine("                |     |     ");
Console.WriteLine("              4 |  5  |  6  ");
Console.WriteLine("                |     |     ");
Console.WriteLine("            ----------------");
Console.WriteLine("                |     |     ");
Console.WriteLine("              7 |  8  |  9  ");
Console.WriteLine("                |     |     ");






//Console.WriteLine("Agora é a vez do jogador: ",jogador);

string  posicao;
bool vezDoJogador1 = true;

Console.WriteLine("{jogardor1}Digite o número da posição: ");
posicao = Console.ReadLine();
//if (posicao = 1)
if (int.Parse(posicao) == 1)
{
    if (vezDoJogador1 = true)
    {
        array[0, 0] = "X";
    }
    else
        array[0, 0] = "O";
}
else if (int.Parse(posicao) == 2)
{
    if (vezDoJogador1 = true)
    {
        array[0, 1] = "X";
    }
    else
        array[0, 1] = "O";
}
else if (int.Parse(posicao) == 3)
{
    if (vezDoJogador1 = true)
    {
        array[0, 2] = "X";
    }
    else
        array[0, 2] = "O";
}
else if (int.Parse(posicao) == 4)
{
    if (vezDoJogador1 = true)
    {
        array[1, 0] = "X";
    }
    else
        array[1, 0] = "O";
}
else if (int.Parse(posicao) == 5)
{
    if (vezDoJogador1 = true)
    {
        array[1, 1] = "X";
    }
    else
        array[1, 1] = "O";
}
else if (int.Parse(posicao) == 6)
{
    if (vezDoJogador1 = true)
    {
        array[1, 2] = "X";
    }
    else
        array[1, 2] = "O";
}
else if (int.Parse(posicao) == 7)
{
    if (vezDoJogador1 = true)
    {
        array[2, 0] = "X";
    }
    else
        array[2, 0] = "O";
}
else if (int.Parse(posicao) == 8)
{
    if (vezDoJogador1 = true)
    {
        array[2, 1] = "X";
    }
    else
        array[2, 1] = "O";
}
else if (int.Parse(posicao) == 9)
{
    if (vezDoJogador1 = true)
    {
        array[2, 2] = "X";
    }
    else
        array[2, 2] = "O";
}

//testando
Console.Write(array[0, 0]);
Console.Write(array[0, 1]);
Console.WriteLine(array[0, 2]);
Console.Write(array[1, 0]);
Console.Write(array[1, 1]);
Console.WriteLine(array[1, 2]);
Console.Write(array[2, 0]);
Console.Write(array[2, 1]);
Console.Write(array[2, 2]);