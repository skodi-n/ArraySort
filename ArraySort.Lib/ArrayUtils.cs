using System;
using System.IO;

namespace ArraySort.Lib
{
    public class ArrayUtils
    {
        private int[] _numbers;

        public ArrayUtils()
        {
            
            _numbers = new int[] { 5, 9, 20, 21, 7, 2, 10};
            
        }

        void Insert(int number)
        {
        }

        public void Fill(int maxNumber, bool doSort = false)
        {
        }

        void Swap(int index1, int index2)
        {
            int i1 = _numbers[index1];
            int i2 = _numbers[index2];
            
            _numbers[index1] = i2;
            _numbers[index2] = i1;
        }

        public SearchResult SearchInUnsorted(int numberToSearch)
        {
            int loops = 0;

            for (int i = 0; i < _numbers.Length; i++)
            {
                loops++;
                if (_numbers[i] == numberToSearch)
                {
                    return new SearchResult(numberToSearch, loops, true);
                }
            }
            return new SearchResult(numberToSearch, loops, false);
        }

        public void WriteToConsole()
        {
            for (int i = 0; i < _numbers.Length - 1; i++)
            {
                Console.Write(_numbers[i]);
                Console.Write("-");
            }
            Console.WriteLine(_numbers[_numbers.Length - 1]);
        }
        
        public void WriteToFile(string path)
        {
            

            if (_numbers.Length < 25)
            {
                StreamWriter sw = new StreamWriter(path);
                for (int i = 0; i < _numbers.Length - 1; i++)
                {
                    
                    sw.Write(_numbers[i]);
                    sw.Write("-");
                    
                }
                
                sw.WriteLine(_numbers[_numbers.Length - 1]);
                sw.Close();
                

            }
            
            
        }

            #region Aufgabenstellung D (SelectionSort / MaxSort)
        private int GetMaximumIndex(int lastsortedindex)
        {
            int maxIndex = 0;
            
            for (int i = 0; i <= lastsortedindex; i++)
            {
                if (_numbers[maxIndex] < _numbers[i])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public void MaxSort()
        {
            for (int i = _numbers.Length - 1; i > 0; i--)
            {
                
                int maxIndex = GetMaximumIndex(i);
                Swap(maxIndex, i);
                
            }
            
            
            
        }
        #endregion

        #region Aufgabenstellung E (searching in sorted data)
        public bool Sorted
        {
            get
            {
                return false;
            }
        }

        public SearchResult SearchLinear(int numberToSearch)
        {
            return null;
        }

        public SearchResult SearchBinary(int numberToSearch)
        {
            return null;
        }
        #endregion

        #region Weitere Aufgabenstellung (Insertion Sort)
        private void ShiftRight(int startIndex)
        {
        }
        private void InsertSort(int number)
        {
        }
        #endregion

        #region Weitere Aufgabenstellung (Bogosort, Bubblesort)
        public bool BogoSort(int maxTries = 1000000)
        {
            return false;
        }
        public void BubbleSort()
        {
        }
        #endregion

    }
}
