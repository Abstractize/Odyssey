using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    class Song
    {
        private String URL;
        private String name;
        private Artist artist;//revisar después
        private Album album;//revisar después
        private uint year;
        private uint albumIndex;
        private uint disc;

        public uint GetDisc()
        {
            return this.disc;
        }

        public void SetDisc(uint value)
        {
            this.disc = value;
        }

        public Song(String song, Artist artist, Album album, uint year, uint disc, uint index,String URL)
        {
            this.setName(song);
            this.setArtist(artist);
            this.setAlbum(album);
            this.setYear(year);
            this.SetDisc(disc);
            this.setAlbumIndex(index);
            this.setURL(URL);
        }
        public int toInt(String str)
        {
            int value = Convert.ToInt32(str);
            return value;
        }
        //Getter y Setters
        public String getURL()
        {
            return URL;
        }

        public void setURL(String uRL)
        {
            URL = uRL;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public Artist getArtist()
        {
            return artist;
        }

        public void setArtist(Artist artist)
        {
            this.artist = artist;
        }

        public Album getAlbum()
        {
            return album;
        }

        public void setAlbum(Album album)
        {
            this.album = album;
        }

        public uint getYear()
        {
            return year;
        }

        public void setYear(uint year)
        {
            this.year = year;
        }

        public uint getAlbumIndex()
        {
            return albumIndex;
        }

        public void setAlbumIndex(uint albumIndex)
        {
            this.albumIndex = albumIndex;
        }
    }
}
