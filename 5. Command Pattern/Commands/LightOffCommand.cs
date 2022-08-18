using _5._Command_Pattern.Devices;

namespace _5._Command_Pattern.Commands
{
    internal class LightOffCommand : ICommand
    {
        Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Off();
        }

        public override string ToString()
        {
            return "Light OFF";
        }
    }
}
