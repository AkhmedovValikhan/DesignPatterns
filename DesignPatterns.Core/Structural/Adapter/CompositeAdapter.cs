namespace DesignPatterns.Core.Structural.Adapter
{
    /// <summary>
    /// Adapter: using composition to reference to Adptee. Is used if inheritance is unavailable or undesireable
    /// </summary>
    public class CompositeAdapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public CompositeAdapter()
        {
            _adaptee = new Adaptee();
        }

        public void DoWork()
        {
            _adaptee.DoSpecificWork();
        }
    }
}