using System;
using System.Collections.Generic;
using System.Text;

namespace HM.CustomMyListClass.Models
{
    class MyList<T> where T: Student
    {
        private T[] arr;

        public MyList()
        {
            arr = new T[0];
        }
        public void Add(T data)
        {
            Array.Resize(ref arr, arr.Length + 10);
            arr[arr.Length - 10] = data;
        }
        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
