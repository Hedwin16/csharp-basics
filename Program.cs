// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] numeros = new[] {1,2,3,4,5,6,7,8,9};

System.Console.WriteLine("Números impares: ");
IEnumerable<int> impares = from numero in numeros where numero %2 != 0 select numero;
System.Console.WriteLine("Cantidad de Números impares: "+impares.Count());
foreach(int impar in impares){
    System.Console.WriteLine("Impar: "+impar);
}