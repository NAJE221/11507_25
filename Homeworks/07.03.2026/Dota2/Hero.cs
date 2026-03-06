namespace Dota2;

public class Hero
{
    public string Name { get; init; }
    public string Complexity { get; init; }
    public string TypeAttribute {get; init; }
    public string TypeAttack {get; init; }
    public int Health {get; init; }
    public int Damage {get; init; }
    public int Armor {get; init; }
    public int Mana {get; init; }

    public Hero(
        string name, 
        string complexity, 
        string typeAttribute, 
        string typeAttack, 
        int health,
        int damage,
        int armor,
        int mana)
    {
        Name = name;
        Complexity = complexity;
        TypeAttribute = typeAttribute;
        TypeAttack = typeAttack;
        Health = health;
        Damage = damage;
        Armor = armor;
        Mana = mana;
    }
    
    public override string ToString()
    {
        return $"{Name};{Complexity};{TypeAttribute};{TypeAttack};" +
               $"{Health};{Damage};{Armor};{Mana}";
    }
    
}