namespace dotnet_POO.src.Entities
{
  public abstract class Personagem
  {
    public string Name { get; set; }
    public int Level { get; set; }
    public string HeroType { get; set; }
    public int Hp { get; set; }
    public int MaxHp { get; set; }
    public int Mp { get; set; }
    public int MaxMp { get; set; }

    public Personagem(string name, int level, string heroType, int hp, int maxHp, int mp, int maxMp)
    {
      Name = name;
      Level = level;
      HeroType = heroType;
      Hp = hp;
      MaxHp = maxHp;
      Mp = mp;
      MaxMp = maxMp;
    }
    public Personagem()
    {

    }

    public virtual string Attack()
    {
      return $"\n{Name} atacou.";
    }

    public virtual string Attack(int bonus)
    {
      return $"\n{Name} atacou com um bônus de {bonus}.";
    }


    public override string ToString()
    {

      if (Mp > 99)
      {
        return $@"
      {Name}
        lv.      {Level}   {HeroType}
        HP      {Hp} / {MaxHp}
        MP      {Mp} / {MaxMp}";

      }
      else
      {
        return $@"
      {Name}
        lv.      {Level}   {HeroType}
        HP      {Hp} / {MaxHp}
        MP       {Mp} / {MaxMp}";
      }
    }
  }
}