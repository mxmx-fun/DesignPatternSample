namespace DesignPatternSample.Facade
{

    public class Car
    {
        private FuelSystem fuelSystem;
        private EngineSystem engineSystem;
        private TransmissionSystem transmissionSystem;
        private ElectronicSystem electronicSystem;

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
