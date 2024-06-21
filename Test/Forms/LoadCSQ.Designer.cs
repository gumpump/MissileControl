namespace MissileControl.Forms
{
    partial class LoadCSQ
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			this.ScriptListbox = new System.Windows.Forms.ListBox();
			this.ButtonChoose = new System.Windows.Forms.Button();
			this.ButtonLoad = new System.Windows.Forms.Button();
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// ScriptListbox
			// 
			this.ScriptListbox.FormattingEnabled = true;
			this.ScriptListbox.HorizontalScrollbar = true;
			this.ScriptListbox.Location = new System.Drawing.Point(14, 12);
			this.ScriptListbox.Name = "ScriptListbox";
			this.ScriptListbox.Size = new System.Drawing.Size(252, 147);
			this.ScriptListbox.TabIndex = 0;
			// 
			// ButtonChoose
			// 
			this.ButtonChoose.Location = new System.Drawing.Point(14, 169);
			this.ButtonChoose.Name = "ButtonChoose";
			this.ButtonChoose.Size = new System.Drawing.Size(80, 25);
			this.ButtonChoose.TabIndex = 1;
			this.ButtonChoose.Text = "Choose";
			this.ButtonChoose.UseVisualStyleBackColor = true;
			this.ButtonChoose.Click += new System.EventHandler(this.ButtonChoose_Click);
			// 
			// ButtonLoad
			// 
			this.ButtonLoad.Location = new System.Drawing.Point(100, 169);
			this.ButtonLoad.Name = "ButtonLoad";
			this.ButtonLoad.Size = new System.Drawing.Size(80, 25);
			this.ButtonLoad.TabIndex = 2;
			this.ButtonLoad.Text = "Load";
			this.ButtonLoad.UseVisualStyleBackColor = true;
			this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.Location = new System.Drawing.Point(186, 169);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new System.Drawing.Size(80, 25);
			this.ButtonCancel.TabIndex = 3;
			this.ButtonCancel.Text = "Cancel";
			this.ButtonCancel.UseVisualStyleBackColor = true;
			this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "Sequence";
			this.openFileDialog1.Filter = "Sequence files *.mls|*.mls";
			// 
			// LoadCSQ
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 206);
			this.Controls.Add(this.ButtonCancel);
			this.Controls.Add(this.ButtonLoad);
			this.Controls.Add(this.ButtonChoose);
			this.Controls.Add(this.ScriptListbox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "LoadCSQ";
			this.Text = "Load commando sequence";
			this.ResumeLayout(false);

        }

		void ButtonCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		void ButtonLoad_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DialogResult Result = openFileDialog1.ShowDialog();
			if (Result == System.Windows.Forms.DialogResult.OK)
			{
				CommandoSeqQueue CSQ = ParseScript(openFileDialog1.FileName);

				if (CSQ == null)
				{
					System.Windows.Forms.MessageBox.Show("Datei kann nicht geladen werden");
				}

				else
				{
					CSQ.Launcher_Name = Launcher_Name;
					CSQ.Launcher_ID = Launcher_ID;
					CSQ.Name = openFileDialog1.SafeFileName;
					Scriptlist.Add(CSQ);
					ScriptListbox.Items.Add(CSQ.Name);
				}
			}
		}

		void ButtonChoose_Click(object sender, System.EventArgs e)
		{
			if (ScriptListbox.Items.Count > 0 && ScriptListbox.SelectedIndex != -1)
			{
				Index = ScriptListbox.SelectedIndex;

				if (Scriptlist[Index].Launcher_ID != null)
				{
					Scriptlist[Index].Launcher_ID = Launcher_ID;
					string Temp = ScriptListbox.SelectedItem.ToString();
					Temp += " | " + Launcher_Name;
					ScriptListbox.Items.RemoveAt(Index);
					ScriptListbox.Items.Insert(Index, Temp);
				}

				else
				{
					System.Windows.Forms.MessageBox.Show("This script is blocked by another launcher");
				}
			}

			else
			{
				System.Windows.Forms.MessageBox.Show("You have to choose one of the scripts");
			}
		}

        #endregion

		private void InitMyOwnThings()
		{
			Index = -1;
		}

		public void SetCSQList(System.Collections.Generic.List<CommandoSeqQueue> CSQL)
		{
			this.Scriptlist = CSQL;

			if (Scriptlist != null)
			{
				foreach (CommandoSeqQueue CSQ in Scriptlist)
				{
					if (CSQ.Launcher_ID != null)
					{
						string Temp;
						Temp = CSQ.Name;
						Temp = Temp + " | " + CSQ.Launcher_Name;
						ScriptListbox.Items.Add(Temp);
					}

					else
					{
						ScriptListbox.Items.Add(CSQ.Name);
					}
				}
			}
		}

		public System.Collections.Generic.List<CommandoSeqQueue> GetCSQList()
		{
			return Scriptlist;
		}

		private CommandoSeqQueue ParseScript(string Filename)
		{
			string[] Script = System.IO.File.ReadAllLines(Filename);
			CommandoSeqQueue CSQ = new CommandoSeqQueue();
			CommandoSeq CS;
			int i;

			foreach (string s in Script)
			{
				bool R = int.TryParse(s, out i);

				switch (R)
				{
					case (true):
					{
						CS = new CommandoSeq();
						CS.Type = LauncherCommandType.Timer;
						CS.Milliseconds = i;
						CSQ.PushIn(CS);
					} break;

					case (false):
					{
						switch (s)
						{
							case ("Left"):
							{
								CS = new CommandoSeq();
								CS.Type = LauncherCommandType.Left;
								CSQ.PushIn(CS);
							} break;

							case ("Up"):
							{
								CS = new CommandoSeq();
								CS.Type = LauncherCommandType.Up;
								CSQ.PushIn(CS);
							} break;

							case ("Right"):
							{
								CS = new CommandoSeq();
								CS.Type = LauncherCommandType.Right;
								CSQ.PushIn(CS);
							} break;

							case ("Down"):
							{
								CS = new CommandoSeq();
								CS.Type = LauncherCommandType.Down;
								CSQ.PushIn(CS);
							} break;

							case ("Stop"):
							{
								CS = new CommandoSeq();
								CS.Type = LauncherCommandType.Stop;
								CSQ.PushIn(CS);
							} break;

							case ("Fire"):
							{
								CS = new CommandoSeq();
								CS.Type = LauncherCommandType.Fire;
								CSQ.PushIn(CS);
							} break;
						}
					} break;
				}
			}

			CSQ.Save();

			if (CSQ.GetQueue().Count > 0)
			{
				return CSQ;
			}

			else
			{
				return null;
			}
		}

		public int GetIndex()
		{
			return Index;
		}

		public void SetLauncherData(string Name, string ID)
		{
			Launcher_Name = Name;
			Launcher_ID = ID;
		}

		private System.Windows.Forms.ListBox ScriptListbox;
		private System.Windows.Forms.Button ButtonChoose;
		private System.Windows.Forms.Button ButtonLoad;
		private System.Windows.Forms.Button ButtonCancel;
		private System.Collections.Generic.List<CommandoSeqQueue> Scriptlist;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private int Index;
		private string Launcher_Name;
		private string Launcher_ID;
    }
}