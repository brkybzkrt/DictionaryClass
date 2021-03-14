using System;
using System.Collections.Generic;
using System.Text;

namespace DictonaryClass
{
    class MyDictionary<Tkey ,Tvalue>
    {

         (Tkey,Tvalue)[] list;

        public MyDictionary()
        {
            list=new (Tkey,Tvalue)[0];
        }



        public void Ekle(Tkey key,Tvalue value) // dictionary listemize yeni eleman ekleme actionu
        {
            (Tkey, Tvalue)[] templArray = list;

            list = new (Tkey, Tvalue)[list.Length + 1];

            for (int i = 0; i < templArray.Length; i++)
            {
                list[i] = templArray[i];
            }

            list[list.Length-1]=(key,value);
        }

       

        public int Length // dictionary listemizin kaç elemanlı olduğu gösteren properties 
        {
            get { return list.Length; }
            
        }

    }
}
