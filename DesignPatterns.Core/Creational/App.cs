using System;
using System.Threading.Tasks;

namespace DesignPatterns.Core.Creational
{
    public class App
    {
        public static void Main()
        {
            var singletons = new Singleton[4];
            var tasks = new Task[4];
            for (var i = 0; i < singletons.Length; i++)
            {
                var j = i;
                tasks[i] = new Task(() => singletons[j] = Singleton.Instance);
            }
            Task.WaitAll(tasks);
            foreach (var singleton in singletons)
            {
                Console.WriteLine(singleton.GetHashCode());
            }
        }
    }
}
