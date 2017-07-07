namespace AdvancedUnitTesting.Domain
{
    public interface IMotor { bool Start(); bool Stop(); }

    public class Car
    {
        public Car(IMotor motor) { _Motor = motor; }

        IMotor _Motor;

        public bool Drive()
        {
            bool started = _Motor.Start();
            bool stopped = _Motor.Stop();
            return started && stopped;
        }
    }
}
