using UsbLibrary;

namespace MissileControl
{
    /// <summary>
    /// Interface-Klasse für jeden (zukünftig) unterstützten Raketenwerfer
    /// </summary>
    public abstract class BaseLauncher
    {
        #region Variablen

            /// <summary>
            /// HID-Port zur Hardware
            /// </summary>
            public UsbHidPort Port;

            /// <summary>
            /// Vom Benutzer fortgeführte Aufzählung
            /// </summary>
            public int Nr;

            /// <summary>
            /// Gibt an, ob der Raketenwerfer mit Signalen versorgt werden soll oder nicht
            /// </summary>
            public bool Active;

            /// <summary>
            /// Gibt den Typ des Raketenwerfers an
            /// </summary>
            public LauncherType Type;

			/// <summary>
			/// Eindeutige ID für jeden Raketenwerfer
			/// </summary>
			private string ID;

            /// <summary>
            /// Die vom Raketenwerfer empfangenen Daten
            /// </summary>
            protected byte[] Data;

            /// <summary>
            /// Vertikaler Status
            /// </summary>
            protected Status VerticalStatus;

            /// <summary>
            /// Horizontaler Status
            /// </summary>
            protected Status HorizontalStatus;

            /// <summary>
            ///  Feuerstatus
            /// </summary>
            protected Status FiringStatus;

            /// <summary>
            /// Thread, der den Feuervorgang beinhaltet
            /// </summary>
            protected System.Threading.Thread FireThread;

            /// <summary>
            /// Kommandosequenzliste
            /// </summary>
            protected CommandoSeqQueue CSQ;

			/// <summary>
			/// Thread, der die Kommandosequenzliste ausführt
			/// </summary>
			protected System.Threading.Thread CSQThread;

        #endregion

        #region Methoden

            /// <summary>
            /// Konstruktor, hier wird später der Launchertyp festgelegt
            /// </summary>
            public BaseLauncher()
            {
                this.Type = LauncherType.Undefined_Missile_Launcher;
				this.CSQ = null;
            }

			/// <summary>
			/// Gibt die eindeutige Launcher-ID zurück
			/// </summary>
			public string GetID()
			{
				if (this.ID == null)
				{
					this.ID = this.Port.DeviceClass.ToString();
				}

				return Port.DeviceClass.ToString();
			}

            /// <summary>
            /// Funktion, um die Verbindung zum Launcher aufzubauen
            /// </summary>
            /// <returns></returns>
            public virtual bool Connect()
            {
                return false;
            }

            /// <summary>
            /// Funktion, die den Feuervorgang startet
            /// </summary>
            virtual public void Fire()
            {
            }

            /// <summary>
            /// Sendet die übergebenen Signale an den Launcher
            /// </summary>
            /// <param name="Command"></param>
            /// <param name="CommandType"></param>
            virtual public void SendCommand(LauncherCommandType Command)
            {
            }

			/// <summary>
			/// Weist dem Launcher eine Queue mit Kommandosequenzen
			/// </summary>
			/// <param name="CSQ"></param>
            virtual public void SetCommandoSeq(CommandoSeqQueue CSQ)
            {
                this.CSQ = CSQ;
            }

			/// <summary>
			/// Startet die mittels "SetCommandSeq(...)" übergebene Kommandosequenz-Queue
			/// </summary>
			/// <returns></returns>
			virtual public bool StartSequence()
			{
				return false;
			}

        #endregion
    }
}