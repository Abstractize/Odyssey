using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    class ArtistList
    {
        //Atributos
        private Node<Artist> head;
        private int length;
        //Constructor

        //Validador de Lista Vacia
        public bool empty()
        {
            return head == null;
        }
        //Metodos
        public void add(Artist value)
        {//Agregar un miembro a la hilera al final
            Node<Artist> New = new Node<Artist>(value);
            if (empty())
            {
                head = New;
            }
            else
            {
                Node<Artist> aux = head;
                while (aux.getNext() != null)
                {
                    aux = aux.getNext();
                }
                aux.setNext(New);
            }
            length++;
        }
        public bool search(Artist reference)
        {
            Node<Artist> aux = head;
            bool flag = false;
            while (aux != null && flag != true)
            {
                if (reference == aux.getValue())
                {
                    flag = true;
                }
                else
                {
                    aux = aux.getNext();
                }
            }
            return flag;
        }
        public int getMaxChar()
        {//Gets the max length of word with most characters
            int max = 0;
            for (int i = 0; i < this.getLength(); i++)
            {
                int num = 0;
                try
                {
                    num = this.getValue(i).getName().Length;
                }
                catch
                {

                }
                    
                

                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
        public int toValue(String artist, int pos, int arraylen)
        {//Gets the value of the evaluating character (0-26)
            int value = 0;
            String art = artist.ToLower();
            char[] arr = new char[arraylen];
            for (int i = 0; i < arraylen; i++)
            {
                if (i < art.Length)
                {
                    if (!Char.IsLetter(art.ElementAt(i)))
                    {//Changes space for accent
                        arr[i] = '`';
                    }
                    else
                    {
                        arr[i] = art.ElementAt(i);
                    }
                }
                else
                {//Adds accent when finilized
                    arr[i] = '`';
                }
            }
            value = (((int)arr[pos]) - 96);
            return value;
        }
        public void sort()//Need to quit
        {//RadixSort
            int max = this.getMaxChar();
            int loop = max;
            Queue<Artist> queue = new Queue<Artist>();
            for (int i = 0; i < this.getLength(); i++)
            {
                queue.enqueue(this.getValue(i));
            }
            //@SuppressWarnings("unchecked")
    
        Queue<Artist>[] arr = new Queue<Artist>[27];
            //Creates a Queue for all the spots in the Array
            for (int i = 0; i < 27; i++)
            {
                Queue<Artist> aux = new Queue<Artist>();
                arr[i] = aux;
            }
            while (loop > 0)
            {
                for (int i = 0; i < this.getLength(); i++)
                {
                    int num = toValue(queue.peek().getName(), loop - 1, max);
                    arr[num].enqueue(queue.peek());
                    queue.dequeue();
                }
                for (int i = 0; i < 27; i++)
                {
                    int len = arr[i].getLength();
                    for (int j = 0; j < len; j++)
                    {
                        queue.enqueue(arr[i].peek());
                        arr[i].dequeue();
                    }
                }
                loop--;
            }
            int large = this.getLength();
            this.erase();
            for (int i = 0; i < large; i++)
            {
                this.add(queue.peek());
                queue.dequeue();
            }
        }
        public Artist searchArtist(String reference)
        {
            Node<Artist> aux = head;
            Console.WriteLine("Getting artist...");
            Artist art = null;
            while (aux != null && art == null)
            {
                if (reference == aux.getValue().getName())
                {
                    art = aux.getValue();
                    Console.WriteLine("Artist Found");
                }
                else
                {
                    aux = aux.getNext();
                    Console.WriteLine("Getting artist...");
                }
            }
            return art;
        }
        public bool searchName(String reference)
        {
            Node<Artist> aux = head;
            bool flag = false;
            while (aux != null && flag != true)
            {
                if (reference == aux.getValue().getName())
                {
                    flag = true;
                }
                else
                {
                    aux = aux.getNext();
                }
            }
            return flag;
        }
        public void delete(Artist reference)
        {//Elimina un miembro por referencia
            if (search(reference))
            {
                if (head.getValue() == reference)
                {
                    head = head.getNext();
                }
                else
                {
                    Node<Artist> aux = head;
                    while (aux.getNext().getValue() != reference)
                    {
                        aux = aux.getNext();
                    }
                    Node<Artist> next = aux.getNext().getNext();
                    aux.setNext(next);
                }
                length--;
            }
        }
        public Song getTotalValue(int pos)
        {
            Node<Artist> art = head;
            Node<Album> alb = art.getValue().getAlbums().getHead();
            Node<Song> song = alb.getValue().getSongs().getHead();
            for (int i=0; i < pos; i++)
            {
                song = song.getNext();
                if (song == null)
                {
                    alb = alb.getNext();
                    if (alb != null)
                    {
                        song = alb.getValue().getSongs().getHead();
                    }
                    
                }
                if (alb == null)
                {
                    art = art.getNext();
                    alb = art.getValue().getAlbums().getHead();
                    song = alb.getValue().getSongs().getHead();
                }
                
            }
            return song.getValue();
        }
        public int getIndex(Artist reference)
        {
            int index = 0;
            Node<Artist> aux = head;
            Artist item = null;
            while (aux != null && item == null)
            {
                if (reference == aux.getValue())
                {
                    item = aux.getValue();
                }
                else
                {
                    aux = aux.getNext();
                    index++;
                }
            }
            return index;
        }
        public Artist getValue(Artist reference)
        {
            Node<Artist> aux = head;
            Artist item = null;
            while (aux != null && item == null)
            {
                if (reference == aux.getValue())
                {
                    item = aux.getValue();
                }
                else
                {
                    aux = aux.getNext();
                }
            }
            return item;
        }
        public void erase()
        {//Elimina la lista
            head = null;
            length = 0;
        }
        public Artist getValue(int pos)
        {//Obtener valor por referencia
            if (pos >= 0 && pos < length)
            {
                if (pos == 0)
                {
                    return head.getValue();
                }
                else
                {
                    Node<Artist> aux = head;
                    for (int i = 0; i < pos; i++)
                    {
                        aux = aux.getNext();
                    }
                    return aux.getValue();
                }
            }
            else
            {
                return null;
            }
        }
        public void swap(Artist reference, int pos)
        {
            if (pos >= 0 && pos < length)
            {
                if (pos == 0)
                {
                    head.setValue(reference);
                }
                else
                {
                    Node<Artist> aux = head;
                    for (int i = 0; i < pos; i++)
                    {
                        aux = aux.getNext();
                    }
                    aux.setValue(reference);
                }
            }
        }
        //Getters y Setters
        public Node<Artist> getHead()
        {
            return head;
        }

        public void setHead(Node<Artist> head)
        {
            this.head = head;
        }

        public int getLength()
        {
            return length;
        }

        public void setLength(int length)
        {
            this.length = length;
        }
    }
}
