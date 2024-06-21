//#define OPEN_VER

namespace MissileControl
{
    partial class MainWindow
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
            StopMyOwnThings();

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        #region Dateninitialisierung

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.Panel_List = new System.Windows.Forms.Panel();
			this.Label_Missile = new System.Windows.Forms.Label();
			this.Label_Webcam = new System.Windows.Forms.Label();
			this.Launcherlistbox = new System.Windows.Forms.CheckedListBox();
			this.Webcamlistbox = new MissileControl.ListboxDD();
			this.Panel_Control = new System.Windows.Forms.Panel();
			this.Label_Display = new System.Windows.Forms.Label();
			this.Button_About = new System.Windows.Forms.Button();
			this.buttonFire = new System.Windows.Forms.Button();
			this.buttonRight = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.buttonLeft = new System.Windows.Forms.Button();
			this.buttonUp = new System.Windows.Forms.Button();
			this.Display6 = new System.Windows.Forms.RadioButton();
			this.Display5 = new System.Windows.Forms.RadioButton();
			this.Display4 = new System.Windows.Forms.RadioButton();
			this.Display3 = new System.Windows.Forms.RadioButton();
			this.Display2 = new System.Windows.Forms.RadioButton();
			this.Display1 = new System.Windows.Forms.RadioButton();
			this.Button_Settings = new System.Windows.Forms.Button();
			this.TargetingCheckBox = new System.Windows.Forms.CheckBox();
			this.Panel_Webcam = new System.Windows.Forms.Panel();
			this.Panel_Target = new System.Windows.Forms.Panel();
			this.TargetColorPanel = new System.Windows.Forms.Panel();
			this.ContextMenuLauncher = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.loadExistingCommandoListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.startScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Panel_List.SuspendLayout();
			this.Panel_Control.SuspendLayout();
			this.Panel_Target.SuspendLayout();
			this.ContextMenuLauncher.SuspendLayout();
			this.SuspendLayout();
			// 
			// Panel_List
			// 
			this.Panel_List.AllowDrop = true;
			this.Panel_List.BackColor = System.Drawing.Color.Gainsboro;
			this.Panel_List.Controls.Add(this.Label_Missile);
			this.Panel_List.Controls.Add(this.Label_Webcam);
			this.Panel_List.Controls.Add(this.Launcherlistbox);
			this.Panel_List.Controls.Add(this.Webcamlistbox);
			this.Panel_List.Location = new System.Drawing.Point(12, 12);
			this.Panel_List.Name = "Panel_List";
			this.Panel_List.Size = new System.Drawing.Size(176, 538);
			this.Panel_List.TabIndex = 0;
			// 
			// Label_Missile
			// 
			this.Label_Missile.AllowDrop = true;
			this.Label_Missile.AutoSize = true;
			this.Label_Missile.Location = new System.Drawing.Point(3, 290);
			this.Label_Missile.Name = "Label_Missile";
			this.Label_Missile.Size = new System.Drawing.Size(97, 13);
			this.Label_Missile.TabIndex = 3;
			this.Label_Missile.Text = "Missile launcher list";
			// 
			// Label_Webcam
			// 
			this.Label_Webcam.AllowDrop = true;
			this.Label_Webcam.AutoSize = true;
			this.Label_Webcam.Location = new System.Drawing.Point(3, 20);
			this.Label_Webcam.Name = "Label_Webcam";
			this.Label_Webcam.Size = new System.Drawing.Size(65, 13);
			this.Label_Webcam.TabIndex = 2;
			this.Label_Webcam.Text = "Webcam list";
			// 
			// Launcherlistbox
			// 
			this.Launcherlistbox.AllowDrop = true;
			this.Launcherlistbox.FormattingEnabled = true;
			this.Launcherlistbox.Location = new System.Drawing.Point(3, 306);
			this.Launcherlistbox.Name = "Launcherlistbox";
			this.Launcherlistbox.Size = new System.Drawing.Size(170, 214);
			this.Launcherlistbox.TabIndex = 1;
			this.Launcherlistbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Raketenwerferlistbox_ItemCheck);
			this.Launcherlistbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcherlistbox_MouseDown);
			// 
			// Webcamlistbox
			// 
			this.Webcamlistbox.AllowDrop = true;
			this.Webcamlistbox.FormattingEnabled = true;
			this.Webcamlistbox.Location = new System.Drawing.Point(3, 36);
			this.Webcamlistbox.Name = "Webcamlistbox";
			this.Webcamlistbox.Size = new System.Drawing.Size(170, 214);
			this.Webcamlistbox.TabIndex = 0;
			// 
			// Panel_Control
			// 
			this.Panel_Control.AllowDrop = true;
			this.Panel_Control.BackColor = System.Drawing.Color.Gainsboro;
			this.Panel_Control.Controls.Add(this.Label_Display);
			this.Panel_Control.Controls.Add(this.Button_About);
			this.Panel_Control.Controls.Add(this.buttonFire);
			this.Panel_Control.Controls.Add(this.buttonRight);
			this.Panel_Control.Controls.Add(this.buttonDown);
			this.Panel_Control.Controls.Add(this.buttonLeft);
			this.Panel_Control.Controls.Add(this.buttonUp);
			this.Panel_Control.Controls.Add(this.Display6);
			this.Panel_Control.Controls.Add(this.Display5);
			this.Panel_Control.Controls.Add(this.Display4);
			this.Panel_Control.Controls.Add(this.Display3);
			this.Panel_Control.Controls.Add(this.Display2);
			this.Panel_Control.Controls.Add(this.Display1);
			this.Panel_Control.Location = new System.Drawing.Point(194, 406);
			this.Panel_Control.Name = "Panel_Control";
			this.Panel_Control.Size = new System.Drawing.Size(578, 144);
			this.Panel_Control.TabIndex = 1;
			// 
			// Label_Display
			// 
			this.Label_Display.AutoSize = true;
			this.Label_Display.Location = new System.Drawing.Point(181, 7);
			this.Label_Display.Name = "Label_Display";
			this.Label_Display.Size = new System.Drawing.Size(96, 13);
			this.Label_Display.TabIndex = 11;
			this.Label_Display.Text = "Number of displays";
			// 
			// Button_About
			// 
			this.Button_About.Location = new System.Drawing.Point(184, 95);
			this.Button_About.Name = "Button_About";
			this.Button_About.Size = new System.Drawing.Size(93, 36);
			this.Button_About.TabIndex = 10;
			this.Button_About.Text = "About";
			this.Button_About.UseVisualStyleBackColor = true;
			this.Button_About.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonFire
			// 
			this.buttonFire.AllowDrop = true;
			this.buttonFire.Image = global::MissileControl.Properties.Resources.Fire;
			this.buttonFire.Location = new System.Drawing.Point(51, 51);
			this.buttonFire.Name = "buttonFire";
			this.buttonFire.Size = new System.Drawing.Size(40, 40);
			this.buttonFire.TabIndex = 9;
			this.buttonFire.TabStop = false;
			this.buttonFire.UseVisualStyleBackColor = true;
			this.buttonFire.Click += new System.EventHandler(this.buttonFire_Click);
			// 
			// buttonRight
			// 
			this.buttonRight.AllowDrop = true;
			this.buttonRight.Image = global::MissileControl.Properties.Resources.Right;
			this.buttonRight.Location = new System.Drawing.Point(91, 51);
			this.buttonRight.Name = "buttonRight";
			this.buttonRight.Size = new System.Drawing.Size(40, 40);
			this.buttonRight.TabIndex = 8;
			this.buttonRight.TabStop = false;
			this.buttonRight.UseVisualStyleBackColor = true;
			this.buttonRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonRight_MouseDown);
			this.buttonRight.MouseLeave += new System.EventHandler(this.buttonRight_MouseLeave);
			this.buttonRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonRight_MouseUp);
			// 
			// buttonDown
			// 
			this.buttonDown.AllowDrop = true;
			this.buttonDown.Image = global::MissileControl.Properties.Resources.Down;
			this.buttonDown.Location = new System.Drawing.Point(51, 91);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(40, 40);
			this.buttonDown.TabIndex = 7;
			this.buttonDown.TabStop = false;
			this.buttonDown.UseVisualStyleBackColor = true;
			this.buttonDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDown_MouseDown);
			this.buttonDown.MouseLeave += new System.EventHandler(this.buttonDown_MouseLeave);
			this.buttonDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonDown_MouseUp);
			// 
			// buttonLeft
			// 
			this.buttonLeft.AllowDrop = true;
			this.buttonLeft.Image = global::MissileControl.Properties.Resources.Left;
			this.buttonLeft.Location = new System.Drawing.Point(11, 51);
			this.buttonLeft.Name = "buttonLeft";
			this.buttonLeft.Size = new System.Drawing.Size(40, 40);
			this.buttonLeft.TabIndex = 6;
			this.buttonLeft.TabStop = false;
			this.buttonLeft.UseVisualStyleBackColor = true;
			this.buttonLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonLeft_MouseDown);
			this.buttonLeft.MouseLeave += new System.EventHandler(this.buttonLeft_MouseLeave);
			this.buttonLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonLeft_MouseUp);
			// 
			// buttonUp
			// 
			this.buttonUp.AllowDrop = true;
			this.buttonUp.Image = global::MissileControl.Properties.Resources.Up;
			this.buttonUp.Location = new System.Drawing.Point(51, 11);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(40, 40);
			this.buttonUp.TabIndex = 0;
			this.buttonUp.TabStop = false;
			this.buttonUp.UseVisualStyleBackColor = true;
			this.buttonUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonUp_MouseDown);
			this.buttonUp.MouseLeave += new System.EventHandler(this.buttonUp_MouseLeave);
			this.buttonUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonUp_MouseUp);
			// 
			// Display6
			// 
			this.Display6.AllowDrop = true;
			this.Display6.AutoSize = true;
			this.Display6.Location = new System.Drawing.Point(231, 69);
			this.Display6.Name = "Display6";
			this.Display6.Size = new System.Drawing.Size(31, 17);
			this.Display6.TabIndex = 5;
			this.Display6.TabStop = true;
			this.Display6.Text = "6";
			this.Display6.UseVisualStyleBackColor = true;
			this.Display6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
			// 
			// Display5
			// 
			this.Display5.AllowDrop = true;
			this.Display5.AutoSize = true;
			this.Display5.Location = new System.Drawing.Point(194, 69);
			this.Display5.Name = "Display5";
			this.Display5.Size = new System.Drawing.Size(31, 17);
			this.Display5.TabIndex = 4;
			this.Display5.TabStop = true;
			this.Display5.Text = "5";
			this.Display5.UseVisualStyleBackColor = true;
			this.Display5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
			// 
			// Display4
			// 
			this.Display4.AllowDrop = true;
			this.Display4.AutoSize = true;
			this.Display4.Location = new System.Drawing.Point(231, 46);
			this.Display4.Name = "Display4";
			this.Display4.Size = new System.Drawing.Size(31, 17);
			this.Display4.TabIndex = 3;
			this.Display4.TabStop = true;
			this.Display4.Text = "4";
			this.Display4.UseVisualStyleBackColor = true;
			this.Display4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// Display3
			// 
			this.Display3.AllowDrop = true;
			this.Display3.AutoSize = true;
			this.Display3.Location = new System.Drawing.Point(194, 46);
			this.Display3.Name = "Display3";
			this.Display3.Size = new System.Drawing.Size(31, 17);
			this.Display3.TabIndex = 2;
			this.Display3.TabStop = true;
			this.Display3.Text = "3";
			this.Display3.UseVisualStyleBackColor = true;
			this.Display3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// Display2
			// 
			this.Display2.AllowDrop = true;
			this.Display2.AutoSize = true;
			this.Display2.Location = new System.Drawing.Point(231, 23);
			this.Display2.Name = "Display2";
			this.Display2.Size = new System.Drawing.Size(31, 17);
			this.Display2.TabIndex = 1;
			this.Display2.TabStop = true;
			this.Display2.Text = "2";
			this.Display2.UseVisualStyleBackColor = true;
			this.Display2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// Display1
			// 
			this.Display1.AllowDrop = true;
			this.Display1.AutoSize = true;
			this.Display1.Location = new System.Drawing.Point(194, 23);
			this.Display1.Name = "Display1";
			this.Display1.Size = new System.Drawing.Size(31, 17);
			this.Display1.TabIndex = 0;
			this.Display1.TabStop = true;
			this.Display1.Text = "1";
			this.Display1.UseVisualStyleBackColor = true;
			this.Display1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// Button_Settings
			// 
			this.Button_Settings.Location = new System.Drawing.Point(117, 0);
			this.Button_Settings.Name = "Button_Settings";
			this.Button_Settings.Size = new System.Drawing.Size(89, 23);
			this.Button_Settings.TabIndex = 12;
			this.Button_Settings.Text = "Settings";
			this.Button_Settings.UseVisualStyleBackColor = true;
			this.Button_Settings.Click += new System.EventHandler(this.EinstellungenButton_Click);
			// 
			// TargetingCheckBox
			// 
			this.TargetingCheckBox.AutoSize = true;
			this.TargetingCheckBox.Location = new System.Drawing.Point(3, 3);
			this.TargetingCheckBox.Name = "TargetingCheckBox";
			this.TargetingCheckBox.Size = new System.Drawing.Size(95, 17);
			this.TargetingCheckBox.TabIndex = 11;
			this.TargetingCheckBox.Text = "Target tagging";
			this.TargetingCheckBox.UseVisualStyleBackColor = true;
			this.TargetingCheckBox.CheckedChanged += new System.EventHandler(this.ZielerkennungCheckBox_CheckedChanged);
			// 
			// Panel_Webcam
			// 
			this.Panel_Webcam.AllowDrop = true;
			this.Panel_Webcam.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Panel_Webcam.Location = new System.Drawing.Point(194, 41);
			this.Panel_Webcam.Name = "Panel_Webcam";
			this.Panel_Webcam.Size = new System.Drawing.Size(578, 354);
			this.Panel_Webcam.TabIndex = 2;
			this.Panel_Webcam.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel3_DragDrop);
			this.Panel_Webcam.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel3_DragEnter);
			// 
			// Panel_Target
			// 
			this.Panel_Target.AllowDrop = true;
			this.Panel_Target.BackColor = System.Drawing.Color.Gainsboro;
			this.Panel_Target.Controls.Add(this.TargetColorPanel);
			this.Panel_Target.Controls.Add(this.Button_Settings);
			this.Panel_Target.Controls.Add(this.TargetingCheckBox);
			this.Panel_Target.Location = new System.Drawing.Point(194, 12);
			this.Panel_Target.Name = "Panel_Target";
			this.Panel_Target.Size = new System.Drawing.Size(578, 23);
			this.Panel_Target.TabIndex = 3;
			// 
			// TargetColorPanel
			// 
			this.TargetColorPanel.BackColor = System.Drawing.Color.White;
			this.TargetColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.TargetColorPanel.Location = new System.Drawing.Point(224, 2);
			this.TargetColorPanel.Name = "TargetColorPanel";
			this.TargetColorPanel.Size = new System.Drawing.Size(161, 19);
			this.TargetColorPanel.TabIndex = 13;
			this.TargetColorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ZielfarbePanel_Paint);
			// 
			// ContextMenuLauncher
			// 
			this.ContextMenuLauncher.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.ContextMenuLauncher.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadExistingCommandoListToolStripMenuItem,
            this.startScriptToolStripMenuItem});
			this.ContextMenuLauncher.Name = "ContextMenuLauncher";
			this.ContextMenuLauncher.Size = new System.Drawing.Size(184, 48);
			// 
			// loadExistingCommandoListToolStripMenuItem
			// 
			this.loadExistingCommandoListToolStripMenuItem.Name = "loadExistingCommandoListToolStripMenuItem";
			this.loadExistingCommandoListToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.loadExistingCommandoListToolStripMenuItem.Text = "Load commando list";
			this.loadExistingCommandoListToolStripMenuItem.Click += new System.EventHandler(this.loadExistingCommandoListToolStripMenuItem_Click);
			// 
			// startScriptToolStripMenuItem
			// 
			this.startScriptToolStripMenuItem.Name = "startScriptToolStripMenuItem";
			this.startScriptToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.startScriptToolStripMenuItem.Text = "Start script";
			this.startScriptToolStripMenuItem.Click += new System.EventHandler(this.startScriptToolStripMenuItem_Click);
			// 
			// MainWindow
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Menu;
			this.ClientSize = new System.Drawing.Size(784, 558);
			this.Controls.Add(this.Panel_Target);
			this.Controls.Add(this.Panel_Webcam);
			this.Controls.Add(this.Panel_Control);
			this.Controls.Add(this.Panel_List);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.Text = "MissileControl";
			this.Activated += new System.EventHandler(this.MainWindow_Activated);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyUp);
			this.Panel_List.ResumeLayout(false);
			this.Panel_List.PerformLayout();
			this.Panel_Control.ResumeLayout(false);
			this.Panel_Control.PerformLayout();
			this.Panel_Target.ResumeLayout(false);
			this.Panel_Target.PerformLayout();
			this.ContextMenuLauncher.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		void MainWindow_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case System.Windows.Forms.Keys.F8:
				{
					SetWndToWebcam();
				} break;

				case System.Windows.Forms.Keys.F9:
				{
					SetWndToLauncher();
				} break;
			}
		}

		void startScriptToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			LauncherList[Launcherlistbox.SelectedIndex].StartSequence();
		}

        void loadExistingCommandoListToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Forms.LoadCSQ Wnd = new Forms.LoadCSQ();
			Wnd.SetCSQList(CSQList);
			Wnd.SetLauncherData(Launcherlistbox.SelectedItem.ToString(),
								LauncherList[Launcherlistbox.SelectedIndex].GetID());
            Wnd.ShowDialog();
			CSQList = Wnd.GetCSQList();
			int i = Wnd.GetIndex();
			if (i == -1)
			{
				return;
			}
			LauncherList[Launcherlistbox.SelectedIndex].SetCommandoSeq(CSQList[i]);
        }

        void Launcherlistbox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                System.Drawing.Point P = new System.Drawing.Point(e.X, e.Y);

                int i = Launcherlistbox.IndexFromPoint(P);

                if (i != System.Windows.Forms.ListBox.NoMatches)
                {
                    Launcherlistbox.SelectedIndex = i;
                    ContextMenuLauncher.Show(Launcherlistbox.PointToScreen(P));
                }
            }
        }

        void MainWindow_Activated(object sender, System.EventArgs e)
        {
            if (TotalDestruction == true)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        void ZielfarbePanel_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            if (e.ClipRectangle != null
				&& e.ClipRectangle.Width > 0
				&& e.ClipRectangle.Height > 0)
            {
                System.Drawing.Drawing2D.LinearGradientBrush Brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.ClipRectangle,
                                                                                                                      this.TargetColorU,
                                                                                                                      this.TargetColorO,
                                                                                                                      45.0f);

                e.Graphics.FillRectangle(Brush, e.ClipRectangle);
            }
        }

        void EinstellungenButton_Click(object sender, System.EventArgs e)
        {
            Forms.Zielerkennung Wnd = new Forms.Zielerkennung();
            Wnd.SetColor(this.TargetColorU, this.TargetColorO);
            Wnd.ShowDialog();
            Wnd.GetColor(out this.TargetColorU, out this.TargetColorO);
            ColorFilter.Red     = new AForge.IntRange(this.TargetColorU.R, this.TargetColorO.R);
            ColorFilter.Green   = new AForge.IntRange(this.TargetColorU.G, this.TargetColorO.G);
            ColorFilter.Blue    = new AForge.IntRange(this.TargetColorU.B, this.TargetColorO.B);
            TargetColorPanel.Refresh();
        }

        void ZielerkennungCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            Button_Settings.Enabled = TargetingCheckBox.Checked;
            System.Console.WriteLine("Zielerkennung: " + TargetingCheckBox.Checked.ToString());
        }

        void button1_Click(object sender, System.EventArgs e)
        {
            Forms.About_Box Wnd = new Forms.About_Box();
            Wnd.ShowDialog();
        }

        void Raketenwerferlistbox_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
        {
            if (e.NewValue == System.Windows.Forms.CheckState.Checked)
            {
                this.LauncherList[e.Index].Active = true;
            }

            else
            {
                this.LauncherList[e.Index].Active = false;
            }
        }

        void panel3_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            System.Console.WriteLine("Allowed effect: " + e.AllowedEffect.ToString());
            e.Effect = System.Windows.Forms.DragDropEffects.Copy;
            System.Console.WriteLine("Effect: " + e.Effect.ToString());
        }

        void panel3_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            for (int i = 0; i < this.Panel_Webcam.Controls.Count; i++)
            {
                int X = this.Location.X + this.Panel_Webcam.Location.X + this.Panel_Webcam.Controls[i].Location.X;
                int Y = this.Location.Y + this.Panel_Webcam.Location.Y + this.Panel_Webcam.Controls[i].Location.Y;
                System.Drawing.Point p1 = new System.Drawing.Point(X, Y);
                int Width = this.Panel_Webcam.Controls[i].Width;
                int Height = this.Panel_Webcam.Controls[i].Height;

                if (e.X > p1.X
                    && e.X < p1.X + Width
                    && e.Y > p1.Y
                    && e.Y < p1.Y + Height)
                {
                    try
                    {
                        if (((PictureboxDD)this.Panel_Webcam.Controls[i]).WebcamNr != -1)
                        {
                            this.WebcamList[((PictureboxDD)this.Panel_Webcam.Controls[i]).WebcamNr].Stop();
                        }
                        ((PictureboxDD)this.Panel_Webcam.Controls[i]).WebcamNr = this.Webcamlistbox.SelectedIndex;
                        this.WebcamList[((PictureboxDD)this.Panel_Webcam.Controls[i]).WebcamNr].Start();
                        System.Console.WriteLine("Webcam " + this.Webcamlistbox.SelectedIndex
                                                 + " is set to " + this.Panel_Webcam.Controls[i].Name.ToString());
                    }

                    catch (System.Exception ex)
                    {
                        System.Console.WriteLine(ex.ToString());
                    }
                }
            }
        }

        #endregion

        #region Raketenwerferbuttons

        void buttonUp_MouseLeave(object sender, System.EventArgs e)
        {
            SendCommand(LauncherCommandType.Stop);
        }

        void buttonLeft_MouseLeave(object sender, System.EventArgs e)
        {
            SendCommand(LauncherCommandType.Stop);
        }

        void buttonDown_MouseLeave(object sender, System.EventArgs e)
        {
            SendCommand(LauncherCommandType.Stop);
        }

        void buttonUp_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            SendCommand(LauncherCommandType.Stop);
        }

        void buttonLeft_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            SendCommand(LauncherCommandType.Stop);
        }

        void buttonDown_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            SendCommand(LauncherCommandType.Stop);
        }

        void buttonUp_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            SendCommand(LauncherCommandType.Up);
        }

        void buttonLeft_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            SendCommand(LauncherCommandType.Left);
        }

        void buttonDown_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            SendCommand(LauncherCommandType.Down);
        }

        void buttonRight_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            SendCommand(LauncherCommandType.Right);
        }

        void buttonRight_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            SendCommand(LauncherCommandType.Stop);
        }

        void buttonRight_MouseLeave(object sender, System.EventArgs e)
        {
            SendCommand(LauncherCommandType.Stop);
        }

        void buttonFire_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < this.LauncherList.Count; i++)
            {
                LauncherList[i].Fire();
            }
        }

        #endregion

        #region Radiobuttons

        void radioButton6_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.Display6.Checked == true)
            {
                System.Console.WriteLine("Set \"Auswahl 6\"");
                this.Panel_Webcam.Controls.Clear();

                MissileControl.PictureboxDD P1 = new MissileControl.PictureboxDD();
                P1.Location = new System.Drawing.Point(0, 0);
                P1.Size = new System.Drawing.Size(289, 118);
                P1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                P1.WebcamNr = -1;
                P1.Name = "PicBox1";
                P1.TabIndex = 0;
                P1.TabStop = false;
                this.Panel_Webcam.Controls.Add(P1);

                MissileControl.PictureboxDD P2 = new MissileControl.PictureboxDD();
                P2.Location = new System.Drawing.Point(289, 0);
                P2.Size = new System.Drawing.Size(289, 118);
                P2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                P2.WebcamNr = -1;
                P2.Name = "PicBox2";
                P2.TabIndex = 0;
                P2.TabStop = false;
                this.Panel_Webcam.Controls.Add(P2);

                MissileControl.PictureboxDD P3 = new MissileControl.PictureboxDD();
                P3.Location = new System.Drawing.Point(0, 118);
                P3.Size = new System.Drawing.Size(289, 118);
                P3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                P3.WebcamNr = -1;
                P3.Name = "PicBox3";
                P3.TabIndex = 0;
                P3.TabStop = false;
                this.Panel_Webcam.Controls.Add(P3);

                MissileControl.PictureboxDD P4 = new MissileControl.PictureboxDD();
                P4.Location = new System.Drawing.Point(289, 118);
                P4.Size = new System.Drawing.Size(289, 118);
                P4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                P4.WebcamNr = -1;
                P4.Name = "PicBox4";
                P4.TabIndex = 0;
                P4.TabStop = false;
                this.Panel_Webcam.Controls.Add(P4);

                MissileControl.PictureboxDD P5 = new MissileControl.PictureboxDD();
                P5.Location = new System.Drawing.Point(0, 236);
                P5.Size = new System.Drawing.Size(289, 118);
                P5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                P5.WebcamNr = -1;
                P5.Name = "PicBox5";
                P5.TabIndex = 0;
                P5.TabStop = false;
                this.Panel_Webcam.Controls.Add(P5);

                MissileControl.PictureboxDD P6 = new MissileControl.PictureboxDD();
                P6.Location = new System.Drawing.Point(289, 236);
                P6.Size = new System.Drawing.Size(289, 118);
                P6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                P6.WebcamNr = -1;
                P6.Name = "PicBox6";
                P6.TabIndex = 0;
                P6.TabStop = false;
                this.Panel_Webcam.Controls.Add(P6);

                this.Panel_Webcam.AllowDrop = true;
            }
        }

        void radioButton5_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.Display5.Checked == true)
            {
                System.Console.WriteLine("Set \"Auswahl 5\"");
                this.Panel_Webcam.Controls.Clear();

                MissileControl.PictureboxDD P1 = new MissileControl.PictureboxDD();
                P1.Location = new System.Drawing.Point(0, 0);
                P1.Size = new System.Drawing.Size(289, 118);
                P1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                P1.WebcamNr = -1;
                P1.Name = "PicBox1";
                P1.TabIndex = 0;
                P1.TabStop = false;
                this.Panel_Webcam.Controls.Add(P1);

                MissileControl.PictureboxDD P2 = new MissileControl.PictureboxDD();
                P2.Location = new System.Drawing.Point(289, 0);
                P2.Size = new System.Drawing.Size(289, 118);
                P2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                P2.WebcamNr = -1;
                P2.Name = "PicBox2";
                P2.TabIndex = 0;
                P2.TabStop = false;
                this.Panel_Webcam.Controls.Add(P2);

                MissileControl.PictureboxDD P3 = new MissileControl.PictureboxDD();
                P3.Location = new System.Drawing.Point(0, 118);
                P3.Size = new System.Drawing.Size(289, 118);
                P3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                P3.WebcamNr = -1;
                P3.Name = "PicBox3";
                P3.TabIndex = 0;
                P3.TabStop = false;
                this.Panel_Webcam.Controls.Add(P3);

                MissileControl.PictureboxDD P4 = new MissileControl.PictureboxDD();
                P4.Location = new System.Drawing.Point(289, 118);
                P4.Size = new System.Drawing.Size(289, 118);
                P4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                P4.WebcamNr = -1;
                P4.Name = "PicBox4";
                P4.TabIndex = 0;
                P4.TabStop = false;
                this.Panel_Webcam.Controls.Add(P4);

                MissileControl.PictureboxDD P5 = new MissileControl.PictureboxDD();
                P5.Location = new System.Drawing.Point(0, 236);
                P5.Size = new System.Drawing.Size(578, 118);
                P5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                P5.WebcamNr = -1;
                P5.Name = "PicBox5";
                P5.TabIndex = 0;
                P5.TabStop = false;
                this.Panel_Webcam.Controls.Add(P5);

                this.Panel_Webcam.AllowDrop = true;
            }
        }

        void radioButton4_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.Display4.Checked == true)
            {
                System.Console.WriteLine("Set \"Auswahl 4\"");
                this.Panel_Webcam.Controls.Clear();

                MissileControl.PictureboxDD P1 = new MissileControl.PictureboxDD();
                P1.Location = new System.Drawing.Point(0, 0);
                P1.Size = new System.Drawing.Size(289, 177);
                P1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                P1.WebcamNr = -1;
                P1.Name = "PicBox1";
                P1.TabIndex = 0;
                P1.TabStop = false;
                this.Panel_Webcam.Controls.Add(P1);

                MissileControl.PictureboxDD P2 = new MissileControl.PictureboxDD();
                P2.Location = new System.Drawing.Point(289, 0);
                P2.Size = new System.Drawing.Size(289, 177);
                P2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                P2.WebcamNr = -1;
                P2.Name = "PicBox2";
                P2.TabIndex = 0;
                P2.TabStop = false;
                this.Panel_Webcam.Controls.Add(P2);

                MissileControl.PictureboxDD P3 = new MissileControl.PictureboxDD();
                P3.Location = new System.Drawing.Point(0, 177);
                P3.Size = new System.Drawing.Size(289, 177);
                P3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                P3.WebcamNr = -1;
                P3.Name = "PicBox3";
                P3.TabIndex = 0;
                P3.TabStop = false;
                this.Panel_Webcam.Controls.Add(P3);

                MissileControl.PictureboxDD P4 = new MissileControl.PictureboxDD();
                P4.Location = new System.Drawing.Point(289, 177);
                P4.Size = new System.Drawing.Size(289, 177);
                P4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                P4.WebcamNr = -1;
                P4.Name = "PicBox4";
                P4.TabIndex = 0;
                P4.TabStop = false;
                this.Panel_Webcam.Controls.Add(P4);

                this.Panel_Webcam.AllowDrop = true;
            }
        }

        void radioButton3_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.Display3.Checked == true)
            {
                System.Console.WriteLine("Set \"Auswahl 3\"");
                this.Panel_Webcam.Controls.Clear();

                MissileControl.PictureboxDD P1 = new MissileControl.PictureboxDD();
                P1.Location = new System.Drawing.Point(0, 0);
                P1.Size = new System.Drawing.Size(241, 177);
                P1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                P1.WebcamNr = -1;
                P1.Name = "PicBox1";
                P1.TabIndex = 0;
                P1.TabStop = false;
                this.Panel_Webcam.Controls.Add(P1);

                MissileControl.PictureboxDD P2 = new MissileControl.PictureboxDD();
                P2.Location = new System.Drawing.Point(0, 177);
                P2.Size = new System.Drawing.Size(241, 177);
                P2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                P2.WebcamNr = -1;
                P2.Name = "PicBox2";
                P2.TabIndex = 0;
                P2.TabStop = false;
                this.Panel_Webcam.Controls.Add(P2);

                MissileControl.PictureboxDD P3 = new MissileControl.PictureboxDD();
                P3.Location = new System.Drawing.Point(241, 0);
                P3.Size = new System.Drawing.Size(337, 354);
                P3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                P3.WebcamNr = -1;
                P3.Name = "PicBox3";
                P3.TabIndex = 0;
                P3.TabStop = false;
                this.Panel_Webcam.Controls.Add(P3);

                this.Panel_Webcam.AllowDrop = true;
            }
        }

        void radioButton2_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.Display2.Checked == true)
            {
                System.Console.WriteLine("Set \"Auswahl 2\"");
                this.Panel_Webcam.Controls.Clear();

                MissileControl.PictureboxDD P1 = new MissileControl.PictureboxDD();
                P1.Location = new System.Drawing.Point(0, 0);
                P1.Size = new System.Drawing.Size(578, 177);
                P1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                P1.WebcamNr = -1;
                P1.Name = "PicBox1";
                P1.TabIndex = 0;
                P1.TabStop = false;
                this.Panel_Webcam.Controls.Add(P1);

                MissileControl.PictureboxDD P2 = new MissileControl.PictureboxDD();
                P2.Location = new System.Drawing.Point(0, 177);
                P2.Size = new System.Drawing.Size(578, 177);
                P2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                P2.WebcamNr = -1;
                P2.Name = "PicBox2";
                P2.TabIndex = 0;
                P2.TabStop = false;
                this.Panel_Webcam.Controls.Add(P2);

                this.Panel_Webcam.AllowDrop = true;
            }
        }

        void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.Display1.Checked == true)
            {
                System.Console.WriteLine("Set \"Auswahl 1\"");
                this.Panel_Webcam.Controls.Clear();

                MissileControl.PictureboxDD P1 = new MissileControl.PictureboxDD();
                P1.Location = new System.Drawing.Point(0, 0);
                P1.Size = new System.Drawing.Size(578, 354);
                P1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                P1.WebcamNr = -1;
                P1.Name = "PicBox1";
                P1.TabIndex = 0;
                P1.TabStop = false;
                this.Panel_Webcam.Controls.Add(P1);

                this.Panel_Webcam.AllowDrop = true;
            }
        }

        #endregion

        #endregion

        void InitWebcams()
        {
            System.Console.WriteLine("Initialize webcams");
            this.WebcamList = new System.Collections.Generic.List<Webcam>();
            this.WebcamList.Clear();
            AForge.Video.DirectShow.FilterInfoCollection C = new AForge.Video.DirectShow.FilterInfoCollection(AForge.Video.DirectShow.FilterCategory.VideoInputDevice);
            System.Console.WriteLine("Add webcams to listbox");
            for (int i = 0; i < C.Count; i++)
            {
                Webcam W = new Webcam(C[i].MonikerString);
                this.WebcamList.Add(W);
                this.Webcamlistbox.Items.Add(C[i].Name);
                System.Console.WriteLine(C[i].Name);
            }

			if (TotalDestruction == false)
			{
				if (C.Count == 0 && LauncherList.Count == 0)
				{
					System.Windows.Forms.DialogResult R = System.Windows.Forms.MessageBox.Show("You have no launchers and you have no webcams. " +
																							   "Do you really want to start this program?",
																							   "Really?",
																							   System.Windows.Forms.MessageBoxButtons.YesNo);

					if (R == System.Windows.Forms.DialogResult.No)
					{
						TotalDestruction = true;
					}
				}
			}

            System.Console.WriteLine(C.Count.ToString() + " webcams added");

            if (this.WebcamList.Count > 0
                && this.Panel_Webcam.Controls.Count > 0)
            {
                this.TimerLock = false;
                System.Console.WriteLine("Start Timer-Thread UpdateWebcam");
                UpdateWebcams = new System.Timers.Timer(75);
                UpdateWebcams.AutoReset = true;
                UpdateWebcams.Elapsed += new System.Timers.ElapsedEventHandler(T_Elapsed);
                UpdateWebcams.Start();

                SetWndToWebcam();

                #if OPEN_VER

                    this.ZielerkennungCheckBox.Visible = false;
                    this.Button_Settings.Visible = false;
                    this.ZielfarbePanel.Visible = false;

                #endif

                System.Console.WriteLine("Initialize ColorFilter");
                ColorFilter = new AForge.Imaging.Filters.ColorFiltering();
                ColorFilter.Red = new AForge.IntRange(this.TargetColorU.R, this.TargetColorO.R);
                ColorFilter.Green = new AForge.IntRange(this.TargetColorU.G, this.TargetColorO.G);
                ColorFilter.Blue = new AForge.IntRange(this.TargetColorU.B, this.TargetColorO.B);
                System.Console.WriteLine("First Color: R = " + this.TargetColorU.R + ", "
                                         + "G = " + this.TargetColorU.G + ", "
                                         + "B = " + this.TargetColorU.B);
                System.Console.WriteLine("Second Color: R = " + this.TargetColorO.R + ", "
                                         + "G = " + this.TargetColorO.G + ", "
                                         + "B = " + this.TargetColorO.B);
                System.Console.WriteLine("Initialize GrayscaleFilter");
                GrayscaleFilter = AForge.Imaging.Filters.Grayscale.CommonAlgorithms.BT709;
                System.Console.WriteLine("Initialize BlobCounter");
                BlobCounter = new AForge.Imaging.BlobCounter();
                BlobCounter.MinWidth = 10;
                BlobCounter.MinHeight = 10;
                BlobCounter.MaxWidth = 50;
                BlobCounter.MaxHeight = 50;
                BlobCounter.FilterBlobs = true;
                System.Console.WriteLine("MinWidth = " + BlobCounter.MinWidth);
                System.Console.WriteLine("MinHeight = " + BlobCounter.MinHeight);
                System.Console.WriteLine("MaxWidth = " + BlobCounter.MaxWidth);
                System.Console.WriteLine("MaxHeight = " + BlobCounter.MaxHeight);
                System.Console.WriteLine("Initialize Pen");
                TargetPen = new System.Drawing.Pen(System.Drawing.Color.Red, 2);
                System.Console.WriteLine("Pen: " + TargetPen.Color.Name);
            }

            else
            {
                SetWndToLauncher();
            }
        }

        private void T_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            /*
             * TimerLock versperrt dem Timer-Thread den Zugriff
             * auf die Webcams, falls der Timer-Thread noch läuft,
             * damit das Programm nicht abschmiert
             */

            if (this.TimerLock == false) // WICHTIG!
            {
                this.TimerLock = true;
                for (int i = 0; i < this.Panel_Webcam.Controls.Count; i++)
                {
                    if (((PictureboxDD)this.Panel_Webcam.Controls[i]).WebcamNr > -1)
                    {
                        System.Drawing.Image Img = this.WebcamList[((PictureboxDD)this.Panel_Webcam.Controls[i]).WebcamNr].GetBitmap();

                        if (Img != null)
                        {
                            if (this.TargetingCheckBox.Checked == true)
                            {
                                // Hier beginnt der Zielerkennungsteil //
                                System.Drawing.Bitmap Tmp = (System.Drawing.Bitmap)Img.Clone();
                                ColorFilter.ApplyInPlace(Tmp);
                                GrayscaleFilter.Apply(Tmp);
                                BlobCounter.ProcessImage(Tmp);
                                TargetRectangles = BlobCounter.GetObjectsRectangles();
                                GraphicHandle = System.Drawing.Graphics.FromImage(Img);
                                if (TargetRectangles.Length > 0)
                                {
                                    GraphicHandle.DrawRectangles(TargetPen, TargetRectangles);
                                }
                                // Hier endet der Zielerkennungsteil //
                            }

                            ((PictureboxDD)this.Panel_Webcam.Controls[i]).BackgroundImage = Img;
                        }
                    }
                }

                this.TimerLock = false;
            }
        }

        void InitLauncher()
        {
            System.Console.WriteLine("Initialize missile launchers");

            this.LauncherList = new System.Collections.Generic.List<BaseLauncher>();
            UsbLibrary.HIDDevice.ResetDeviceList();

            #region MSN Missile Launcher
            {
                int j = 1;
                while (true)
                {
                    BaseLauncher L = new MSN_Missile_Launcher();
                    bool r = L.Connect();
                    if (r == true)
                    {
                        L.Nr = j;
                        LauncherList.Add(L);
                        string Str = "MSN Missile Launcher " + j.ToString();
                        System.Console.WriteLine(Str + " is added");
						System.Console.WriteLine("GUID: " + L.GetID());
                        this.Launcherlistbox.Items.Add(Str);
                        j++;
                    }

                    else
                    {
                        break;
                    }
                }
            }
            #endregion

            #region Thunder Missile Launcher
            {
                int j = 1;
                while (true)
                {
                    BaseLauncher L = new Thunder_Missile_Launcher();
                    bool r = L.Connect();
                    if (r == true)
                    {
                        L.Nr = j;
                        LauncherList.Add(L);
                        string Str = "Thunder Missile Launcher " + j.ToString();
                        System.Console.WriteLine(Str + " is added");
						System.Console.WriteLine("GUID: " + L.GetID());
                        this.Launcherlistbox.Items.Add(Str);
                        j++;
                    }

                    else
                    {
                        break;
                    }
                }
            }
            #endregion

            #region Storm O.I.C. Missile Launcher
            {
                int j = 1;
                while (true)
                {
                    BaseLauncher L = new Storm_OIC_Missile_Launcher();
                    bool r = L.Connect();
                    if (r == true)
                    {
                        L.Nr = j;
                        LauncherList.Add(L);
                        string Str = "Storm O.I.C. Missile Launcher " + j.ToString();
                        System.Console.WriteLine(Str + " is added");
						System.Console.WriteLine("GUID: " + L.GetID());
                        this.Launcherlistbox.Items.Add(Str);
                        j++;
                    }

                    else
                    {
                        break;
                    }
                }
            }
            #endregion

            #region c-enter Missile Launcher
            {
                int j = 1;
                while (true)
                {
                    BaseLauncher L = new c_enter_Missile_Launcher();
                    bool r = L.Connect();
                    if (r == true)
                    {
                        L.Nr = j;
                        LauncherList.Add(L);
                        string Str = "c-enter Missile Launcher " + j.ToString();
                        System.Console.WriteLine(Str + " is added");
						System.Console.WriteLine("GUID: " + L.GetID());
                        this.Launcherlistbox.Items.Add(Str);
                        j++;
                    }

                    else
                    {
                        break;
                    }
                }
            }
            #endregion

            if (LauncherList.Count > 0)
            {
                this.RequestStatus = new System.Timers.Timer(100);
                this.RequestStatus.AutoReset = true;
                this.RequestStatus.Enabled = true;
                this.RequestStatus.Elapsed += new System.Timers.ElapsedEventHandler(RequestStatus_Elapsed);
                System.Console.WriteLine(this.LauncherList.Count.ToString() + " missile launchers are added");
            }

            else
            {
                System.Windows.Forms.DialogResult R = System.Windows.Forms.MessageBox.Show("No missile launchers could be found." +
                                                                                           " Do you still want to start MissileControl?",
                                                                                           "Attention",
                                                                                           System.Windows.Forms.MessageBoxButtons.YesNo);

                if (R == System.Windows.Forms.DialogResult.No)
                {
                    TotalDestruction = true;
                }

                else if (R == System.Windows.Forms.DialogResult.Yes)
                {
                    TotalDestruction = false;
                }
            }
        }

        private void RequestStatus_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (this.LauncherList != null)
            {
                for (int i = 0; i < this.LauncherList.Count; i++)
                {
                    if (this.LauncherList[i].Type != LauncherType.Undefined_Missile_Launcher)
                    {
                        SendCommand(LauncherCommandType.Request);
                    }
                }
            }
        }

        private void SendCommand(LauncherCommandType Command)
        {
            if (this.LauncherList != null)
            {
                for (int i = 0; i < this.LauncherList.Count; i++)
                {
                    if (this.LauncherList[i].Type != LauncherType.Undefined_Missile_Launcher)
                    {
                        this.LauncherList[i].SendCommand(Command);
                    }
                }

				if (this.LauncherList == null)
				{
					return;
				}
            }
        }

		void InitMyOwnThings()
		{
			this.Display1.Checked = true;

			this.TargetingCheckBox.Checked = false;
			this.Button_Settings.Enabled   = false;

			this.InitLauncher();

			this.InitWebcams();

			this.CSQList = new System.Collections.Generic.List<CommandoSeqQueue>();
		}

        void StopMyOwnThings()
        {
			if (UpdateWebcams != null)
			{
				UpdateWebcams.Stop();
			}

			for (int j = 0; j < this.WebcamList.Count; j++)
			{
				this.WebcamList[j].Stop();
			}

			this.WebcamList.Clear();
			this.Webcamlistbox.Items.Clear();

            if (this.LauncherList != null)
            {
                for (int i = 0; i < this.LauncherList.Count; i++)
                {
                    this.LauncherList[i].Port.SpecifiedDevice.Dispose();
                }

                this.LauncherList.Clear();
                this.LauncherList = null;
            }
        }

        void SetWndToWebcam()
        {
            // 
            // Panel_List
            // 
            this.Panel_List.Location = new System.Drawing.Point(12, 12);
            this.Panel_List.Size = new System.Drawing.Size(176, 538);
            //
            // label3
            //
            this.Label_Missile.Location = new System.Drawing.Point(3, 290);
            this.Label_Missile.Size = new System.Drawing.Size(97, 13);
            //
            // label2
            //
            this.Label_Webcam.Enabled = true;
            this.Label_Webcam.Visible = true;
            //
            // Raketenwerferlistbox
            //
            this.Launcherlistbox.Location = new System.Drawing.Point(3, 306);
            this.Launcherlistbox.Size = new System.Drawing.Size(170, 229);
            //
            // Panel_Control
            //
            this.Panel_Control.Location = new System.Drawing.Point(194, 406);
            this.Panel_Control.Size = new System.Drawing.Size(578, 144);
            // 
            // label1
            //
            this.Label_Display.Enabled = true;
            this.Label_Display.Visible = true;
            this.Label_Display.Location = new System.Drawing.Point(181, 7);
            this.Label_Display.Size = new System.Drawing.Size(96, 13);
            //
            // button1
            //
            this.Button_About.Location = new System.Drawing.Point(184, 95);
            this.Button_About.Size = new System.Drawing.Size(93, 36);
            // 
            // buttonFire
            //
            this.buttonFire.Location = new System.Drawing.Point(51, 51);
            this.buttonFire.Size = new System.Drawing.Size(40, 40);
            // 
            // buttonRight
            //
            this.buttonRight.Location = new System.Drawing.Point(91, 51);
            this.buttonRight.Size = new System.Drawing.Size(40, 40);
            // 
            // buttonDown
            //
            this.buttonDown.Location = new System.Drawing.Point(51, 91);
            this.buttonDown.Size = new System.Drawing.Size(40, 40);
            // 
            // buttonLeft
            //
            this.buttonLeft.Location = new System.Drawing.Point(11, 51);
            this.buttonLeft.Size = new System.Drawing.Size(40, 40);
            // 
            // buttonUp
            //
            this.buttonUp.Location = new System.Drawing.Point(51, 11);
            this.buttonUp.Size = new System.Drawing.Size(40, 40);
            // 
            // radioButton6
            //
            this.Display6.Enabled = true;
            this.Display6.Visible = true;
            this.Display6.Location = new System.Drawing.Point(231, 69);
            this.Display6.Size = new System.Drawing.Size(31, 17);
            // 
            // radioButton5
            //
            this.Display5.Enabled = true;
            this.Display5.Visible = true;
            this.Display5.Location = new System.Drawing.Point(194, 69);
            this.Display5.Size = new System.Drawing.Size(31, 17);
            // 
            // radioButton4
            //
            this.Display4.Enabled = true;
            this.Display4.Visible = true;
            this.Display4.Location = new System.Drawing.Point(231, 46);
            this.Display4.Size = new System.Drawing.Size(31, 17);
            // 
            // radioButton3
            //
            this.Display3.Enabled = true;
            this.Display3.Visible = true;
            this.Display3.Location = new System.Drawing.Point(194, 46);
            this.Display3.Size = new System.Drawing.Size(31, 17);
            // 
            // radioButton2
            //
            this.Display2.Enabled = true;
            this.Display2.Visible = true;
            this.Display2.Location = new System.Drawing.Point(231, 23);
            this.Display2.Size = new System.Drawing.Size(31, 17);
            // 
            // radioButton1
            //
            this.Display1.Enabled = true;
            this.Display1.Visible = true;
            this.Display1.Location = new System.Drawing.Point(194, 23);
            this.Display1.Size = new System.Drawing.Size(31, 17);
            // 
            // EinstellungenButton
            //
            this.Button_Settings.Enabled = true;
            this.Button_Settings.Visible = true;
            this.Button_Settings.Location = new System.Drawing.Point(117, 0);
            this.Button_Settings.Size = new System.Drawing.Size(89, 23);
            // 
            // ZielerkennungCheckBox
            //
            this.TargetingCheckBox.Enabled = true;
            this.TargetingCheckBox.Visible = true;
            this.TargetingCheckBox.Location = new System.Drawing.Point(3, 3);
            this.TargetingCheckBox.Size = new System.Drawing.Size(95, 17);
            // 
            // Panel_Webcam
            //
            this.Panel_Webcam.Enabled = true;
            this.Panel_Webcam.Visible = true;
            this.Panel_Webcam.Location = new System.Drawing.Point(194, 41);
            this.Panel_Webcam.Size = new System.Drawing.Size(578, 354);
            // 
            // Panel_Target
            //
            this.Panel_Target.Enabled = true;
            this.Panel_Target.Visible = true;
            this.Panel_Target.Location = new System.Drawing.Point(194, 12);
            this.Panel_Target.Size = new System.Drawing.Size(578, 23);
            // 
            // ZielfarbePanel
            //
            this.TargetColorPanel.Enabled = true;
            this.TargetColorPanel.Visible = true;
            this.TargetColorPanel.Location = new System.Drawing.Point(224, 2);
            this.TargetColorPanel.Size = new System.Drawing.Size(161, 19);
            // 
            // Webcamlistbox
            //
            this.Webcamlistbox.Enabled = true;
            this.Webcamlistbox.Visible = true;
            this.Webcamlistbox.Location = new System.Drawing.Point(3, 36);
            this.Webcamlistbox.Size = new System.Drawing.Size(170, 229);
        }

        void SetWndToLauncher()
        {
            this.Size = new System.Drawing.Size(380, 294);
            // 
            // Panel_List
            // 
            this.Panel_List.Location = new System.Drawing.Point(12, 11);
            this.Panel_List.Size = new System.Drawing.Size(170, 239);
            //
            // label3
            //
            this.Label_Missile.Location = new System.Drawing.Point(0, 5);
            this.Label_Missile.Size = new System.Drawing.Size(97, 13);
            //
            // label2
            //
            this.Label_Webcam.Enabled = false;
            this.Label_Webcam.Visible = false;
            //
            // Raketenwerferlistbox
            //
            this.Launcherlistbox.Location = new System.Drawing.Point(3, 21);
            this.Launcherlistbox.Size = new System.Drawing.Size(164, 214);
            //
            // Panel_Control
            //
            this.Panel_Control.Location = new System.Drawing.Point(188, 11);
            this.Panel_Control.Size = new System.Drawing.Size(170, 239);
            // 
            // label1
            //
            this.Label_Display.Enabled = false;
            this.Label_Display.Visible = false;
            //
            // button1
            //
            this.Button_About.Location = new System.Drawing.Point(38, 167);
            this.Button_About.Size = new System.Drawing.Size(94, 36);
            // 
            // buttonFire
            //
            this.buttonFire.Location = new System.Drawing.Point(65, 60);
            this.buttonFire.Size = new System.Drawing.Size(40, 40);
            // 
            // buttonRight
            //
            this.buttonRight.Location = new System.Drawing.Point(105, 60);
            this.buttonRight.Size = new System.Drawing.Size(40, 40);
            // 
            // buttonDown
            //
            this.buttonDown.Location = new System.Drawing.Point(65, 100);
            this.buttonDown.Size = new System.Drawing.Size(40, 40);
            // 
            // buttonLeft
            //
            this.buttonLeft.Location = new System.Drawing.Point(25, 60);
            this.buttonLeft.Size = new System.Drawing.Size(40, 40);
            // 
            // buttonUp
            //
            this.buttonUp.Location = new System.Drawing.Point(65, 20);
            this.buttonUp.Size = new System.Drawing.Size(40, 40);
            // 
            // radioButton6
            //
            this.Display6.Enabled = false;
            this.Display6.Visible = false;
            // 
            // radioButton5
            //
            this.Display5.Enabled = false;
            this.Display5.Visible = false;
            // 
            // radioButton4
            //
            this.Display4.Enabled = false;
            this.Display4.Visible = false;
            // 
            // radioButton3
            //
            this.Display3.Enabled = false;
            this.Display3.Visible = false;
            // 
            // radioButton2
            //
            this.Display2.Enabled = false;
            this.Display2.Visible = false;
            // 
            // radioButton1
            //
            this.Display1.Enabled = false;
            this.Display1.Visible = false;
            // 
            // EinstellungenButton
            //
            this.Button_Settings.Enabled = false;
            this.Button_Settings.Visible = false;
            // 
            // ZielerkennungCheckBox
            //
            this.TargetingCheckBox.Enabled = false;
            this.TargetingCheckBox.Visible = false;
            // 
            // Panel_Webcam
            //
            this.Panel_Webcam.Enabled = false;
            this.Panel_Webcam.Visible = false;
            // 
            // Panel_Target
            //
            this.Panel_Target.Enabled = false;
            this.Panel_Target.Visible = false;
            // 
            // ZielfarbePanel
            //
            this.TargetColorPanel.Enabled = false;
            this.TargetColorPanel.Visible = false;
            // 
            // Webcamlistbox
            //
            this.Webcamlistbox.Enabled = false;
            this.Webcamlistbox.Visible = false;
        }

        // Main window design
        private System.Windows.Forms.Panel Panel_List;
        private System.Windows.Forms.CheckedListBox Launcherlistbox;
        private MissileControl.ListboxDD Webcamlistbox;
        private System.Windows.Forms.Panel Panel_Control;
        private System.Windows.Forms.Panel Panel_Webcam;
        private System.Windows.Forms.Panel Panel_Target;
        private System.Windows.Forms.Label Label_Missile;
        private System.Windows.Forms.Label Label_Webcam;
        private System.Windows.Forms.RadioButton Display6;
        private System.Windows.Forms.RadioButton Display5;
        private System.Windows.Forms.RadioButton Display4;
        private System.Windows.Forms.RadioButton Display3;
        private System.Windows.Forms.RadioButton Display2;
        private System.Windows.Forms.RadioButton Display1;
        private System.Windows.Forms.Button buttonFire;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button Button_About;
		private System.Windows.Forms.Button Button_Settings;
        private System.Windows.Forms.Label Label_Display;
		private System.Windows.Forms.ContextMenuStrip ContextMenuLauncher;
		private System.Windows.Forms.ToolStripMenuItem loadExistingCommandoListToolStripMenuItem;

        // Webcams, Launchers and other magical things
        private System.Collections.Generic.List<Webcam> WebcamList;
        private AForge.Imaging.Filters.ColorFiltering ColorFilter;
        private AForge.Imaging.Filters.Grayscale GrayscaleFilter;
        private AForge.Imaging.BlobCounter BlobCounter;
        private System.Drawing.Rectangle[] TargetRectangles;
        private System.Drawing.Graphics GraphicHandle;
        private System.Drawing.Pen TargetPen;
        private System.Timers.Timer UpdateWebcams;
        private bool TimerLock;
        private System.Collections.Generic.List<BaseLauncher> LauncherList;
        private System.Timers.Timer RequestStatus;
        private System.Windows.Forms.CheckBox TargetingCheckBox;
        private System.Windows.Forms.Panel TargetColorPanel;
        private System.Drawing.Color TargetColorU;
        private System.Drawing.Color TargetColorO;
		private System.Collections.Generic.List<CommandoSeqQueue> CSQList;
		private System.Windows.Forms.ToolStripMenuItem startScriptToolStripMenuItem;
        
        // Yes, it does what you think
        private bool TotalDestruction;
    }
}