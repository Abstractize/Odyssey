using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    interface ClientActions
    {
        
        bool verifyUsername(String username,String password);
       
        
        
        void sendInfo(String username, String fullname, String password, StringList genres,int age );
        
        void sendMP3File(Song song);
           

        AlbumList getAlbumList();
            
        void changeSongInfo(String oldName, String oldArtist, String oldAlbum, String name, String Artist, String Album, String year, String Index, String Disc);


        //Busque de Arboles
        ArtistList getSearchedArtist(String search);
        AlbumList getSearchedAlbum(String search);
        List getSearchedSong(String search);

    }
}
