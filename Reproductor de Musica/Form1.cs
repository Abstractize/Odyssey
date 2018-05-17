using Lastfm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
//using ;

namespace Reproductor_de_Musica

{
    public partial class Form1 : Form
    {
        int mode = 0;// 0 Artist, 1 Album, 2 Song
        Song prev;
        Queue<Song> songQueue = new Queue<Song>();
        bool Play = false;
        bool trackBarClick = false;
        bool SongOrAlbumLV1 = false; //false for album, true for songs
        
        List MP3Files = new List();
        AlbumList Albums = new AlbumList();
        ArtistList Artists = new ArtistList();

        public Form1(string username)
        {
            InitializeComponent();
            userButton.Text = username;

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            switch (Play)
            {
             case true:
                 Player.Ctlcontrols.pause();
                 break;
             case false:
                 Player.Ctlcontrols.play();
                 break; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addFileToToolStripMenuItem_Click(object sender, EventArgs e)//Revisar
        {
            OpenFileDialog SearchBox = new OpenFileDialog();
            SearchBox.Multiselect = true;
            if (SearchBox.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach(var dic in SearchBox.FileNames)
                {
                    
                    bool add = false;   
                    TagLib.File data = TagLib.File.Create(dic);
                    //Instance info on lists
                    Artist art;
                    Album alb;
                    Song newSong;
                    //Get SongInfo
                    String name = data.Tag.Title;
                    String album = data.Tag.Album;
                    uint year = data.Tag.Year;
                    uint index = data.Tag.Track;
                    uint Disc = data.Tag.Disc;
                    String URL = dic;
                    
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                    String artist = data.Tag.Artists[0];
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos

                    //Add to Artist
                    if (Artists.searchName(artist))
                    {
                        art = Artists.searchArtist(artist);
                        
                    }
                    else if(artist == "")
                    {
                        if (Artists.searchName("Uknown Artist"))
                        {
                            art = Artists.searchArtist("Uknown Artist");
                        }
                        else
                        {
                            add = true;
                            art = new Artist("Uknown Artist", Properties.Resources.descarga__2_);//Change Image
                        }
                    }
                    else
                    {
                        add = true;
                        art = new Artist(artist, Properties.Resources.descarga__2_);//Change Image
                        
                        
                    }
                    //Add to Album
                    if (art.getAlbums().searchName(album))
                    {
                        alb = art.getAlbums().searchAlbum(album);
                        
                    }else if(album == "")
                    {
                        if (art.getAlbums().searchName("Uknown Album"))
                        {
                            alb = art.getAlbums().searchAlbum(album);

                        }
                        else
                        {
                            alb = new Album("Uknown Album", art, Properties.Resources.album);
                            art.getAlbums().add(alb);
                            art.getAlbums().sort("year");
                        }
                    }
                    else
                    {
                        alb = new Album(album, art, Properties.Resources.album);
                        art.getAlbums().add(alb);
                        art.getAlbums().sort("year");
                        
                        

                    }
                    //Add to Songs
                    if (!alb.getSongs().searchName(name))
                    {
                        
                        newSong = new Song(name, art, alb, year, Disc, index, URL);
                        
                        alb.getSongs().add(newSong);
                        
                        //alb.getSongs().sort();
                        
                        alb.setYear(year);

                        //Add image song in first song added
                        /*Console.WriteLine(newSong.getName());
                        Console.WriteLine(newSong.getArtist().getName());
                        Console.WriteLine(newSong.getAlbum().getName());
                        Console.WriteLine(newSong.getYear());
                        Console.WriteLine(newSong.GetDisc());
                        Console.WriteLine(newSong.getAlbumIndex());
                        Console.WriteLine(newSong.getURL());*/

                    }
                                        
                    if (add)
                    {
                        Artists.add(art);
                        //Artists.sort();
                        

                    }
                    
                    

                }
                
            }
            drawOnSongList();
            drawOnArtistList();
            Console.WriteLine("Items agregados");
        }
        public void drawOnAlbumList()
        {
            int imageindex = 0;
            
            AlbumForArtist.Images.Clear();
            for (int i = 0; i < Artists.getLength(); i++)
            {
                Artist art = Artists.getValue(i);
                for (int j = 0; j < art.getAlbums().getLength(); j++)
                {
                    Album alb = art.getAlbums().getValue(j);
                    AlbumForArtist.Images.Add(alb.GetBitImage());
                    ListViewItem album = new ListViewItem(alb.getName(),imageindex);
                    imageindex++;

                    //album.SubItems.Add(alb.getArtist().getName());
                    //album.SubItems.Add(alb.getYear().ToString());
                    listView2.Items.Add(album);
                }
            }
        }
        public void drawOnArtistList()
        {
            toolStrip3.Items.Clear();
            for (int i = 0; i < Artists.getLength(); i++)
            {

                Artist art = Artists.getValue(i);
                ToolStripButton Artist = new ToolStripButton();
                Artist.AutoSize = false;
                Artist.Size = new Size(182,70);
                
                Artist.Name = (art.getName());
                Artist.AutoSize = false;
                Artist.Text = art.getName();
                Artist.Image = art.GetImage();
                Artist.ImageAlign = ContentAlignment.MiddleLeft;
                Artist.TextImageRelation = TextImageRelation.ImageBeforeText;
                //Artist.Size = new Size(180,30);
                Artist.ImageScaling = ToolStripItemImageScaling.None;
                Artist.Font = new Font("MS Reference Sans Serif" , 9);
                Artist.ForeColor = SystemColors.ControlLightLight;


      
                Artist.BackColor = Color.Transparent;
                toolStrip3.Items.Add(Artist); 
                    
            
            }
        }
        public void drawOnSongList()
        {
            lstSongs.Items.Clear();
            lstSongs.View = View.Details;
            for (int i = 0; i < Artists.getLength(); i++)
            {
                Artist art = Artists.getValue(i);
                for (int j = 0; j < art.getAlbums().getLength(); j++)
                {
                    Album alb = art.getAlbums().getValue(j);
                    for (int k = 0; k < alb.getSongs().getLength(); k++)
                    {
                        Song file = alb.getSongs().getValue(k);

                        TagLib.File data = TagLib.File.Create(file.getURL());
                        ListViewItem song = new ListViewItem(file.getName());
                        
                        lstSongs.Items.Add(song);
                        song.SubItems.Add(setTime(data.Properties.Duration.ToString()));
                        song.SubItems.Add(file.getArtist().getName());
                        song.SubItems.Add(file.getAlbum().getName());
                        song.SubItems.Add(file.getYear().ToString());
                        song.SubItems.Add(file.getRating());
                    }
                }
            }
        }
        private String setTime(String time)
        {
            String Timer = "";
            for (int i=0; i < 8; i++)
            {
                if (i > 2){
                    Timer = Timer.Insert(Timer.Length, time.ElementAt(i).ToString());
                }
            }
            return Timer;
        }
        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            toolStrip3.Visible = true;
            drawOnArtistList();
            mode = 0;
            lstSongs.Visible = false;
            listView2.Visible = false;
            
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            toolStrip3.Visible = false;
            drawOnAlbumList();
            mode = 1;
            lstSongs.Visible = false;
            listView1.Visible = false;
            listView2.Visible = true;
            listView2.FullRowSelect = true;
        }

        private void lstSongs_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lstSongs.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
            if (e.Button == MouseButtons.Left)
            {
                foreach (ListViewItem lista in lstSongs.SelectedItems)//lstSongs.SelectedItems
                {
                    songQueue.empty();
                    for (int i = lista.Index; i < lstSongs.Items.Count; i++)
                    {
                        
                        enqueueSong(lstSongs.Items[i]);
                        
                    }

                    playSong();
                }
            }
                
        }
        private Song getSong(ListViewItem song)
        {
            int index = song.Index;
            Song file = Artists.getTotalValue(index);
            return file;
        }
        //Song Queue Function
        private void enqueueSong(ListViewItem song)
        {
            int index = song.Index;
            Song file = Artists.getTotalValue(index);
            songQueue.enqueue(file);
            Console.WriteLine("enqueued" + file.getName());

        }
        private void enqueueSong(String Artist,String Album, String Name)
        {
            
            
            Song file = Artists.searchArtist(Artist).getAlbums().searchAlbum(Album).getSongs().searchSong(Name);
            songQueue.enqueue(file);
        }
        private void playSong()
        {
            Console.WriteLine("Play:"+songQueue.peek().getName());
            if (songQueue.getLength() != 0)
            {

                Song song = songQueue.peek();
                String dic = song.getURL();
                Player.URL = dic;
                lblSong.Text = (song.getName() + "\n" + song.getArtist().getName() + "\n" + song.getAlbum().getName());
                MemoryStream ms = new MemoryStream(getImage(dic).Data.Data);
                Image img = Image.FromStream(ms);
                Bitmap b = new Bitmap(img, new Size(40, 40));
                MemoryStream ms2 = new MemoryStream();
                b.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg);
                lblSong.Image = b;
                Player.Ctlcontrols.play();
            }
        }
        private void playNext()
        {
            if (songQueue.getLength() != 0)
            {
                prev = songQueue.peek();
                songQueue.dequeue();
           
                playSong();
                
                
            }
            
        }
        public void playPrev()
        {
            if (prev != null)
            {
                Song now = songQueue.peek();//Fix
                songQueue.empty();
                if (mode == 2){
                    int index = lstSongs.SelectedItems[0].Index;
                    for (int i = index - 1; i < lstSongs.Items.Count; i++)
                    {
                        Console.WriteLine("i:" + i + "," + "max:" + lstSongs.Items.Count);
                        enqueueSong(lstSongs.Items[i]);
                        Console.WriteLine(lstSongs.Items[i]);
                    }
                    if (songQueue.getLength() != 0)
                    {
                        
                        prev = getSong(lstSongs.Items[index - 1]);
                        playSong();
                        

                    }
                }
                else if(mode == 0)
                {
                    int index = listView1.SelectedItems[0].Index;
                    for (int i = index - 1; i < listView1.Items.Count; i++)
                    {
                        Console.WriteLine("i:" + i + "," + "max:" + listView1.Items.Count);
                        enqueueSong(listView1.Items[i]);
                        Console.WriteLine(lstSongs.Items[i]);
                    }
                    if (songQueue.getLength() != 0)
                    {
                        playSong();
                        prev = getSong(listView1.Items[index - 1]);

                    }
                }
                
            }
            
            
        }
        //Images
        private TagLib.IPicture getImage(String dic)
        {
            TagLib.IPicture icon; //= Properties.Resources.album;
            //Mp3File
            TagLib.File mp3 = TagLib.File.Create(dic);
            //Verify if cover
            if (mp3.Tag.Pictures.Length == 0)
            {
                TagLib.Picture pic = new TagLib.Picture("D:/Users/Gabo/Escritorio/Proyectos/Projects/Reproductor de Musica/Reproductor de Musica/Resources/descarga (4).jpg");
                icon = pic;
            }
            else
            {
                icon = mp3.Tag.Pictures[0];
            }
            
            return icon;
        }

