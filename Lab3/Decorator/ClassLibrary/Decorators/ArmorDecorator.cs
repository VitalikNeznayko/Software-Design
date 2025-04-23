namespace ClassLibrary.Decorators
{
    public class ArmorDecorator : HeroDecorator
    {
        public ArmorDecorator(IHero hero) : base(hero) { }

        public override string GetDescription() => base.GetDescription() + "\n + Броня";
        public override int GetPower() => base.GetPower() + 3;
    }
}
