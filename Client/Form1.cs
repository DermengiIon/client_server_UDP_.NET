using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {
        Socket _client;
        EndPoint _serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
        string _dGramBegin = "BEGIN", _dGramEnd = "END";
        public Client()
        {
            InitializeComponent();
        }

        private void StartClient()
        {
            _client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9998);
            _client.Bind(localEndPoint);

            label1.Text = "The client is Started";

            StateObject stateObject = new StateObject();
            stateObject.workSocket = _client;

            _client.BeginReceiveFrom(stateObject.buffer, 0, StateObject.BUFFER_SIZE, SocketFlags.None, 
                                    ref _serverEndPoint, new AsyncCallback(Read_Callback), stateObject);
        }

        private void Read_Callback(IAsyncResult ar)
        {
            StateObject stateObject = (StateObject)ar.AsyncState;
            Socket client = stateObject.workSocket;

            EndPoint serverEndPoint = (EndPoint)_serverEndPoint;

            int read = client.EndReceiveFrom(ar, ref serverEndPoint);

            if (read > 0)
            {
                string datagram = Encoding.ASCII.GetString(stateObject.buffer, 0, read);
                ProcessRead(datagram, stateObject);
            }

            client.BeginReceiveFrom(stateObject.buffer, 0, StateObject.BUFFER_SIZE, 0, ref serverEndPoint,
                                         new AsyncCallback(Read_Callback), stateObject);
        }

        private void Client_Load(object sender, EventArgs e)
        {
            StartClient();
        }

        private void ProcessRead(string datagram, StateObject stateObject)
        {
            if (datagram.Contains(_dGramBegin))
            {
                stateObject.frame = new StringBuilder();
                stateObject.frame.Append(datagram.Replace(_dGramBegin, ""));
            }
            else if (datagram.Contains(_dGramEnd))
            {
                stateObject.frame.Append(datagram.Replace(_dGramEnd, ""));
                ProcessFrame(stateObject.frame.ToString());
            }
            else
            {
                stateObject.frame.Append(datagram);
            }
        }

        private void ProcessFrame(string frame)
        {
            System.Diagnostics.Debug.WriteLine(frame);

            try
            {
                byte[] frameBytes = Convert.FromBase64String(frame);
                Image image;

                using (var ms = new MemoryStream(frameBytes, 0, frameBytes.Length))
                {
                    image = Image.FromStream(ms, true);
                }

                this.Invoke(new MethodInvoker(delegate
                {
                    elPictureBox.Image = image;
                }));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
    }
}
