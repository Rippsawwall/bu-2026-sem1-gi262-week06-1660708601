using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MidtermExam.Prob02
{
    public class LinkedListSorter
    {
        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากน้อยไปมาก (Ascending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากน้อยไปมากแล้ว</returns>
        public LinkedList<int> SortAscending(LinkedList<int> list)
        {
            // TODO: Implement sorting algorithm for LinkedList<int> (Ascending)
            if (list == null || list.Count <= 1)
            {
                return list;
            }
            
            LinkedList<int> result = new LinkedList<int>();
            
            foreach (int i in list)
            {
                result.AddLast(i);
                if (i < result.Last.Value)
                {
                    LinkedListNode<int> node = result.Find(result.Last.Value);
                    result.AddBefore(node, i);
                }
            }

            return result;
        }

        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากมากไปน้อย (Descending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากมากไปน้อยแล้ว</returns>
        public LinkedList<int> SortDescending(LinkedList<int> list)
        {
            // TODO: Implement sorting algorithm for LinkedList<int> (Ascending)
            if (list == null || list.Count <= 1)
            {
                return list;
            }

            LinkedList<int> result = new LinkedList<int>();

            foreach (int i in list)
            {
                result.AddLast(i);
                if (i < result.Last.Value)
                {
                    LinkedListNode<int> node = result.Find(result.Last.Value);
                    result.AddBefore(node, i);
                }
            }

            return result;
        }
    }
}
