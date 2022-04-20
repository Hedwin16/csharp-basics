// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello World");
// int num=123;
// object o = num;
// Console.WriteLine("The num is "+o);
// List<int> lista = new List<int>();
// lista.Add(20);
// lista.Add(30);
// lista.Add(34);
// Console.WriteLine("---Lista de Números---");
// for (int i = 0; i < lista.Count; i++)
// {
//     Console.WriteLine("Número: "+lista[i]);
// }
// Añadir los archivos descargados desde la oficina al repositorio
// Expresiones Regulares + Eventos y Delegados:wq
//

Console.WriteLine("Introduce tu nombre: ");
string nombre = "Nombre";
nombre = Console.ReadLine();
Console.WriteLine("Introduce tu apellido: ");
string apellido = Console.ReadLine();
Console.WriteLine("Tu nombre Completo es: "+nombre+" "+apellido);
Console.WriteLine("Escribe un número para sumarlo: ");
string txtNum1 = Console.ReadLine();
Console.WriteLine("Escribe otro número para sumarlo: ");
string txtNum2 = Console.ReadLine();

int num1, num2;
num1 = int.Parse(txtNum1);
num2 = int.Parse(txtNum2);
int resultado = sumar(num1,num2);

Console.WriteLine("El resultado de la suma es: "+resultado);
Console.WriteLine("Tu nombre en mayúscula es: "+nombre.ToUpper());


int sumar(int num1, int num2)
{
    return num1+num2;
}

calcularPromedio();

void calcularPromedio()
{
    double promedio = 0;
    int numeroAlumnos = 0;
    System.Console.WriteLine("Para finalizar el algoritmo ingrese el valor '123'");
    while(true){
        Console.WriteLine("Ingrese nota de alumno: ");
        int nota = 0;
        try
        {
        nota = Convert.ToInt32(Console.ReadLine());
        }
        catch (System.FormatException)
        {
            throw new Exception("Error Introduzca un numero válido....");
        }
        if(nota == 123){
            break;
        }
        promedio = promedio + nota;
        numeroAlumnos++;
    }
    promedio = promedio/(double)numeroAlumnos;
    System.Console.WriteLine("El promedio final es de: "+promedio);
}
