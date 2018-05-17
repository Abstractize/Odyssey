using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    class Queue<Type>
    {
        private Node<Type> head;
        private int length;
        public void empty()
        {
            head = null;
        }
        public void enqueue(Type item)
        {
            Node<Type> aux = new Node<Type>(item);
            if (head == null)
            {
                head = aux;
            }
            else
            {
                Node<Type> current = head;
                while (current.getNext() != null)
                {
                    current = current.getNext();
                }
                current.setNext(aux);
            }
            length++;
        }
        public void dequeue()
        {
            if (head != null)
            {
                head = head.getNext();
            }
            length--;
        }
        public Type peek()
        {
            return head.getValue();
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
