using UsbLibrary;

namespace MissileControl
{
    class Storm_OIC_Missile_Launcher : BaseLauncher
    {
        public Storm_OIC_Missile_Launcher()
        {
            this.Type = LauncherType.Storm_OIC_Missile_Launcher;
        }

        public override bool Connect()
        {
            return base.Connect();
        }

        public override void Fire()
        {
            throw new System.NotImplementedException();
        }

        public override void SendCommand(LauncherCommandType Command)
        {
            throw new System.NotImplementedException();
        }
    }
}