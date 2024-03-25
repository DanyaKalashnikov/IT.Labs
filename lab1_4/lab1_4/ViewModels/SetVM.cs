using lab1_4.Models;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Windows;

namespace lab1_4.ViewModel
{
    public class SetVM : BindableBase
    {
        #region Fields
        private readonly ISet _set = new Set();
        private String _newItem;
        private Int32 _count;
        #endregion

        #region Commands
        public DelegateCommand AddCommand { get; private set; }
        public DelegateCommand RemoveCommand { get; private set; }
        public DelegateCommand ClearCommand { get; private set; }
        public DelegateCommand ContainsCommand { get; private set; }
        public ObservableCollection<string> Items { get; private set; } = new ObservableCollection<string>();
        #endregion

        #region Constructors
        public SetVM()
        {
            AddCommand = new DelegateCommand(AddItem);
            RemoveCommand = new DelegateCommand(RemoveItem);
            ClearCommand = new DelegateCommand(ClearSet);
            ContainsCommand = new DelegateCommand(ContainsItem);

            Count = Items.Count;
        }
        #endregion

        #region Private Realisation
        private void AddItem()
        {
            if (Items.Contains(_newItem) || _newItem == "")
            {
                MessageBox.Show("This element already exist or you trying to add an empty element", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            _set.Add(_newItem);
            Items.Add(_newItem);
            _newItem = "";

            Count = Items.Count;
        }

        private void RemoveItem()
        {
            if(Items.Contains(_newItem))
            {
                _set.Remove(_newItem);
                Items.Remove(_newItem);
            }
            else
            {
                MessageBox.Show("Not found or you trying to remove an empty element", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            Count = Items.Count;
        }

        private void ContainsItem()
        {
            if (Items.Contains(_newItem))
            {
                MessageBox.Show("True", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                MessageBox.Show("False", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ClearSet()
        {
            _set.Clear();
            Items.Clear();

            Count = Items.Count;
        }
        #endregion

        #region Properties
        public string NewItem
        {
            get => _newItem;
            set => SetProperty(ref _newItem, value);

        }

        public Int32 Count
        {
            get => _count;
            set => SetProperty(ref _count, value);
        }
        #endregion
    }
}
