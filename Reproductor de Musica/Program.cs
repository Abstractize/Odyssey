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
    /// <summary>
    /// Main
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        static Client client = new Client();

        [STAThread]
        static void Main(string[] args)
        {
            Thread playerThread = new Thread(new ThreadStart(startGUI));
            //Thread clientThread = new Thread(new ThreadStart(startClient));
            playerThread.SetApartmentState(ApartmentState.STA);
            playerThread.Start();
            //clientThread.Start();
            
        }

        public static void startGUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form3 loginScreen = new Form3(client);
            Application.Run(loginScreen);



           Application.Run(new Form1(loginScreen.getUsername(),client));
        }

        public static void startClient()
        {
            
            client.connect();
        }

    }
}
