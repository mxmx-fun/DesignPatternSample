namespace DesignPatternSample.Visitor
{
    public class MemoryHardware : IHardware
    {
        int capacity;
        public int Capacity { get{return capacity;} set{capacity = value;} }
        int version;
        public int Version { get{return version;} set{version = value;} }
        public MemoryHardware()
        {
            capacity = 1024;
            version = 1;
        }

        public void Run()
        {
            UnityEngine.Debug.Log($"{version}:{capacity}KB");
        }

        public void Update(IUpdateVisitor visitor)
        {
            visitor.Update(this);
        }
    }
}