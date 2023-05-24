// See https://aka.ms/new-console-template for more information
using Bener;
using Bener.Enuns;
using System.Linq.Expressions;
using System.Reflection.Metadata;

int qntElementos;


Console.WriteLine("digite a quantidade de elementos.");
qntElementos = Convert.ToInt32(Console.ReadLine());

Network network =  new Network(qntElementos);
Menu menu = new Menu();

menu.listarMenu(network);




