namespace dotnet_POO.src.Entities
{
  public class Knight : Personagem
  {
    public Knight(string name, int level, string heroType, int hp, int maxHp, int mp, int maxMp)
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
      return $"\n{Name} atacou com a sua espada.";
    }

    public override string Attack(int bonus)
    {
      if (bonus > 5)
      {
        return $"\n{Name} lançou um super ataque com a espada com bônus de ataque de {bonus}.";

      }
      else
      {
        return $"\n{Name} lançou um ataque fraco com a espada com bônus de ataque de {bonus}.";

      }
    }

  }
}