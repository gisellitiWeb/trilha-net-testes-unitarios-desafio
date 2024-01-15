// See https://aka.ms/new-console-template for more information
using TestesUnitarios.Desafio.Console.Services;

ValidacoesLista li = new ValidacoesLista();

List <int> Numeros = new List<int>();
Numeros.Add(9);
Numeros.Add(7);
Numeros.Add(3);
Numeros.Add(6);
li.MultiplicarNumerosLista(Numeros, 2);
