namespace MissileControl
{
    /// <summary>
    /// Auflistung aller Raketenwerfer-Typen
    /// </summary>
    public enum LauncherType
    {
        MSN_Missile_Launcher = 0,
        Thunder_Missile_Launcher,
        Storm_OIC_Missile_Launcher,
        c_enter_Missile_Launcher,
        Count,
        Undefined_Missile_Launcher = -1
    }

    /// <summary>
    /// Auflistung aller Commando-Typen
    /// </summary>
    public enum LauncherCommandType
    {
        Up = 0,
        Left,
        Down,
        Right,
        Fire,
        Stop,
        Request,
		Timer,
        Count,
		Undefined_Command_Type = -1
    }

    /// <summary>
    /// Auflistung aller benötigten Konstanten, die an den Raketenwerfer gesendet werden können
    /// </summary>
    public struct LauncherCommand
    {
        // MSN_Missile_Launcher
        public const int MSN_UP = 0x02;
        public const int MSN_LEFT = 0x04;
        public const int MSN_DOWN = 0x01;
        public const int MSN_RIGHT = 0x08;
        public const int MSN_FIRE = 0x10;
        public const int MSN_STOP = 0x20;
        public const int MSN_REQ = 0x40;

        // Thunder_Missile_Launcher
        public const int THU_UP = 0x02;
        public const int THU_LEFT = 0x04;
        public const int THU_DOWN = 0x01;
        public const int THU_RIGHT = 0x08;
        public const int THU_FIRE = 0x10;
        public const int THU_STOP = 0x20;
        public const int THU_REQ = 0x01;
    }

    /// <summary>
    /// Hilfsklasse für die SendCommand()-Methode.
    /// Das Array CommandList enthält für jeden Raketenwerfertyp alle benötigten Kommandos.
    /// </summary>
    public static class LauncherCommandList
    {
        public static int[,] CommandList;

        static LauncherCommandList()
        {
            CommandList = new int[(int)LauncherType.Count, (int)LauncherCommandType.Count];

            CommandList[(int)LauncherType.MSN_Missile_Launcher, (int)LauncherCommandType.Up]    = LauncherCommand.MSN_UP;
            CommandList[(int)LauncherType.MSN_Missile_Launcher, (int)LauncherCommandType.Left]  = LauncherCommand.MSN_LEFT;
            CommandList[(int)LauncherType.MSN_Missile_Launcher, (int)LauncherCommandType.Down]  = LauncherCommand.MSN_DOWN;
            CommandList[(int)LauncherType.MSN_Missile_Launcher, (int)LauncherCommandType.Right] = LauncherCommand.MSN_RIGHT;
            CommandList[(int)LauncherType.MSN_Missile_Launcher, (int)LauncherCommandType.Fire]  = LauncherCommand.MSN_FIRE;
            CommandList[(int)LauncherType.MSN_Missile_Launcher, (int)LauncherCommandType.Stop] = LauncherCommand.MSN_STOP;
            CommandList[(int)LauncherType.MSN_Missile_Launcher, (int)LauncherCommandType.Request] = LauncherCommand.MSN_REQ;

            CommandList[(int)LauncherType.Thunder_Missile_Launcher, (int)LauncherCommandType.Up] = LauncherCommand.THU_UP;
            CommandList[(int)LauncherType.Thunder_Missile_Launcher, (int)LauncherCommandType.Left] = LauncherCommand.THU_LEFT;
            CommandList[(int)LauncherType.Thunder_Missile_Launcher, (int)LauncherCommandType.Down] = LauncherCommand.THU_DOWN;
            CommandList[(int)LauncherType.Thunder_Missile_Launcher, (int)LauncherCommandType.Right] = LauncherCommand.THU_RIGHT;
            CommandList[(int)LauncherType.Thunder_Missile_Launcher, (int)LauncherCommandType.Fire] = LauncherCommand.THU_FIRE;
            CommandList[(int)LauncherType.Thunder_Missile_Launcher, (int)LauncherCommandType.Stop] = LauncherCommand.THU_STOP;
            CommandList[(int)LauncherType.Thunder_Missile_Launcher, (int)LauncherCommandType.Request] = LauncherCommand.THU_REQ;
        }
    }

    /// <summary>
    /// Diese Struktur beinhaltet die benötigten IDs,
    /// um eine Verbindung aufzubauen
    /// </summary>
    public struct LauncherID
    {
        public int VendorID;
        public int ProductID;
    }

    /// <summary>
    /// Hilfsklasse für die Connect()-Methode
    /// Das Array IDList enthält für jeden Raketenwerfertyp alle benötigten IDs.
    /// </summary>
    public static class LauncherIDList
    {
        public static LauncherID[] IDList;

        static LauncherIDList()
        {
            IDList = new LauncherID[(int)LauncherType.Count];

            IDList[(int)LauncherType.MSN_Missile_Launcher].VendorID = 0x0a81;
            IDList[(int)LauncherType.MSN_Missile_Launcher].ProductID = 0x0701;

            IDList[(int)LauncherType.Thunder_Missile_Launcher].VendorID = 0x2123;
            IDList[(int)LauncherType.Thunder_Missile_Launcher].ProductID = 0x1010;

            IDList[(int)LauncherType.c_enter_Missile_Launcher].VendorID = 0x0416;
            IDList[(int)LauncherType.c_enter_Missile_Launcher].ProductID = 0x9391;
        }
    }
}