        private void lstSongs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addFolderToLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog SearchBox = new FolderBrowserDialog();
            //SearchBox.Multiselect = true;
            if (SearchBox.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (var dic in Directory.GetFiles(SearchBox.SelectedPath))

                {
                    if (dic.EndsWith(".mp3"))
                    {
                        bool add = false;   
                    TagLib.File data = TagLib.File.Create(dic);
                    //Instance info on lists
                    Artist art;
                    Album alb;
                    Song newSong;
                    //Get SongInfo
                    String name = data.Tag.Title;
                    String album = data.Tag.Album;
                    uint year = data.Tag.Year;
                    uint index = data.Tag.Track;
                    uint Disc = data.Tag.Disc;
                    String URL = dic;
                    String artist = data.Tag.FirstAlbumArtist;
                    
                    //Add to Artist
                    if (Artists.searchName(artist))
                    {
                        art = Artists.searchArtist(artist);
                        
                    }
                    else
                    {
                        add = true;
                        art = new Artist(artist, Properties.Resources.descarga__2_);//Change Image
                        
                        
                    }
                    //Add to Album
                    if (art.getAlbums().searchName(album))
                    {
                        alb = art.getAlbums().searchAlbum(album);
                        
                    }
                    else
                    {
                        alb = new Album(album, art, Properties.Resources.album);
                        art.getAlbums().add(alb);
                        art.getAlbums().sort("year");
                        
                        

                    }
                    //Add to Songs
                    if (!alb.getSongs().searchName(name))
                    {
                        
                        newSong = new Song(name, art, alb, year, Disc, index, URL);
                        
                        alb.getSongs().add(newSong);
                        
                        //alb.getSongs().sort();
                        
                        alb.setYear(year);

                        //Add image song in first song added
                        /*Console.WriteLine(newSong.getName());
                        Console.WriteLine(newSong.getArtist().getName());
                        Console.WriteLine(newSong.getAlbum().getName());
                        Console.WriteLine(newSong.getYear());
                        Console.WriteLine(newSong.GetDisc());
                        Console.WriteLine(newSong.getAlbumIndex());
                        Console.WriteLine(newSong.getURL());*/

                    }
                                        
                    if (add)
                    {
                        Artists.add(art);
                        //Artists.sort();
                        

                    }
                    }
                    

                }



            }
            lstSongs.Items.Clear();
            drawOnSongList();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void songInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstSongs.SelectedItems)
            {
                System.IO.Stream albumResponseStream;
                int it = item.Index;
                Song song = Artists.getTotalValue(it);
                Form2 data = new Form2();
                data.update(song.getName(), song.getArtist().getName(), song.getAlbum().getName(), song.getAlbumIndex().ToString(), song.getYear().ToString());
                data.ShowDialog();

                song.setName(data.SongName);
                Artist art = changeArtist(data.SongArtist);
                song.setArtist(art);//Change only for the song
                Album alb = changeAlbum(data.SongAlbum, art);
                song.setAlbum(alb);//Change only for the album
                uint indexer = touInt(data.Index);
                song.setAlbumIndex(indexer);
                uint yeari = touInt(data.Year);
                song.setYear(yeari);

                lstSongs.Items.Clear();
                drawOnSongList();

                if (data.Sync == true)
                {
                    try
                    {
                        string API_KEY = "3d0dcf1274bfd9661a56e69161c405e1";
                        string API_SECRET = "67f9285e92ec64c788ad56cf6cb5a27d";

                        Session session = new Session(API_KEY, API_SECRET);

                        Lastfm.ProxySupport.Proxy = new System.Net.WebProxy("221.2.216.38", 8080);

                        // Test it out...
                        Track track = new Track(art.getName(), song.getName(), session);
                        //Console.WriteLine(track.Title + ", "+ track.Artist.Name + ", " + track.GetAlbum().Name);
                        //Set Metadata
                        song.setName(track.Title);
                        Artist LastArtist = changeArtist(track.Artist.Name);
                        //Image for Artist
                        System.Net.WebRequest artistRequest = System.Net.WebRequest.Create(track.Artist.GetImageURL());
                        System.Net.WebResponse artistResponse = artistRequest.GetResponse();
                        System.IO.Stream artistResponseStream =
                            artistResponse.GetResponseStream();
                        Image img = Image.FromStream(artistResponseStream);
                        LastArtist.SetImage(new Bitmap(img, new Size(50, 50)));



                        song.setArtist(LastArtist);//Change only for the song
                        Album LastAlbum = changeAlbum(track.GetAlbum().Name, LastArtist);
                        //Image for Album
                        System.Net.WebRequest albumRequest = System.Net.WebRequest.Create(track.GetAlbum().GetImageURL());
                        System.Net.WebResponse albumResponse = albumRequest.GetResponse();
                        albumResponseStream = albumResponse.GetResponseStream();

                        LastAlbum.SetBitImage(new Bitmap(albumResponseStream));
                        song.setAlbum(LastAlbum);//Change only for the album

                        //uint LastIndex = touInt(track.);
                        //song.setAlbumIndex(indexer);
                        //uint LasyYear = touInt(track.GetAlbum().;
                        //song.setYear(yeari);
                    }
                    catch
                    {

                    }


                }

                //Edit File Metadata
                TagLib.File tip = TagLib.File.Create(song.getURL());
                tip.Tag.Title = song.getName();
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                tip.Tag.Artists[0] = song.getArtist().getName();
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
                tip.Tag.Album = song.getAlbum().getName();
                tip.Tag.Year = song.getYear();
                tip.Tag.Track = song.getAlbumIndex();



                try{
                    tip.Save();
                }
                catch
                {

                }
            
                lstSongs.Items.Clear();
                drawOnSongList();


            }
            
        }
        private Artist changeArtist(string Name)
        {
            Artist art;
            if (Artists.searchName(Name))
            {
                art = Artists.searchArtist(Name);
            }
            else
            {
                art = new Artist(Name, Properties.Resources.descarga__2_);
                Artists.add(art);
            }
            return art;
        }
        private Album changeAlbum(string Name, Artist art)
        {
            Album alb;
            if (art.getAlbums().searchName(Name))
            {
                alb = Artists.searchArtist(art.getName()).getAlbums().searchAlbum(Name);
            }
            else
            {
                alb = new Album(Name, art, Properties.Resources.album);
                art.getAlbums().add(alb);

            }
            return alb;
        }
        public uint touInt(String str)
        {
            uint value = Convert.ToUInt32(str);
            return value;
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            playPrev();
        }

        private void toolStripContainer2_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripContainer4_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip3_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            //SongOrAlbumLV1 = false;
            listView1.FullRowSelect = true;
            listView1.Groups.Clear();
            listView1.Items.Clear();
            AlbumForArtist.Images.Clear();
            listView1.Visible = true;
            ToolStripItem var = e.ClickedItem;
            Console.WriteLine(var.Name);
            Artist art = Artists.searchArtist(var.Name);
            for (int i = 0; i < art.getAlbums().getLength(); i++)
            {
                Album alb = art.getAlbums().getValue(i);
                AlbumForArtist.Images.Add(alb.GetBitImage());
                ListViewGroup albumArt = new ListViewGroup(alb.getName(), HorizontalAlignment.Left);
                albumArt.Name = alb.getName();
                listView1.Groups.Add(albumArt);
                Console.WriteLine("album"+listView1.Groups[i].Name);
                //listView1.Items.Add(new ListViewItem("", i,albumArt)); #Tried to display image



                for (int j = 0; j < alb.getSongs().getLength(); j++)
                {
                    Song song = alb.getSongs().getValue(j);
                    ListViewItem songArt = new ListViewItem(song.getName(), albumArt);
                    songArt.Name = song.getName();
                    
                    albumArt.Items[j].Text = song.getAlbumIndex().ToString();
                    songArt.SubItems.Add(song.getName());
                    songArt.SubItems.Add(setTime(TagLib.File.Create(song.getURL()).Properties.Duration.ToString()));
                    songArt.SubItems.Add(song.getArtist().getName());
                    Console.WriteLine("song"+albumArt.Items[j].Name);
                    listView1.Items.Add(songArt);
                }


            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)//edit
        {
            foreach(ListViewItem album in listView1.SelectedItems){
                if (!SongOrAlbumLV1)
                {
                    //listView1.Items.Clear();
                    //Album alb = album.Name;
                }
                
            }
       
        }

        private void listView1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                listView1.FullRowSelect = true;
                Console.WriteLine("detecta click");
                //ListViewHitTestInfo hit = listView1.HitTest(e.Location);
                ListViewItem lista = listView1.SelectedItems[0];
                {
                    songQueue.empty();
                    for (int i = lista.Index; i < listView1.Items.Count; i++)
                    {
                        String art = listView1.Items[i].SubItems[3].Text;
                        String alb = listView1.Items[i].Group.Header;
                        String nam = listView1.Items[i].SubItems[0].Name;
                        Console.WriteLine(art +","+ alb + "," + nam);
                        enqueueSong(art,alb,nam);
                        Console.WriteLine("intenta encolar las canciones");

                    }

                    playSong();
                }
            }

        }

        private void recomendToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void playLaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in lstSongs.SelectedItems)
            {
                enqueueSong(lista);

            }
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in lstSongs.SelectedItems)
            {
                Song song = Artists.getTotalValue(lista.Index);
                song.setRating(0);
                lstSongs.Items.Clear();
                drawOnSongList();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in lstSongs.SelectedItems)
            {
                Song song = Artists.getTotalValue(lista.Index);
                song.setRating(1);
                lstSongs.Items.Clear();
                drawOnSongList();
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in lstSongs.SelectedItems)
            {
                Song song = Artists.getTotalValue(lista.Index);
                song.setRating(2);
                lstSongs.Items.Clear();
                drawOnSongList();
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in lstSongs.SelectedItems)
            {
                Song song = Artists.getTotalValue(lista.Index);
                song.setRating(3);
                lstSongs.Items.Clear();
                drawOnSongList();
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in lstSongs.SelectedItems)
            {
                Song song = Artists.getTotalValue(lista.Index);
                song.setRating(4);
                lstSongs.Items.Clear();
                drawOnSongList();
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in lstSongs.SelectedItems)
            {
                Song song = Artists.getTotalValue(lista.Index);
                song.setRating(5);
                lstSongs.Items.Clear();
                drawOnSongList();

            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Library.Visible = true;
            Messenger.Visible = false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Messenger.Visible = true;
            Library.Visible = false;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
