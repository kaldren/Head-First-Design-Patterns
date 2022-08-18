CharacterMenu charMenu = new ElfCharacterMenu("Johnnie129");
charMenu.SetWeapon();
charMenu.SetArmor();

charMenu = new DwarfCharacterMenu("Bobby222");
charMenu.SetWeapon();
charMenu.SetArmor();

// Product
abstract class Hero
{
    public string Name { get; protected set; }

    public int Health { get; protected set; }

    public int Strength { get; protected set; }

    public int Agility { get; protected set; }
}

// Concrete products
class Elf : Hero
{
    public Elf(string name)
    {
        Name = name;
        Health = 20;
        Strength = 10;
        Agility = 17;
    }
}

class Dwarf : Hero
{
    public Dwarf(string name)
    {
        Name = name;
        Health = 16;
        Strength = 31;
        Agility = 19;
    }
}

abstract class CharacterMenu
{
    Hero _hero;

    public CharacterMenu(string name)
    {
        _hero = CreateCharacter(name);
    }

    public void SetArmor()
    {
        Console.WriteLine($"Setting armor for {_hero.Name} of type {_hero}");
    }

    public void SetWeapon()
    {
        Console.WriteLine($"Setting weapon for {_hero.Name} of type {_hero}");
    }

    // Factory method
    protected abstract Hero CreateCharacter(string name);
}

class ElfCharacterMenu : CharacterMenu
{
    public ElfCharacterMenu(string name) : base(name)
    {
    }

    protected override Hero CreateCharacter(string name)
    {
        return new Elf(name);
    }
}

class DwarfCharacterMenu : CharacterMenu
{
    public DwarfCharacterMenu(string name) : base(name)
    {
    }

    protected override Hero CreateCharacter(string name)
    {
        return new Dwarf(name);
    }
}