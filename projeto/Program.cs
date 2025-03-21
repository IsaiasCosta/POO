﻿// Variável para armazenar a ação
int acao = 0;

// Criar objeto Crud
Crud crud = new();

// Laço de repetição
do
{
    // Lista ações
    Console.WriteLine("1º Cadastrar");
    Console.WriteLine("2º Selecionar");
    Console.WriteLine("3º Alterar");
    Console.WriteLine("4º Remover");
    Console.WriteLine("5º Finalizar");

    // Tenta converter a entrada do usuário
    try
    {
        acao = Convert.ToInt16(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada inválida. Por favor, insira um número.");
        continue; // Volta ao início do laço
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
        continue; // Volta ao início do laço
    }

    // Estrutura de escolha
    switch (acao)
    {
        case 1:
            crud.Cadastrar();
            break;

        case 2:
            crud.Selecionar();
            break;

        case 3:
            crud.Alterar();
            break;

        case 4:
            crud.Remover();
            break;

        case 5:
            Console.WriteLine("Sistema finalizado.");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

} while (acao != 5);
