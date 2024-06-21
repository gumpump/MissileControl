using UsbLibrary;

namespace MissileControl
{
    class MSN_Missile_Launcher : BaseLauncher
    {
        public MSN_Missile_Launcher()
        {
            this.Type = LauncherType.MSN_Missile_Launcher;
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

        public void AddDataListener()
        {
            this.Port.SpecifiedDevice.DataRecieved += new UsbLibrary.DataRecievedEventHandler(SpecifiedDevice_DataRecieved);
        }

        void SpecifiedDevice_DataRecieved(object sender, UsbLibrary.DataRecievedEventArgs args)
        {
            this.Data = args.data;

            int b1 = this.Data[0];
            int b2 = this.Data[1];

            switch (this.Type)
            {
                case LauncherType.MSN_Missile_Launcher:
                    {
                        switch (b1)
                        {
                            case 0x00:
                                VerticalStatus = Status.Normal;
                                break;
                            case ReadConstants.FULL_DOWN:
                                VerticalStatus = Status.FullDown;
                                break;
                            case ReadConstants.FULL_UP:
                                VerticalStatus = Status.FullUp;
                                break;
                            default:
                                VerticalStatus = Status.Unknown;
                                break;
                        }

                        switch (b2)
                        {
                            case 0x00:
                                HorizontalStatus = Status.Normal;
                                FiringStatus = Status.DoneFiring;
                                break;
                            case ReadConstants.FULL_LEFT:
                                HorizontalStatus = Status.FullLeft;
                                break;
                            case ReadConstants.FULL_RIGHT:
                                HorizontalStatus = Status.FullRight;
                                break;
                            case ReadConstants.PRIME_DONE:
                                if (FiringStatus == Status.DonePriming)
                                    HorizontalStatus = Status.Normal;
                                FiringStatus = Status.DonePriming;
                                break;
                            case ReadConstants.FULL_LEFT_PRIME_DONE:
                                HorizontalStatus = Status.FullLeft;
                                FiringStatus = Status.DonePriming;
                                break;
                            case ReadConstants.FULL_RIGHT_PRIME_DONE:
                                HorizontalStatus = Status.FullRight;
                                FiringStatus = Status.DonePriming;
                                break;
                            default:
                                HorizontalStatus = Status.Unknown;
                                break;
                        }
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

        private void Prime()
        {
            if (FiringStatus == Status.DonePriming)
                return;

            SendCommand(LauncherCommandType.Fire);

            while (true)
            {
                if (FiringStatus == Status.DonePriming)
                {
                    SendCommand(LauncherCommandType.Stop);
                    return;
                }
            }
        }

        private void FireThreadFunc()
        {
            Prime();
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
                byte[] D = new byte[9];
				D[1] = (byte)LauncherCommandList.CommandList[(int)LauncherType.MSN_Missile_Launcher, (int)Command];
                this.Port.SpecifiedDevice.SendData(D);
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
					case(LauncherCommandType.Fire):
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
		}
    }
}