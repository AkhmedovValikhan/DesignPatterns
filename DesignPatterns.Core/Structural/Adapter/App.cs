namespace DesignPatterns.Core.Structural.Adapter
{
    public class App
    {
        public void Main()
        {
            ITarget targetComponent = new Adapter();
            targetComponent.DoWork();
        }
    }
}
