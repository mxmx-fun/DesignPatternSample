namespace DesignPatternSample.Visitor
{
    public interface IHardware
    {
        void Run();
        void Update(IUpdateVisitor visitor);
    }
}