namespace _5._Command_Pattern.Devices
{
    internal class GarageDoor
    {
        public void Up() { Console.WriteLine("Garage door up"); }

        public void Down() { Console.WriteLine("Garage door down"); }

        public void Stop() { Console.WriteLine("Garage door stop"); }

        public void LightOn() { Console.WriteLine("Garage door light ON"); }

        public void LightOff() { Console.WriteLine("Garage door light OFF"); }
    }
}
