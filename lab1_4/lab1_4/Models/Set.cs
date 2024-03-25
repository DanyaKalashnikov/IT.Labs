using lab1_4.Models;

namespace lab1_4
{
    public class Set : ISet
    {
        #region Fields
        const Int32 N = 10;

        private List<String> _items;
        private Int32 _count;
        #endregion

        #region Constructors
        public Set()
        {
            _items = new List<String>();
        }
        #endregion

        #region Realization
        public void Add(String item)
        {
            if (_items.Contains(item))
            {
                return;
            }

            _items.Add(item);
        }

        public void Remove(String item)
        {
            _items.Remove(item);
            --_count;
        }

        public Boolean Contains(String item)
        {
            return _items.Contains(item);
        }

        public void Clear()
        {
            _count = 0;
            _items.Clear();
        }
        #endregion

        #region Properties
        public Boolean IsEmpty
        {
            get => _count == 0;
        }

        public Int32 Count
        {
            get => _count;
        }

        
        #endregion
    }
}
