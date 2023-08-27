namespace DesignPatternSample.Facade
{

    public class Car
    {
        private FuelSystem fuelSystem;
        public FuelSystem FuelSystem { get { return fuelSystem; } }
        
        private EngineSystem engineSystem;
        public EngineSystem EngineSystem { get { return engineSystem; } }

        private TransmissionSystem transmissionSystem;
        public TransmissionSystem TransmissionSystem { get { return transmissionSystem; } }

        private ElectronicSystem electronicSystem;
        public ElectronicSystem ElectronicSystem { get { return electronicSystem; } }

        public Car()
        {
            fuelSystem = new FuelSystem();
            engineSystem = new EngineSystem();
            transmissionSystem = new TransmissionSystem();
            electronicSystem = new ElectronicSystem();
        }

        public void Start()
        {
            fuelSystem.Start();
            engineSystem.Start();
            transmissionSystem.Start();
            electronicSystem.Start();
        }

        public void Stop()
        {
            fuelSystem.Stop();
            engineSystem.Stop();
            transmissionSystem.Stop();
            electronicSystem.Stop();
        }
    }
}
