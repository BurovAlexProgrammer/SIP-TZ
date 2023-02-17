namespace Player
{
    public class PlayerMain : PlayerBase
    {
        public override void InstallBindings()
        {
            Container.Bind<PlayerBase>().FromInstance(this);
        }
    }
}