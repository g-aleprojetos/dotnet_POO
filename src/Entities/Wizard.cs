namespace dotnet_POO.src.Entities
{
  public class Wizard : Personagem
  {

    public Wizard(string name, int level, string heroType, int hp, int maxHp, int mp, int maxMp)
    {
      Name = name;
      Level = level;
      HeroType = heroType;
      Hp = hp;
      MaxHp = maxHp;
      Mp = mp;
      MaxMp = maxMp;
    }

    public override string Attack()
    {
      return $"\n{Name} lançou magia.";
    }

    public override string Attack(int bonus)
    {
      if (bonus > 6)
      {
        return $"\n{Name} lançou Magia super efetiva com bônus de ataque de {bonus}.";

      }
      else
      {
        return $"\n{Name} lançou magia com força fraca com bônus de ataque de {bonus}.";

      }
    }
  }
}