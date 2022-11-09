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
            Console.Write("\nMasukkan Nama Mahasiswa: ");
            nm = Console.ReadLine();
            Node nodebaru = new Node();
            nodebaru.noMhs = nim;
            nodebaru.nama = nm;

            if (START == null || nim <= START.noMhs) /* Node ditambahkan sebagai node pertama*/
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nNomer Mahasiswa sama tidak diizinkan");
                    return;
                }
                nodebaru.next = START;
                START = nodebaru;
                return;
            }

            /*Menemukan lokasi node baru didalam list*/

            Node previous, current;
            previous = START;
            current = START;

            while ((current != null) && (nim >= current.noMhs))
            {
                if ( nim == current.noMhs)
                {
                    Console.WriteLine("\nNomer mahasiswa sama tidak diizinkan\n");
                    return ;
                }
                previous = current;
                current = current.next; 
            }
            /*Node baru akan ditempatkan diantara previous dan current*/

            nodebaru.next = current;
            previous.next = nodebaru;

        }
        /*Method untuk menghapus node tertentu didalam list*/
        public bool delNode(int nim)
        {
            Node previous, current;
            previous = current = null;
            /*Checl apakah node yang dimaksud ada didalam list atau tidak*/
            if(Search(nim,ref previous, ref current) == false)
                return false;
            previous.next = current.next;
            if (current == START)
                START = START.next;
            return true;
        }

        /*Method untuk mengecheck apakah node yang dimaksudkan ada didalam list*/
        public bool Search(int nim,ref Node previous,ref Node current)
        {
            previous = START;
            current = START;

            while ((current != null) && (nim != current.noMhs))
            {
                previous = current;
                current = current.next;
            }

            if (current == null)
                return (false);
            else
                return (true);
        }
        /*Method untuk Traverse/mengunjungi dan membaca isi list*/
        public void traverse()
        {
            if (ListEmpty())
                Console.WriteLine("\nList Kosong. \n");
            else
            {
                Console.WriteLine("\nData didalam list adalah : \n");
                Node currentNode;
                for (currentNode = START; currentNode != null; currentNode = currentNode.next)
                Console.Write(currentNode.noMhs + " " + currentNode.nama + "\n");
                Console.WriteLine();
            }
        }

        public bool ListEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
