using _5._Command_Pattern;
using _5._Command_Pattern.Commands;
using _5._Command_Pattern.Devices;

RemoteControl remote = new();
Light light = new();
remote.SetCommand(1, new LightOnCommand(light), new LightOffCommand(light));
remote.OnPressButton(1);
remote.OffPressButton(1);
Console.WriteLine(remote.ToString());