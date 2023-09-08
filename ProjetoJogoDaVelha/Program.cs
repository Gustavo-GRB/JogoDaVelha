﻿using System.Numerics;
using System;
using System.Security.Cryptography;

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
    Console.WriteLine($"Jogador {jogardor1} você começa a primeira jogada");
    numeroAleatorio = 1;
}


string[,] array = new string[3, 3] { 
    { "1", "2", "3" }, 
    { "4", "5", "6" }, 
    { "7", "8", "9" } };

bool vezDoJogador1 = true;
string posicao = "0";

for (int i = 0; i < 9; i++)
{
    bool jogadaInvalida = false;
    exibirTabuleiro(array);

    if (!jogadaInvalida)
    {        
        if (vezDoJogador1)
        {
            Console.WriteLine($"\n-> {jogardor1} Digite o número da posição conforme os números acima: ");
            posicao = Console.ReadLine();
            Console.Clear();

            bool numeroEncontrado = false;

            foreach (var item in array)
            {
                if (item == posicao)
                {
                    numeroEncontrado = true;
                    break;
                }
            }
            if (!numeroEncontrado)
            {

                while (!numeroEncontrado)
                {
                    Console.Clear();
                    exibirTabuleiro (array);
                    jogadaInvalida = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("***** Posição escolhida não existe ou já foi escolhida! *****");
                    Console.ResetColor();
                    
                    Console.WriteLine($"\n-> {jogardor1} Digite o número da posição conforme os números acima: ");
                    posicao = Console.ReadLine();

                    //duplicado
                    foreach (var item in array)
                    {
                        if (item == posicao)
                        {
                            numeroEncontrado = true;
                            break;
                        }
                    }
                }
            }
        }
        else
        {
            Console.WriteLine($"\n-> {jogardor2} Digite o número da posição conforme os números acima: ");
            posicao = Console.ReadLine();
            Console.Clear();
        }
    }

    vezDoJogador1 = PreencherTabuleiro(array, posicao, vezDoJogador1);



}





static void exibirTabuleiro(string[,] array)
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


/*
 * -Corrigido a mensagem de quem deve começar primeiro
 * -Iniciando a implantação da regra de posicao ocupada e posição não existente
 * testar escolhendo numeros diferentes na primeira jogada(aparentemente o num 1 funfa agora testar resto
 */
