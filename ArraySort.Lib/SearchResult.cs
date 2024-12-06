namespace ArraySort.Lib
{
    public class SearchResult
    {
        #region instance variables
        private int _numberSearched;
        private int _loopsNeeded;
        private bool _numberFoundInArray;
        #endregion

        #region properties
        public bool NumberFound
        {
            get
            {
                return _numberFoundInArray;
            }
        }
        #endregion

        #region constructor
        public SearchResult(int number, int loops, bool found)
        {
            _numberSearched = number;
            _loopsNeeded = loops;
            _numberFoundInArray = found;
        }
        #endregion

        #region methods
        public string GetInfo()
        {
            string info = _numberSearched + " was ";
            if (!_numberFoundInArray)
            {
                info += "not ";
            }
            info = info + string.Format($"found ({_loopsNeeded} loops).");

            return info;
        }
        #endregion
    }
}
