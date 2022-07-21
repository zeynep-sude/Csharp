using System;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
           MyDictionary<string> myDictionary = new MyDictionary<string>();
            myDictionary.Add("Tutunamayanlar");
            myDictionary.Add("Tehlikeli Oyunlar");
            myDictionary.Add("Korkuyu Beklerken");

            foreach (var item  in myDictionary.Items)
            {
                Console.WriteLine(item);
            }
        }
        class MyDictionary<K>
        {
            K[] items;
            public MyDictionary()
            {
                items = new K[0];
            }
            public void Add(K item)
            {
                K[] array = items;

                items = new K[items.Length + 1];
                for (int i = 0; i <array.Length; i++)
                {
                    items[i] = array[i];
                }

                items[items.Length - 1] = item;
              }
            public K[] Items
            {
                get { return items; }
            }
        }
    }
   
}
