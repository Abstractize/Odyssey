using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Reproductor_de_Musica
{
    public class Client : ClientActions
    {

        const int PORT_NO = 10578;
        const string SERVER_IP = "127.0.0.1";
        Socket soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public void changeSongInfo(string oldName, string oldArtist, string oldAlbum, string name, string Artist, string Album, string year, string Index, string Disc)
        {
            throw new NotImplementedException();
        }

        public AlbumList getAlbumList()
        {
            throw new NotImplementedException();
        }

        public void sendInfo(string username, string fullname, string password, StringList genres, int age)
        {
            User regisrtryUser = newUser(username, fullname, age, password,genres);
            String xml = convertToXMLString(regisrtryUser);
            startconection();
            sendINFO(xml);

        }

        public void sendMP3File(Song song)
        {
            throw new NotImplementedException();
        }

        public bool verifyPassword(string password)
        {
            throw new NotImplementedException();
        }

        public bool verifyUsername(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void connect()
        {
            User user1 = new User();

            user1.password = "mitoc123";
            user1.userName = "Hide On Bush";
            user1.age = 21;

            User user2 = new User();
            user2.age = 32;
            user2.userName = "Scarra";
            user2.password = "Im Faker";


            //SerializeObject(user1);

            String xmlString = convertToXMLString(user2);

            startconection();

            sendINFO(xmlString);

            //Recieve and decode
            recieveINFO();

        }

        public void setUserInfo(User user)
        {
        
            user.getUserName();
            user.getPassword();
            user.getFullName();
            user.getAge();
           
        }
        private User newUser(String userName, String fullName, int age, String password, StringList genres)
        {
            User newUser = new User();
            newUser.age = age;
            newUser.fullName = fullName;
            newUser.password = password;
            newUser.userName = userName;
            newUser.genres = genres;

            return newUser;

        }

        private String convertToXMLString(User user1)
        {
            var stringwriter = new StringWriter();
            var serializer = new XmlSerializer(user1.GetType());
            serializer.Serialize(stringwriter, user1);
            String xmlString = stringwriter.ToString();
            Console.WriteLine(xmlString);

            return xmlString;
        }

        private void startconection()
        {
            IPAddress ipAdd = IPAddress.Parse(SERVER_IP);
            IPEndPoint remoteEP = new IPEndPoint(ipAdd, PORT_NO);
            soc.Connect(remoteEP);
        }

        private void sendINFO(String xmlString)
        {
            String message = "hello";
            Console.WriteLine("Sending : " + message);
            Console.WriteLine(message.Length);
            byte[] byData = Encoding.ASCII.GetBytes(xmlString);
            soc.Send(byData);
        }

        private void recieveINFO()
        {
            byte[] buffer = new byte[16 * 1024];
            int iRx = soc.Receive(buffer);
            char[] chars = new char[iRx];

            Decoder d = Encoding.UTF8.GetDecoder();
            int charLen = d.GetChars(buffer, 0, iRx, chars, 0);
            System.String recv = new System.String(chars);
            Console.WriteLine("Server responde: " + recv);
        }

        public ArtistList getSearchedArtist(string search)
        {
            throw new NotImplementedException();
        }

        public AlbumList getSearchedAlbum(string search)
        {
            throw new NotImplementedException();
        }

        public List getSearchedSong(string search)
        {
            throw new NotImplementedException();
        }

        public void sendAlbumList(AlbumList list)
        {
            throw new NotImplementedException();
        }

        public void sendArtistList(ArtistList list)
        {
            throw new NotImplementedException();
        }

        public void sendSongList(List list)
        {
            throw new NotImplementedException();
        }

        public ArtistList getArtistList()
        {
            throw new NotImplementedException();
        }

        public List getSongList()
        {
            throw new NotImplementedException();
        }

        public void addSong(string Artist, string Album, string Song)
        {
            throw new NotImplementedException();
        }

        public void addAlbum(string Artist, string Album)
        {
            throw new NotImplementedException();
        }

        public void addArtist(string Artist)
        {
            throw new NotImplementedException();
        }
    }
}
