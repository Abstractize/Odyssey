using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    interface ClientActions
    {
        //Login y Registro
        bool verifyUsername(String username,String password);
       
        void sendInfo(String username, String fullname, String password, StringList genres,int age );
       
           

        
            
        void changeSongInfo(String oldName, String oldArtist, String oldAlbum, String name, String Artist, String Album, String year, String Index, String Disc);

        //Busque de Arboles
        ArtistList getSearchedArtist(String search);
        AlbumList getSearchedAlbum(String search);
        List getSearchedSong(String search);
        //Resultados de busquedas
        void addSong(String Artist, String Album, String Song);
        void addAlbum(String Artist, String Album);
        void addArtist(String Artist);
        //Mandar Listas a la biblioteca
        void sendAlbumList(AlbumList list);
        void sendArtistList(ArtistList list);
        void sendSongList(List list);
        //Mandar MP3 a la bilblioteca
        void sendMP3File(Song song);
        //Obtener Listas de la biblioteca
        AlbumList getAlbumList();
        ArtistList getArtistList();
        List getSongList();
        
    }
}
