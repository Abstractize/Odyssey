using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    interface ClientActions
    {
        //Log In Form
        bool verifyUsername(String username);
        //Verifica que exista el usuario, retorna true si es así
        bool verifyPassword(String password);
        //Verifica si la contraseña es válida con el usario, retorna true si es así

        //Registation Form
        void sendInfo(String username, String fullname, String password, List genres,int age );
        //Manda la información del usario al servidor para cree la cuenta

        //Principal Form
            //Music Library
            void sendMP3File(Song song);
            //Send the song to the server the server to add it to the server files

            AlbumList getAlbumList();
            //gets the list of songs added to the account SongList and set it to the Album list of the account
            void changeSongInfo(String oldName, String oldArtist, String oldAlbum, String name, String Artist, String Album, String year, String Index, String Disc);
            //sends the new info to the server and changes the song info
        
    }
}
