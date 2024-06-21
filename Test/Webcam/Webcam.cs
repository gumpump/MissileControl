namespace MissileControl
{
    /// <summary>
    /// Diese Klasse beinhaltet die Webcam selbst und das Bild,
    /// welches dazu benutzt werden kann, um es anzuzeigen
    /// oder andersweitig zu benutzen
    /// </summary>
    class Webcam
    {
        private AForge.Video.DirectShow.VideoCaptureDevice Cam;
        private System.Drawing.Image I;

        public Webcam(string MonikerString)
        {
            Cam = new AForge.Video.DirectShow.VideoCaptureDevice(MonikerString);
            Cam.NewFrame += new AForge.Video.NewFrameEventHandler(Cam_NewFrame);
            this.Stop();
        }

        public void Start()
        {
            if (Cam != null)
            {
                Cam.Start();
                System.Console.WriteLine("Webcam is starting");
            }
        }

        public void Stop()
        {
            if (Cam != null)
            {
                Cam.Stop();
                System.Console.WriteLine("Webcam is stopping");
            }
        }

        public System.Drawing.Image GetBitmap()
        {
            if (I != null)
            {
                return (System.Drawing.Bitmap)this.I.Clone();
            }

            else
            {
                return null;
            }
        }

        void Cam_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            this.I = (System.Drawing.Bitmap)eventArgs.Frame.Clone();
        }
    }
}