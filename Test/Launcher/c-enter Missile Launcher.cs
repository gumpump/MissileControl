using UsbLibrary;

namespace MissileControl
{
    class c_enter_Missile_Launcher : BaseLauncher
    {
        public c_enter_Missile_Launcher()
        {
            this.Type = LauncherType.c_enter_Missile_Launcher;
        }

        public override bool Connect()
        {
            this.Port = new UsbHidPort();
            this.Port.VendorId = LauncherIDList.IDList[(int)this.Type].VendorID;
            this.Port.ProductId = LauncherIDList.IDList[(int)this.Type].ProductID;
            this.Port.CheckDevicePresent();
            if (this.Port.SpecifiedDevice != null)
            {
                this.Active = false;
                return true;
            }

            else
            {
                return false;
            }
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