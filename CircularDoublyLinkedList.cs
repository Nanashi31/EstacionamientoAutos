using System;

namespace EstacionamientoAutos
{
    internal class Node
    {
        public Car Car { get; set; }
        public Node? Next { get; set; }
        public Node? Previous { get; set; }

        public Node(Car car)
        {
            Car = car;
            Next = null;
            Previous = null;
        }
    }

    public class CircularDoublyLinkedList
    {
        private Node? head;
        private int count;

        public CircularDoublyLinkedList()
        {
            head = null;
            count = 0;
        }

        public void Enqueue(Car car)
        {
            Node newNode = new Node(car);
            if (head == null)
            {
                head = newNode;
                head.Next = head;
                head.Previous = head;
            }
            else
            {
                Node? tail = head.Previous;
                if (tail != null)
                {
                    tail.Next = newNode;
                    newNode.Previous = tail;
                    newNode.Next = head;
                    head.Previous = newNode;
                }
            }
            count++;
        }

        public Car? Dequeue()
        {
            if (head == null)
            {
                return null;
            }

            Car car = head.Car;

            if (count == 1)
            {
                head = null;
            }
            else
            {
                Node? tail = head.Previous;
                head = head.Next;
                if (head != null && tail != null)
                {
                    head.Previous = tail;
                    tail.Next = head;
                }
            }
            count--;
            return car;
        }

        public Car? Peek()
        {
            return head?.Car;
        }

        public int Count()
        {
            return count;
        }

        public Car[] ToArray()
        {
            if (head == null)
            {
                return new Car[0];
            }

            Car[] array = new Car[count];
            Node? current = head;
            for (int i = 0; i < count; i++)
            {
                if (current != null)
                {
                    array[i] = current.Car;
                    current = current.Next;
                }
            }
            return array;
        }
    }
}
