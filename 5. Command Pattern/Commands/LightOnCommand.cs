using _5._Command_Pattern.Devices;

namespace _5._Command_Pattern.Commands
{
    internal class LightOnCommand : ICommand
    {
        Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }

        public override string ToString()
        {
            return "Light ON";
        }
    }
}
