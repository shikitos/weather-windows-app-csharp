using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class HistoryForm : Form
    {
        private readonly string username;
        DatabaseController dbController;
        public HistoryForm(string userName)
        {
            InitializeComponent();

            dbController = MainForm.Instance.DatabaseController;
            username = userName;
            this.historyListView.Columns.Add("Location");
            this.historyListView.Columns.Add("Temperature");
            this.historyListView.Columns.Add("Conditions");
            this.historyListView.View = View.Details;
        }


        private void HistoryObjectApply()
        {
            /*SettingsUpdated?.Invoke(Fetch);*/
            Dispose();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            PopulateHistoryListView();
        }

        private void PopulateHistoryListView()
        {
            List<HistoryRecord> historyRecords = dbController.GetHistoryByUsername(username);

            if (historyRecords == null)
            {
                return;
            }

            foreach (HistoryRecord record in historyRecords)
            {

                ListViewItem listItem = new ListViewItem(record.Location); // Set the Text property for the first column
                listItem.SubItems.Add(record.Temperature.ToString("F2"));
                listItem.SubItems.Add(record.Conditions);
                historyListView.Items.Add(listItem);
            }
        }

        private void historyListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (historyListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = historyListView.SelectedItems[0];

                string location = selectedItem.SubItems[0].Text;
                string temperature = selectedItem.SubItems[1].Text;
                string conditions = selectedItem.SubItems[2].Text;


                MessageBox.Show($"location: {location}, temp: {temperature}, conditions: {conditions}");

            }
        }


    }
}
