using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    class Artist
    {
        private Bitmap image;
        private String Name;
        private AlbumList Albums;

       

        public Artist(String name, Bitmap Image)
        {
            this.setName(name);
            this.setAlbums(new AlbumList());
            this.image = Image;

        }
        public int getTotalIndex(string name)
        {
            int index = 0;
            Node<Album> alb = this.getAlbums().getHead();
            Node<Song> song = alb.getValue().getSongs().getHead();
            String songName = song.getValue().getName();
            while (songName != name)
            {
                song = song.getNext();
                songName = song.getValue().getName();
                index++;
                if (song == null)
                {
                    alb = alb.getNext();
                    if (alb != null)
                    {
                        song = alb.getValue().getSongs().getHead();
                    }
                }
            }
            return index;
        }
        //Getters y Setters
        public String getName()
        {
            return Name;
        }
        public void setName(String name)
        {
            Name = name;
        }
        public AlbumList getAlbums()
        {
            return Albums;
        }
        public void setAlbums(AlbumList albums)
        {
            Albums = albums;
        }

        public Bitmap GetImage()
        {
            return image;
        }

        public void SetImage(Bitmap value)
        {
            image = value;
        }
    }
}
