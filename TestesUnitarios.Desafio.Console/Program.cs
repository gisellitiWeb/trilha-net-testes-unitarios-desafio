﻿// See https://aka.ms/new-console-template for more information
using TestesUnitarios.Desafio.Console.Services;

ValidacoesLista li = new ValidacoesLista();

List <int> Numeros = new List<int>();
Numeros.Add(9);
Numeros.Add(7);
Numeros.Add(3);
Numeros.Add(6);
List <int> NumerosNovos = new List<int>();
NumerosNovos = li.MultiplicarNumerosLista(Numeros, 2);
foreach (int num in NumerosNovos)
{
    Console.WriteLine(num);
}
