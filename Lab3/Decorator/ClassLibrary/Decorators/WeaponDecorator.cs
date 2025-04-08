namespace ClassLibrary.Decorators
{
    public class WeaponDecorator : HeroDecorator
    {
        public WeaponDecorator(IHero hero) : base(hero) { }

        public override string GetDescription() => base.GetDescription() + "\n + Зброя";
        public override int GetPower() => base.GetPower() + 5;
    }
}
