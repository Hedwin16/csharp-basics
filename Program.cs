System.Console.WriteLine("Main ha comenzado");
Thread hilo1 = new Thread(FunctionThread1);
Thread hilo2 = new Thread(FunctionThread2);
hilo1.Start();
hilo2.Start();

// hilo1.Join();
// System.Console.WriteLine("Función1 está Listo");
if (hilo1.Join(1000))
{
    System.Console.WriteLine("Funcion 1 Terminada");
}
else
{

    System.Console.WriteLine("Funcion 1 no terminó en 1 segundo");
}

hilo2.Join();
System.Console.WriteLine("Función2 está Listo");
for (int i = 0; i < 10; i++)
{
    if (hilo1.IsAlive)
    {
        System.Console.WriteLine("Hilo 1 sigue ejecutandose");
        Thread.Sleep(1000);
    }
    else
    {
        System.Console.WriteLine("Hilo 1 terminó la ejecución");
    }


}

System.Console.WriteLine("Main ha finalizado");

static void FunctionThread1()
{
    System.Console.WriteLine("Inició FuncionThread1");
    Thread.Sleep(3000);
    System.Console.WriteLine("Funcion1 regresa al main");
}

static void FunctionThread2()
{
    System.Console.WriteLine("Inició FuncionThread1");
}