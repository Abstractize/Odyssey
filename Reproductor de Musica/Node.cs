using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    public class Node<T>
    {
        private T value;
        private Node<T> next;

        public Node(T item)
        {
            this.setValue(item);
            this.setNext(null);
        }

        public T getValue()
        {
            return value;
        }

        public void setValue(T value)
        {
            this.value = value;
        }

        public Node<T> getNext()
        {
            return next;
        }

        public void setNext(Node<T> next)
        {
            this.next = next;
        }
    }
}
