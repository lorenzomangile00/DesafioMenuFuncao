﻿Console.Clear();//limpa tela
Console.WriteLine($"Digite seu nome:");//pede o nome do usuário
string nomeUsuario = Console.ReadLine();//guarda o nome na variável
Cumprimento(nomeUsuario);//chama a função e passa o nome

int opcao = -1;

do
{//todo o programa aqui dentro
 //desenha um menu de opções
    Console.WriteLine("Escolha uma opção no menu abaixo:");
    Console.WriteLine(" 1 - Coxinha");
    Console.WriteLine(" 2 - Pastel");
    Console.WriteLine(" 3 - Caldo de Cana");
    Console.WriteLine(" 4 - Bolo de Chocolate");
    Console.WriteLine(" 0 - Sair");
    //captura a opção do usuário
    opcao = int.Parse(Console.ReadLine());

    //escolhe a opção indicada pelo usuário
    switch (opcao)
    {
        case 1:
            Opcao1();
            break;
        case 2:
            Opcao2();
            break;
        case 3:
            Saudacao();
            Opcao3();
            break;

        case 4:
            Opcao4();
            break;
        case 0:
            Sair();
            break;
        default:
            NaoEncontrado();
            break;
    }

} while (opcao != 0);

Console.Clear();
Console.WriteLine($"FIM DO PROGRAMA");



// tipoDeDado Nome (parâmetros){corpo}

void Saudacao()
{
    Console.WriteLine("Olá, Meu amigo :)");
}

void Cumprimento(string n)
{
    Console.WriteLine($"Olá, {n}");
}

void Opcao1()
{
    Console.WriteLine($"Você escolheu a opção 1 - Coxinha {opcao * 2}");
}

void Opcao2()
{
    Console.WriteLine($"Você escolheu a opção 2 - Pastel");
}

void Opcao3()
{
    Console.WriteLine($"Você escolheu a opção 3 - Caldo de Cana");
}

void Opcao4()
{
    Console.WriteLine($"Você escolheu a opção 4 - Bolo de Chocolate");
}

void Sair()
{
    Console.WriteLine($"Você escolheu sair - Obrigado por usar o programa");
}

void NaoEncontrado()
{
    Console.WriteLine($"Não temos esta opção {opcao} !!");
}