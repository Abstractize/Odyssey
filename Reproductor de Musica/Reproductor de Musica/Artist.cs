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
