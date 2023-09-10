namespace DesignPatternSample.Visitor
{
    public class UpdateVisitor : IUpdateVisitor
    {
        public void Update(CPUHardware hardware)
        {
            hardware.Command =  "CPU Two Action";
            hardware.Version = 2;
        }

        public void Update(MemoryHardware hardware)
        {
            hardware.Capacity = 2048;
            hardware.Version = 2;
        }
    }
}