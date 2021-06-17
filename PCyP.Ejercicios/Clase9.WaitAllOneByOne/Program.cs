using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clase9.WaitAllOneByOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();

            sw.Start();

            Task<int> t1 = new Task<int>(() =>{
                Thread.Sleep(2000);
                Console.WriteLine("Calculando el resultado de t1");

                return 500;
               });

            Task<int> t2 = new Task<int>(() =>
              {
                  Thread.Sleep(1000);
                  Console.WriteLine("Calculando el resultado de t2");
                  return 200;
              });

            Task<int> t3 = new Task<int>(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Calculando el resultado de t3");
                return 30;
            });

            Task<int> t4 = new Task<int>(() =>
            {
  
                Console.WriteLine("Calculando el resultado de t4");
                return 15;
            });

            var taskList = new List<Task<int>>();
            taskList.Add(t1);
            taskList.Add(t2);
            taskList.Add(t3);
            taskList.Add(t4);

            taskList.ForEach(task => task.Start());

            Console.WriteLine("Main en progreso");

            while (taskList.Count > 0)
            {
                var index = Task.WaitAny(taskList.ToArray());
                Console.WriteLine("El resultado de la tarea " + taskList[index].Id + " es: "+taskList[index].Result);
                taskList.RemoveAt(index);
            }

            Console.WriteLine("fin del Main.");

            sw.Stop();

            Console.WriteLine("The used time was {0} seconds", (sw.ElapsedMilliseconds / 1000));
            Console.ReadLine();

        }

    }
}
