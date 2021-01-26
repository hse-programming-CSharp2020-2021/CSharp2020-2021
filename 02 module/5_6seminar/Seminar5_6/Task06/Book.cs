namespace Task06
{
    class Book
    {
        int _countPages;
        int _sectionNumber;

        public Book(int countPages, int sectionNumber)
        {
            CountPages = countPages;
            SectionNumber = sectionNumber;
        }
        
        public int CountPages
        {
            get { return _countPages; }
            internal set { _countPages = value; }
        }

        public int SectionNumber
        {
            get { return _sectionNumber; }
            internal set { _sectionNumber = value; }
        }

        public override string ToString()
        {
            return $"Pages = {_countPages}, Sectios = {_sectionNumber}";
        }
    }
}
