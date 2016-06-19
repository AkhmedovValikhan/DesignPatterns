using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Core.Creational
{
    /// <summary>
    /// Ensure a class has only one instance and provide a global point of access to it.
    /// </summary>
    public class Singleton
    {
        private static Singleton _instance;
        private static readonly object _syncObject = new object();

        protected Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                //Prevent redundant critical section enters
                if (_instance == null)
                {
                    lock (_syncObject)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
