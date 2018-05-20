using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    /// <summary>
    /// Class to store the diferent Songs
    /// </summary>
    public class List
    {
        //Atributos
        private Node<Song> head;
        private int length;
        //Constructor

        //Validador de Lista Vacia
        public bool empty()
        {
            return head == null;
        }
        //Metodos
        public void quickSort(int lowerIndex, int higherIndex)
        {//Quicksort
            int init = lowerIndex;
            int finit = higherIndex;

            //calculate pivot number
            Song pivot = this.getValue(init + (finit - init) / 2);
            //
            while (init <= finit)
            {
                while (this.getValue(init).GetDisc() <= pivot.GetDisc())
                {
                    if (this.getValue(init).GetDisc() < pivot.GetDisc())
                    {
                        init++;
                    }
                    else
                    {
                        if (this.getValue(init).getAlbumIndex() < pivot.getAlbumIndex())
                        {
                            init++;
                        }
                    }
                }
                while (this.getValue(finit).GetDisc() >= pivot.GetDisc())
                {
                    if (this.getValue(finit).GetDisc() > pivot.GetDisc())
                    {
                        finit++;
                    }
                    else
                    {
                        if (this.getValue(init).getAlbumIndex() > pivot.getAlbumIndex())
                        {
                            finit++;
                        }
                    }
                }
                if (init <= finit)
                {
                    swapSongs(init, finit);
                    //move index to next position on both sides
                    init++;
                    finit--;
                }
            }
            // call quickSort() method recursively
            if (lowerIndex < finit)
                quickSort(lowerIndex, finit);
            if (init < higherIndex)
                quickSort(init, higherIndex);
        }
        public void sort()
        {
            if (this.getLength() > 1)
            {
                this.quickSort(0, this.getLength() - 1);
            }
            
        }
        
        private void swapSongs(int i, int j)
        {
            Song temp = this.getValue(i);
            this.swap(this.getValue(j), i);
            this.swap(temp, j);
        }
        public void add(Song value)
        {//Agregar un miembro a la hilera al final
            Node<Song> New = new Node<Song>(value);
            if (empty())
            {
                head = New;
            }
            else
            {
                Node<Song> aux = head;
                while (aux.getNext() != null)
                {
                    aux = aux.getNext();
                }
                aux.setNext(New);
            }
            length++;
        }
        public bool search(Song reference)
        {
            Node<Song> aux = head;
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
        public Song searchSong(String reference)
        {
            Node<Song> aux = head;
            Song art = null;
            while (aux != null && art==null )
            {
                if (reference == aux.getValue().getName() )
                {
                    art = aux.getValue();
                }
                else
                {
                    aux = aux.getNext();
                }
            }
            return art;
        }
        public bool searchName(String reference)
        {
            Node<Song> aux = head;
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
        public void delete(Song reference)
        {//Elimina un miembro por referencia
            if (search(reference))
            {
                if (head.getValue() == reference)
                {
                    head = head.getNext();
                }
                else
                {
                    Node<Song> aux = head;
                    while (aux.getNext().getValue() != reference)
                    {
                        aux = aux.getNext();
                    }
                    Node<Song> next = aux.getNext().getNext();
                    aux.setNext(next);
                }
                length--;
            }
        }
        public int getIndex(Song reference)
        {
            int index = 0;
            Node<Song> aux = head;
            Song item = null;
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
        public Song getValue(Song reference)
        {
            Node<Song> aux = head;
            Song item = null;
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
        public Song getValue(int pos)
        {//Obtener valor por referencia
            if (pos >= 0 && pos < length)
            {
                if (pos == 0)
                {
                    return head.getValue();
                }
                else
                {
                    Node<Song> aux = head;
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
        public void swap(Song reference, int pos)
        {
            if (pos >= 0 && pos < length)
            {
                if (pos == 0)
                {
                    head.setValue(reference);
                }
                else
                {
                    Node<Song> aux = head;
                    for (int i = 0; i < pos; i++)
                    {
                        aux = aux.getNext();
                    }
                    aux.setValue(reference);
                }
            }
        }
        //Getters y Setters
        public Node<Song> getHead()
        {
            return head;
        }

        public void setHead(Node<Song> head)
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
