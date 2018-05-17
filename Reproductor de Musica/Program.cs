using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Reproductor_de_Musica
{
    static class Program
    {
        const int PORT_NO = 10578;
        const string SERVER_IP = "127.0.0.1";
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
       [STAThread]
        static void Main(string[] args)
        {
            Thread playerThread = new Thread(new ThreadStart(startGUI));
            //Thread clientThread = new Thread(new ThreadStart(connect));
            playerThread.SetApartmentState(ApartmentState.STA);
            playerThread.Start();
            //clientThread.Start();
            
        }

        public static void connect()
        {
            Socket soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            System.Net.IPAddress ipAdd = System.Net.IPAddress.Parse(SERVER_IP);
            System.Net.IPEndPoint remoteEP = new IPEndPoint(ipAdd, PORT_NO);
            soc.Connect(remoteEP);
            
            String message = "hello";
            Console.WriteLine("Sending : " + message);
            Console.WriteLine(message.Length);
            byte[] byData = System.Text.Encoding.ASCII.GetBytes(message);
            soc.Send(byData);

            byte[] buffer = new byte[1024];
            int iRx = soc.Receive(buffer);
            char[] chars = new char[iRx];

            System.Text.Decoder d = System.Text.Encoding.UTF8.GetDecoder();
            int charLen = d.GetChars(buffer, 0, iRx, chars, 0);
            System.String recv = new System.String(chars);
            Console.WriteLine("Server responde: " + recv);

        }

        public static void startGUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form3());
        }

    }
}
