namespace ClassLibrary.Decorators
{
    public abstract class HeroDecorator : IHero
    {
        protected IHero hero;

        public HeroDecorator(IHero hero)
        {
            this.hero = hero;
        }

        public virtual string GetDescription() => hero.GetDescription();
        public virtual int GetPower() => hero.GetPower();
    }
}
