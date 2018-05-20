using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    public class AlbumList
    {
        /// <summary>
        /// Class that stores albums for the user to get them in an order
        /// </summary>

        //Atributos
        private Node<Album> head;
        private int length;
        //Constructor

        //Validador de Lista Vacia
        public bool empty()
        {
            return head == null;
        }
        //Metodos
        public void sort(String sort)//Need to quit
        {
            if (sort == "name")
            {//Orden alfabético del Album
                bool sorted = false;
                int large = this.getLength() - 1;
                while (!sorted)
                {
                    sorted = true;
                    for (int index = 0; index < large; index++)
                    {
                        String albumName1 = this.getValue(index).getName();
                        String albumName2 = this.getValue(index + 1).getName();
                        if (albumName1.ToLower().CompareTo(albumName2) > 0)
                        {
                            sorted = false;
                            Album hold = this.getValue(index + 1);
                            this.swap(this.getValue(index), index + 1);
                            this.swap(hold, index);
                        }
                    }
                    large--;
                }
            }
            else if (sort == "year")
            {//Año
                bool sorted = false;
                int large = this.getLength() - 1;
                while (!sorted)
                {
                    sorted = true;
                    for (int index = 0; index < large; index++)
                    {
                        uint albumYear1 = this.getValue(index).getYear();
                        uint albumYear2 = this.getValue(index + 1).getYear();
                        if (albumYear1 > albumYear2)
                        {
                            Album hold = this.getValue(index + 1);
                            this.swap(this.getValue(index), index + 1);
                            this.swap(hold, index);
                        }
                    }
                    large--;
                }
            }
        }
        public void add(Album value)
        {//Agregar un miembro a la hilera al final
            Node<Album> New = new Node<Album>(value);
            if (empty())
            {
                head = New;
            }
            else
            {
                Node<Album> aux = head;
                while (aux.getNext() != null)
                {
                    aux = aux.getNext();
                }
                aux.setNext(New);
            }
            length++;
        }
        public bool search(Album reference)
        {
            Node<Album> aux = head;
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
        public Album searchAlbum(String reference)
        {
            Node<Album> aux = head;
            Album art = null;
            while (aux != null && art == null)
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
            Node<Album> aux = head;
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
        public void delete(Album reference)
        {//Elimina un miembro por referencia
            if (search(reference))
            {
                if (head.getValue() == reference)
                {
                    head = head.getNext();
                }
                else
                {
                    Node<Album> aux = head;
                    while (aux.getNext().getValue() != reference)
                    {
                        aux = aux.getNext();
                    }
                    Node<Album> next = aux.getNext().getNext();
                    aux.setNext(next);
                }
                length--;
            }
        }
        public int getIndex(Album reference)
        {
            int index = 0;
            Node<Album> aux = head;
            Album item = null;
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
        public Album getValue(Album reference)
        {
            Node<Album> aux = head;
            Album item = null;
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
        public Album getValue(int pos)
        {//Obtener valor por referencia
            if (pos >= 0 && pos < length)
            {
                if (pos == 0)
                {
                    return head.getValue();
                }
                else
                {
                    Node<Album> aux = head;
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
        public void swap(Album reference, int pos)
        {
            if (pos >= 0 && pos < length)
            {
                if (pos == 0)
                {
                    head.setValue(reference);
                }
                else
                {
                    Node<Album> aux = head;
                    for (int i = 0; i < pos; i++)
                    {
                        aux = aux.getNext();
                    }
                    aux.setValue(reference);
                }
            }
        }
        //Getters y Setters
        public Node<Album> getHead()
        {
            return head;
        }

        public void setHead(Node<Album> head)
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
