namespace DesignPatternSample.Visitor
{
    public class CPUHardware : IHardware
    {
        string command;
        public string Command{get{return command;}set{command = value;}}
        int version;
        public int Version{get{return version;}set{version = value;}}
        
        public CPUHardware() {
            command = "CPU One Action";
            version = 1;
        }

        public void Run()
        {
            UnityEngine.Debug.Log($"{version}:{command}");
        }

        public void Update(IUpdateVisitor visitor)
        {
            visitor.Update(this);
        }
    }
}