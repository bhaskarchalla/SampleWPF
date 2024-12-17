using Test.MVVM.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Test.MVVM.View
{
    public partial class DiscoveryView : UserControl
    {
        public DiscoveryView()
        {
            InitializeComponent();
            this.DataContext = new DiscoveryViewModel();
        }

        private void DataGrid_CopyingRowClipboardContent(object sender, DataGridRowClipboardEventArgs e)
        {
            // Custom logic for copying row content
        }

        private void DataGrid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.V && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
            {
                PasteClipboardContent();
                e.Handled = true;
            }
        }

        private void PasteClipboardContent()
        {
            try
            {
                var clipboardContent = Clipboard.GetText();
                if (string.IsNullOrEmpty(clipboardContent))
                    return;

                var rows = clipboardContent.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                var dataTable = ((DiscoveryViewModel)this.DataContext).DataTable;

                foreach (var row in rows)
                {
                    var columns = row.Split('\t');
                    var dataRow = dataTable.NewRow();
                    for (int i = 0; i < columns.Length && i < dataTable.Columns.Count; i++)
                    {
                        dataRow[i] = columns[i];
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error pasting content: {ex.Message}");
            }
        }
    }
}