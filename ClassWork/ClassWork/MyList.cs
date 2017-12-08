using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class MyList : IEnumerable
    {
        private string[] _array;

        public MyList(string[] args)
        {
            _array = args;
        }
            
        public IEnumerator GetEnumerator()
        {
            return new MyListEnumerator(_array);
        }

        private class MyListEnumerator : IEnumerator
        {
            private string[] _array;
            private int _index = -1;

            public MyListEnumerator(string[] array)
            {
                _array = array;
            }

            public object Current => _array[_index]; // the same as below
            //public object Current
            //{
            //    get
            //    {
            //        return _array[_index];
            //    }
            //}

            public bool MoveNext()
            {
                _index++;                
                return _index < _array.Length; 
            }

            public void Reset()
            {
                _index = -1; // return index in 0 position
            }
        }
    }
}
