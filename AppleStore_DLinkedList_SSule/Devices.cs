using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppleStore_DLinkedList_SSule
{
    public class Devices<T>
    {
        public string Model { get; set; }
        public int Storage { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string Id { get; set; }
        public int Year { get; set; }
        public bool InStore { get; set; } // This is to track if the device is in the store

        public Devices(string model, int storage, string color, double price, string id, int year, bool inStore = true)
        { 
            Model = model;
            Storage = storage;
            Color = color;
            Price = price;
            Id = id;
            Year = year;
            InStore = inStore;
        }
        public void Device(string model, int storage, string color, double price, string id, int year, bool inStore = true)
        {
            if (!int.TryParse(id, out int _)) // Check if ID is a valid number
                throw new ArgumentException("Invalid ID. Please provide a valid numeric ID.");

            if (!int.TryParse(model, out int _)) // Check if model is a valid number
                throw new ArgumentException("Invalid model. Please provide a valid numeric model.");

            if (year < 0 || year > DateTime.Now.Year) // Check if year is a valid number
                throw new ArgumentException("Invalid year. Please provide a valid year.");

            if (price < 0) // Check if price is a valid number
                throw new ArgumentException("Invalid price. Please provide a valid price.");
        }

        public override string ToString()
        {
            return $"Model: {Model}, Storage: {Storage}GB, Color: {Color}, Price: ${Price}, ID: {Id}, Year: {Year}, InStore: {InStore}";
        }

        public class Node
        {
            public Devices<T> Device { get; set; }
            public Node Previous { get; set; }
            public Node Next { get; set; }

            public Node(Devices<T> device)
            {
                Device = device;
                Previous = Next = null;
            }
        }
        public class DoublyLinkedList
        {
            public Node Head { get; set; }
            public Node Tail { get; set; }
            public int count;

            public int Count
            {
                get { return count; }
            }

            public DoublyLinkedList()
            {
                Head = null;
                Tail = null;
                count = 0;
            }
            // method to add a devices to the list
            public void Add(Devices<T> device)
            {
                Node newNode = new Node(device);// create a new device
                if (Head == null) // if the list is empty
                {
                    Head = newNode;// set the head to the new node
                    Tail = newNode;// set the tail to the new node
                }
                else // if the list is not empty
                {
                    newNode.Previous = Tail;
                    Tail.Next = newNode;
                    Tail = newNode;
                }

                count++;// increment the count
            }
            // Core Method: Remove devices by their values
            public bool Remove(string id)
            {
                Node current = Head;
                while (current != null)
                {
                    if (current.Device.Id == id)
                    {
                        if (current == Head && current == Tail) // Single node
                        {
                            Head = Tail = null;
                        }
                        else if (current == Head) // Head node
                        {
                            Head = Head.Next;
                            Head.Previous = null;
                        }
                        else if (current == Tail) // Tail node
                        {
                            Tail = Tail.Previous;
                            Tail.Next = null;
                        }
                        else // Node in the middle
                        {
                            current.Previous.Next = current.Next;
                            current.Next.Previous = current.Previous;
                        }
                        return true;
                    }
                    current = current.Next;
                }
                return false; // Device not found
            }


            public Node Search(string model, int storage = 0) // Optional storage search
            {
                Node current = Head;
                while (current != null)
                {
                    if (current.Device.Model == model && (storage == 0 || current.Device.Storage == storage))
                    {
                        return current;
                    }
                    current = current.Next;
                }
                return null; // Device not found
            }

            public void PrintList()
            {
                Node current = Head;
                while (current != null)
                {
                    Console.WriteLine(current.Device);
                    current = current.Next;
                }
            }

            public void MergeSort()
            {
                Head = MergeSort(Head);
            }

            private Node MergeSort(Node head)
            {
                if (head == null || head.Next == null)
                    return head;

                // Find the middle of the list
                Node middle = GetMiddle(head);
                Node nextOfMiddle = middle.Next;

                // Split the list into two halves
                middle.Next = null;

                // Apply merge sort on the left and right halves
                Node left = MergeSort(head);
                Node right = MergeSort(nextOfMiddle);

                // Merge the sorted halves
                Node sortedList = Merge(left, right);
                return sortedList;
            }

            private Node Merge(Node left, Node right)
            {
                Node result = null;

                if (left == null)
                    return right;
                if (right == null)
                    return left;

                // Choose the smaller value
                if (left.Device.Model.CompareTo(right.Device.Model) <= 0)
                {
                    result = left;
                    result.Next = Merge(left.Next, right);
                    result.Next.Previous = result;
                }
                else
                {
                    result = right;
                    result.Next = Merge(left, right.Next);
                    result.Next.Previous = result;
                }

                return result;
            }

            private Node GetMiddle(Node head)
            {
                if (head == null)
                    return head;

                Node slow = head, fast = head;

                while (fast.Next != null && fast.Next.Next != null)
                {
                    slow = slow.Next;
                    fast = fast.Next.Next;
                }

                return slow;
            }

            public void InsertAfter(Devices<T> deviceToInsertAfter, Devices<T> deviceToInsert)
            {
                Node current = Head;
                while (current != null)
                {
                    if (current.Device == deviceToInsertAfter)
                    {
                        Node newNode = new Node(deviceToInsert);
                        newNode.Previous = current;
                        newNode.Next = current.Next;

                        if (current.Next != null)
                            current.Next.Previous = newNode;
                        else
                            Tail = newNode;

                        current.Next = newNode;
                        count++;
                        return;
                    }
                    current = current.Next;
                }
            }

            public void InsertBefore(Devices<T> deviceToInsertBefore, Devices<T> deviceToInsert)
            {
                Node current = Head;
                while (current != null)
                {
                    if (current.Device == deviceToInsertBefore)
                    {
                        Node newNode = new Node(deviceToInsert);
                        newNode.Next = current;
                        newNode.Previous = current.Previous;

                        if (current.Previous != null)
                            current.Previous.Next = newNode;
                        else
                            Head = newNode;

                        current.Previous = newNode;
                        count++;
                        return;
                    }
                    current = current.Next;
                }
            }

            public void Clear()
            {
                Head = null;
                Tail = null;
                count = 0;
            }


        }
    }
}
