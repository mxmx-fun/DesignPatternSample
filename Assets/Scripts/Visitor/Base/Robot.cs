namespace DesignPatternSample.Visitor
{
    public class Robot 
    {
        CPUHardware cpu;
        MemoryHardware memory;

        public Robot()
        {
            cpu = new CPUHardware();
            memory = new MemoryHardware();
        }

        public void Update(UpdateVisitor visitor)
        {
            cpu.Update(visitor);
            memory.Update(visitor);
        }

        public void Run()
        {
            cpu.Run();
            memory.Run();
        }
    }
}