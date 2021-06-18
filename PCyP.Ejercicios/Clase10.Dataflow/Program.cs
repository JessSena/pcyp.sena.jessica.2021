using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Implementación del patrón Dataflow para cálculo de promedio de precios.
/// </summary>
namespace Clase10.Dataflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();

            sw.Start();

            Task<int> t1 = new Task<int>(() => {
                Thread.Sleep(2000);
                Console.WriteLine("Calculando el precio de t1");
                return 500;
            });

            Task<int> t2 = new Task<int>(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Calculando el precio de t2");
                return 200;
            });

            Task<int> t3 = new Task<int>(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Calculando el precio de t3");
                return 30;
            });

            var taskList = new List<Task<int>>();
            taskList.Add(t1);
            taskList.Add(t2);
            taskList.Add(t3);


            taskList.ForEach(task => task.Start());



            Task<double> t4 = 
                Task.Factory.ContinueWhenAll<int,double>(
                    new[] {t1,t2,t3},
                    (tasks)=>
            {
                double result=0;
                Console.WriteLine("t4..Cocechando resultados de precios de t1,t2 y t3");

                foreach (Task<int> t in tasks)
                {
                  
                    Console.WriteLine("El resultado de la tarea " + t.Id + " es: " + t.Result);
                    result += t.Result;
             
                }

                return result/3;

            });

            Console.WriteLine("Main en progreso");

            
            Task t5 =
                t4.ContinueWith( (predecesor)=>
              
                    {
                   
                        Console.WriteLine("t5..Cocechando resultados t4... El promedio de los precios es {0} ", predecesor.Result);
                        
                    });

            t5.Wait();

            Console.WriteLine("fin del Main.");

            sw.Stop();

            Console.WriteLine("Tiempo de este algoritomo {0} segundos", (sw.ElapsedMilliseconds / 1000));
            Console.ReadLine();
        }
    }
}
