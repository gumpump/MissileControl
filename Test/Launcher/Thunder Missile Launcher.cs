using UsbLibrary;

namespace MissileControl
{
    class Thunder_Missile_Launcher : BaseLauncher
    {
        public Thunder_Missile_Launcher()
        {
            this.Type = LauncherType.Thunder_Missile_Launcher;
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
                this.Port.SpecifiedDevice.DataRecieved += new DataRecievedEventHandler(SpecifiedDevice_DataRecieved);
                return true;
            }

            else
            {
                return false;
            }
        }

        private void SpecifiedDevice_DataRecieved(object sender, DataRecievedEventArgs args)
        {
            Data = args.data;

            switch (Data[1])
            {
                case 0x11:
                {
                    FiringStatus = Status.DoneFiring;
                } break;
            }
        }

        public override void Fire()
        {
            if (FireThread != null)
            {
                if (FireThread.ThreadState == System.Threading.ThreadState.Running)
                    FireThread.Abort();
                FireThread = null;
                System.Threading.Thread.Sleep(500);
            }

            FireThread = new System.Threading.Thread(new System.Threading.ThreadStart(FireThreadFunc));
            FireThread.Start();
        }

        private void FireThreadFunc()
        {
            SendCommand(LauncherCommandType.Fire);

            while (true)
            {
                if (FiringStatus == Status.DoneFiring)
                {
                    SendCommand(LauncherCommandType.Stop);
                    System.Threading.Thread.Sleep(500);
                    return;
                }
            }
        }

        public override void SendCommand(LauncherCommandType Command)
        {
            if (this.Active == true)
            {
                if (Command == LauncherCommandType.Request)
                {
                    byte[] D = new byte[9];
					D[1] = (byte)LauncherCommandList.CommandList[(int)LauncherType.Thunder_Missile_Launcher, (int)Command];
                    this.Port.SpecifiedDevice.SendData(D);
                }

                else
                {
                    byte[] D = new byte[9];
                    D[1] = 0x02;
					D[2] = (byte)LauncherCommandList.CommandList[(int)LauncherType.Thunder_Missile_Launcher, (int)Command];
                    this.Port.SpecifiedDevice.SendData(D);
                }
            }
        }

		public override bool StartSequence()
		{
			if (CSQ == null)
			{
				return false;
			}

			else
			{
				if (CSQThread == null)
				{
					CSQThread = new System.Threading.Thread(new System.Threading.ThreadStart(CSQThreadFunc));
					CSQThread.Start();
				}

				else
				{
					if (CSQThread.ThreadState != System.Threading.ThreadState.Running)
					{
						CSQThread = null;
						CSQThread = new System.Threading.Thread(new System.Threading.ThreadStart(CSQThreadFunc));
						CSQThread.Start();
					}
				}

				return true;
			}
		}

		private void CSQThreadFunc()
		{
			System.Collections.Queue CSQueue = CSQ.GetQueue();

			foreach (CommandoSeq CS in CSQueue)
			{
				switch (CS.Type)
				{
					case (LauncherCommandType.Fire):
					{
						this.Fire();
					} break;

					case (LauncherCommandType.Timer):
					{
						System.Threading.Thread.Sleep(CS.Milliseconds);
					} break;

					default:
					{
						this.SendCommand(CS.Type);
					} break;
				}
			}

			return;
		}
    }
}