using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    class Album
    {
        //Define on Create
        private String name;
        private Artist artist;
        //Define on Songs added
        private List songs;
        private uint Year;
        private Bitmap bitImage;
        public Album(String name, Artist art,Bitmap image)
        {
            this.setName(name);
            this.setArtist(art);
            this.SetBitImage(image);
            this.songs = new List();
        }
        public Bitmap GetBitImage()
        {
            return this.bitImage;
        }

        public void SetBitImage(Bitmap value)
        {
            this.bitImage = value;
        }

        public List getSongs()
        {
            return songs;
        }

        public void setSongs(List songs)
        {
            this.songs = songs;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public uint getYear()
        {
            return Year;
        }

        public void setYear(uint year)
        {
            Year = year;
        }

        public Artist getArtist()
        {
            return artist;
        }

        public void setArtist(Artist artist)
        {
            this.artist = artist;
        }
    }
}
