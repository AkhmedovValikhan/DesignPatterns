namespace DesignPatterns.Core.Structural.Adapter
{
    /// <summary>
    /// Adapter: adapts existing specific inteface to target interface
    /// </summary>
    public class Adapter : Adaptee, ITarget
    {
        public void DoWork()
        {
            DoSpecificWork();
        }
    }
}