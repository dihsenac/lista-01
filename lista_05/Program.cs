﻿/*Verificação de idade
 

Objetivo: Aplicar condições para classificar os dados. 
Descrição: Desenvolva um programa que pergunte a idade de uma pessoa e determine se ela é maior de idade (18 anos ou mais) ou menor de idade. Use if e else para exibir a mensagem apropriada. 
Exemplo de saída: "Você é maior de idade." ou "Você é menor de idade".*/

Console.WriteLine("Digite sua idade");
int idade  = int.Parse(Console.ReadLine());
if (idade >= 18) 
{
Console.WriteLine("você é maior de idade.")
}