using _5._Command_Pattern.Commands;
using System.Text;

namespace _5._Command_Pattern
{
    internal class RemoteControl
    {
        ICommand[] _onCommands;
        ICommand[] _offCommands;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            NoCommand noCommand = new();

            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnPressButton(int slot)
        {
            _onCommands[slot].Execute();
        }

        public void OffPressButton(int slot)
        {
            _offCommands[slot].Execute();
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new();
            strBuilder.AppendLine("--- Remote Control ---");
            for (int i = 0; i < _onCommands.Length; i++)
            {
                strBuilder.AppendLine($"slot: {i} - {_onCommands[i]} / {_offCommands[i]}");
            }

            return strBuilder.ToString();
        }
    }
}
