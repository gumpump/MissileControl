namespace MissileControl
{
	public struct ReadConstants
	{
		public const int FULL_LEFT				= 0x4; //in second byte
		public const int FULL_RIGHT				= 0x8; //in second byte
		public const int FULL_DOWN				= 0x40; //in first byte
		public const int FULL_UP				= 0x80; //in first byte
		public const int PRIME_DONE				= 0x80; //in second byte
		public const int FULL_LEFT_PRIME_DONE	= 0x84; //in second byte 
		public const int FULL_RIGHT_PRIME_DONE	= 0x88; //in second byte
	}

	public enum Status
	{
		Normal			= 0,
		FullDown,
		FullUp,
		FullLeft,
		FullRight,
		DonePriming,
		DoneFiring,
		Count,
		Unknown			= -1
	}
}