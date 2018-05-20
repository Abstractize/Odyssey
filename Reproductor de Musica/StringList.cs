using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    public class StringList
    {
        //Atributos
        private Node<String> head;
        private int length;
        //Constructor

        //Validador de Lista Vacia
        public bool empty()
        {
            return head == null;
        }
        //Metodos
        

        private void swapSongs(int i, int j)
        {
            String temp = this.getValue(i);
            this.swap(this.getValue(j), i);
            this.swap(temp, j);
        }
        public void add(String value)
        {//Agregar un miembro a la hilera al final
            Node<String> New = new Node<String>(value);
            if (empty())
            {
                head = New;
            }
            else
            {
                Node<String> aux = head;
                while (aux.getNext() != null)
                {
                    aux = aux.getNext();
                }
                aux.setNext(New);
            }
            length++;
        }
        public bool search(String reference)
        {
            Node<String> aux = head;
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
        
       
        public void delete(String reference)
        {//Elimina un miembro por referencia
            if (search(reference))
            {
                if (head.getValue() == reference)
                {
                    head = head.getNext();
                }
                else
                {
                    Node<String> aux = head;
                    while (aux.getNext().getValue() != reference)
                    {
                        aux = aux.getNext();
                    }
                    Node<String> next = aux.getNext().getNext();
                    aux.setNext(next);
                }
                length--;
            }
        }
        public int getIndex(String reference)
        {
            int index = 0;
            Node<String> aux = head;
            String item = null;
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
        public String getValue(String reference)
        {
            Node<String> aux = head;
            String item = null;
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
        public String getValue(int pos)
        {//Obtener valor por referencia
            if (pos >= 0 && pos < length)
            {
                if (pos == 0)
                {
                    return head.getValue();
                }
                else
                {
                    Node<String> aux = head;
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
        public void swap(String reference, int pos)
        {
            if (pos >= 0 && pos < length)
            {
                if (pos == 0)
                {
                    head.setValue(reference);
                }
                else
                {
                    Node<String> aux = head;
                    for (int i = 0; i < pos; i++)
                    {
                        aux = aux.getNext();
                    }
                    aux.setValue(reference);
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < this.getLength(); i++)
            {
                Console.WriteLine(this.getValue(i));
            }
        }
        //Getters y Setters
        public Node<String> getHead()
        {
            return head;
        }

        public void setHead(Node<String> head)
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
