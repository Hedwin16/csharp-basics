// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello World");
int num=123;
object o = num;
Console.WriteLine("The num is "+o);
List<int> lista = new List<int>();
lista.Add(20);
lista.Add(30);
lista.Add(34);
lista.Add(50);
lista.Add(2120);

Console.WriteLine("---Lista de Números---");
for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine("Número: "+lista[i]);
}