using System.Data;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Test.MVVM.ViewModel
{
    public class DiscoveryViewModel : INotifyPropertyChanged
    {
        private DataTable _dataTable;
        public DataTable DataTable
        {
            get { return _dataTable; }
            set
            {
                _dataTable = value;
                OnPropertyChanged();
            }
        }

        public DiscoveryViewModel()
        {
            LoadData();
        }

        private void LoadData()
        {
            // Replace this with your service call to fetch data
            DataTable = new DataTable();
            DataTable.Columns.Add("Column1");
            DataTable.Columns.Add("Column2");
            DataTable.Rows.Add("Row1-Column1", "Row1-Column2");
            DataTable.Rows.Add("Row2-Column1", "Row2-Column2");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}