// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
System.Console.WriteLine("Threads - Hilos");

// System.Console.WriteLine("Hola Mundo 1");
// Thread.Sleep(1000);
// System.Console.WriteLine("Hola Mundo 2");
// Thread.Sleep(1000);
// System.Console.WriteLine("Hola Mundo 3");
// Thread.Sleep(1000);
// System.Console.WriteLine("Hola Mundo 4");
// Thread.Sleep(1000);
// System.Console.WriteLine("Hola Mundo 5");

// new Thread(()=>
// {
//     Thread.Sleep(1000);
//     Console.WriteLine("Subproceso 1");
// }).Start();

// new Thread(()=>
// {
//     Thread.Sleep(1000);
//     Console.WriteLine("Subproceso 2");
// }).Start();

// new Thread(()=>
// {
//     Thread.Sleep(1000);
//     Console.WriteLine("Subproceso 3");
// }).Start();

// new Thread(()=>
// {
//     Thread.Sleep(1000);
//     Console.WriteLine("Subproceso 4");
// }).Start();


Enumerable.Range(0, 1000).ToList().ForEach(f =>
{
    ThreadPool.QueueUserWorkItem((o) =>
    {
        System.Console.WriteLine($"Número de Subproceso: {Thread.CurrentThread.ManagedThreadId} ha iniciado");
        Thread.Sleep(5000);
        System.Console.WriteLine($"Número de Subproceso: {Thread.CurrentThread.ManagedThreadId} ha terminado");

    });
});


