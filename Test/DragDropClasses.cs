using System.Windows.Forms;

namespace MissileControl
{
    public class ListboxDD : CheckedListBox
    {
        public ListboxDD()
        {
            System.Console.WriteLine("Construct listbox");
            this.MouseDown += new MouseEventHandler(ListboxDD_MouseDown);
            this.MouseUp += new MouseEventHandler(ListboxDD_MouseUp);
            this.DragLeave += new System.EventHandler(ListboxDD_DragLeave);
            this.QueryContinueDrag += new QueryContinueDragEventHandler(ListboxDD_QueryContinueDrag);
        }

        void ListboxDD_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
        }

        void ListboxDD_MouseDown(object sender, MouseEventArgs e)
        {
            if (((ListboxDD)sender).Items.Count < 1)
            {
                return;
            }

            int Index = IndexFromPoint(e.X, e.Y);
            if (Index >= 0)
            {
                string S = ((ListboxDD)sender).Items[Index].ToString();
                DragDropEffects DDE = ((ListboxDD)sender).DoDragDrop(S, DragDropEffects.Copy);
                if (DDE == DragDropEffects.Copy)
                {
                    System.Console.WriteLine("Do drag n drop");
                }
            }
        }

        void ListboxDD_MouseUp(object sender, MouseEventArgs e)
        {
        }

        void ListboxDD_DragLeave(object sender, System.EventArgs e)
        {
            System.Console.WriteLine("Leave listbox");
        }
    }

    public class PictureboxDD : PictureBox
    {
        private int _WebcamNr;

        public int WebcamNr
        {
            get
            {
                return _WebcamNr;
            }

            set
            {
                this._WebcamNr = value;

                if (value == -1)
                {
                    this.ExitButton.Enabled = false;
                    this.ExitButton.Visible = false;
                }

                else
                {
                    this.ExitButton.Enabled = true;
                    this.ExitButton.Visible = true;
                }
            }
        }
        public System.Windows.Forms.Button ExitButton;

        public PictureboxDD()
        {
            System.Console.WriteLine("Construct picturebox");
            this.DragEnter += new DragEventHandler(PictureboxDD_DragEnter);
            this.DragDrop += new DragEventHandler(PictureboxDD_DragDrop);
            this.ExitButton = new System.Windows.Forms.Button();
            this.ExitButton.BackColor = Control.DefaultBackColor;
            this.ExitButton.Location = this.Location;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(20, 20);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(ExitButton_Click);
            this.ExitButton.Enabled = false;
            this.ExitButton.Visible = false;
            this.Controls.Add(ExitButton);
        }

        void ExitButton_Click(object sender, System.EventArgs e)
        {
            this.WebcamNr = -1;
			this.BackgroundImage = null;
        }

        void PictureboxDD_DragEnter(object sender, DragEventArgs e)
        {
            System.Console.WriteLine("Enter picturebox");

            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }

            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        void PictureboxDD_DragDrop(object sender, DragEventArgs e)
        {
            System.Console.WriteLine("Drop listitem");

            if (e.Effect == DragDropEffects.Copy)
            {
                this.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}