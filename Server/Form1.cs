using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        Socket _server;
        VideoCapture _capture;
        double _totalFrames = 0,
            _fps = 0;
        int _frameNo;
        bool _isReadingFrame;
        public Server()
        {
            InitializeComponent();
        }

        public void StartServer()
        {
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);

            _server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _server.Bind(localEndPoint);
        }

        private void Server_Load(object sender, EventArgs e)
        {
            StartServer();
        }

        private void elStartBtn_Click(object sender, EventArgs e)
        {
            if (_capture == null || _isReadingFrame == true)
            {
                return;
            }

            _isReadingFrame = true;
            SendAllFrames();
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\ASUS_X541U\UNIVER2018\SEMESTRUL_VI\PR\Lab_5_PR_Final";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _capture = new VideoCapture(ofd.FileName);

                Mat frame = new Mat();
                _capture.Read(frame);
                elPictureBox.Image = frame.Bitmap;

                _totalFrames = _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount);
                _fps = _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);

                elFpsLabel.Text = "Fps: " + Convert.ToInt32(_fps).ToString();
            }
        }

        private async void SendAllFrames()
        {
            IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9998);

            Mat frame = new Mat();

            while (_isReadingFrame == true && _frameNo < _totalFrames)
            {
                _frameNo += Convert.ToInt32(elNumericUpDown.Value);
                _capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, _frameNo);
                _capture.Read(frame);

                string frameToBase64 = GetBase64(frame.Bitmap);
                System.Diagnostics.Debug.WriteLine(frameToBase64);

                byte[] frameToBytes = Encoding.UTF8.GetBytes("BEGIN" + frameToBase64 + "END");

                byte[][] datagrams = frameToBytes
                    .Select((s, i) => new { Value = s, Index = i })
                    .GroupBy(x => x.Index / 65000)
                    .Select(grp => grp.Select(x => x.Value).ToArray())
                    .ToArray();

                for (int i = 0; i < datagrams.Length; i++)
                {
                    System.Diagnostics.Debug.WriteLine("datagram:{0}", datagrams[i].ToString());
                    _server.SendTo(datagrams[i], clientEndPoint);
                }

                elPictureBox.Image = frame.Bitmap;
                elFrameNoLabel.Text = _frameNo.ToString() + " / " + _totalFrames.ToString();

                await Task.Delay(1000 / Convert.ToInt32(_fps));
            }
        }

        private void elPauseBtn_Click(object sender, EventArgs e)
        {
            _isReadingFrame = false;
        }

        private string GetBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
    }
}
