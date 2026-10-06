using System.Collections.Generic;
using UnityEngine;

namespace MidtermExam.Prob02
{
    public class LinkedListSorter
    {
        public LinkedList<int> SortAscending(LinkedList<int> list)
        {
            InsertionSort(list, ascending: true);
            return list;
        }

        public LinkedList<int> SortDescending(LinkedList<int> list)
        {
            InsertionSort(list, ascending: false);
            return list;
        }

        private void InsertionSort(LinkedList<int> list, bool ascending)
        {
            if (list == null || list.Count < 2) return;

            LinkedListNode<int> current = list.First.Next;

            while (current != null)
            {
                LinkedListNode<int> next = current.Next;   
                LinkedListNode<int> pos = current.Previous;

                
                while (pos != null &&
                       (ascending ? pos.Value > current.Value
                                  : pos.Value < current.Value))
                {
                    pos = pos.Previous;
                }

                
                if (pos != current.Previous)
                {
                    list.Remove(current);
                    if (pos == null) list.AddFirst(current);
                    else list.AddAfter(pos, current);
                }

                current = next;
            }
        }
    }
}