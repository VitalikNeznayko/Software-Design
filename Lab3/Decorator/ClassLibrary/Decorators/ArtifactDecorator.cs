namespace ClassLibrary.Decorators
{
    public class ArtifactDecorator : HeroDecorator
    {
        public ArtifactDecorator(IHero hero) : base(hero) { }

        public override string GetDescription() => base.GetDescription() + "\n + Магічний артіфакт";
        public override int GetPower() => base.GetPower() + 4;
    }
}
