namespace dotnet_POO.src.Entities
{
  public class Ninja : Personagem
  {
    public Ninja(string name, int level, string heroType, int hp, int maxHp, int mp, int maxMp)
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
      return $"\n{Name} lançou seu golpe.";
    }

    public override string Attack(int bonus)
    {
      if (bonus > 5)
      {
        return $"\n{Name} lançou um super golpe com bônus de ataque de {bonus}.";

      }
      else
      {
        return $"\n{Name} lançou um golpe fraco com bônus de ataque de {bonus}.";

      }
    }

  }
}