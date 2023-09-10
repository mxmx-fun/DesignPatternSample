namespace DesignPatternSample.Visitor
{
    public interface IUpdateVisitor
    {
        void Update(CPUHardware hardware);
        void Update(MemoryHardware hardware);
    }
}