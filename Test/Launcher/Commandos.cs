using System.Collections;
using System.Timers;

namespace MissileControl
{
	/// <summary>
	/// Grundstruktur, die einen einzelnen Schritt
	/// einer Kommandosequenz darstellt
	/// </summary>
	public struct CommandoSeq
	{
		public LauncherCommandType Type;
		public int Milliseconds;
	}

	/// <summary>
	/// Kommando-Queue: First In, First Out
	/// </summary>
	public class CommandoSeqQueue
	{
		private Queue TempQueue;
		private Queue SavedQueue;
		public string Name;
		public string Launcher_ID;
		public string Launcher_Name;

		public void PushIn(CommandoSeq CS)
		{
			if (this.TempQueue == null)
			{
				TempQueue = new Queue();
			}

			TempQueue.Enqueue(CS);
		}

		public void Save()
		{
			SavedQueue = TempQueue.Clone() as Queue;
		}

		public Queue GetQueue()
		{
			return SavedQueue.Clone() as Queue;
		}
	}
}