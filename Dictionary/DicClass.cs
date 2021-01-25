using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace Dictionary
{
    class DicClass<A, B>
        {
            A[] key;
            B[] value;

            public DicClass()
            {
                key = new A[0];
                value = new B[0];
            }

            public void Add(A keys, B values)
            {
                A[] tempKey = key;
                B[] tempValue = value;


                key = new A[key.Length + 1];
                value = new B[key.Length + 1];

                for (int i = 0; i < tempKey.Length; i++)
                {
                    key[i] = tempKey[i];
                    value[i] = tempValue[i];

                }

                key[key.Length - 1] = keys;
                value[value.Length - 1] = values;

            }

     

        }





    

}
