using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    class Client : ClientActions
    {
        public void changeSongInfo(string oldName, string oldArtist, string oldAlbum, string name, string Artist, string Album, string year, string Index, string Disc)
        {
            throw new NotImplementedException();
        }

        public AlbumList getAlbumList()
        {
            throw new NotImplementedException();
        }

        public void sendInfo(string username, string fullname, string password, List genres, int age)
        {
            throw new NotImplementedException();
        }

        public void sendMP3File(Song song)
        {
            throw new NotImplementedException();
        }

        public bool verifyPassword(string password)
        {
            throw new NotImplementedException();
        }

        public bool verifyUsername(string username)
        {
            throw new NotImplementedException();
        }
    }
}
