using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_Linked_List
{

    class Node
    {
        public int noMhs;
        public string nama;
        public Node next;
    }

    class List
    {
        Node START;
        public List()
        {
            START = null;
        }

        public void addNote() /* Method untuk menambahkan sebuah Node kedalam list */
        {
            int nim;
            string nm;
            Console.Write("\nMasukkan Nomer Mahasiswa: ");
            nim = Convert.ToInt32(Console.ReadLine());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
