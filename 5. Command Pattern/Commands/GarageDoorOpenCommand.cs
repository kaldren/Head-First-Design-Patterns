using _5._Command_Pattern.Devices;

namespace _5._Command_Pattern.Commands
{
    internal class GarageDoorOpenCommand : ICommand
    {
        GarageDoor _garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Up();
        }
    }
}
