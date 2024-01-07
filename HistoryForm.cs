using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class HistoryForm : Form
    {
        private readonly string _username;
        private HistoryController _historyController;
        private DatabaseController _dbController;
        private Panel panel;


        public HistoryForm(string userName)
        {
            InitializeComponent();
            _username = userName;

            SetupColumns();
            SetupForm();
            ResizeColumns();

            Resize += HistoryForm_Resize;
        }

        private void SetupColumns()
        {
            historyListView.Columns.Add("Location");
            historyListView.Columns.Add("Temperature");
            historyListView.Columns.Add("Conditions");
            historyListView.Columns.Add("Date");
            historyListView.View = View.Details;
        }

        private void ResizeColumns()
        {
            int totalWidth = historyListView.ClientSize.Width;

            foreach (ColumnHeader column in historyListView.Columns)
            {
                column.Width = totalWidth / historyListView.Columns.Count;
            }
        }


        private void SetupForm()
        {
            panel = new Panel
            {
                AutoScroll = true,
                Dock = DockStyle.Fill
            };

            panel.Controls.Add(historyListView);
            Controls.Add(panel);
        }

        private void HistoryForm_Resize(object sender, EventArgs e)
        {
            panel.Size = ClientSize;
            historyListView.Size = panel.ClientSize;

            ResizeColumns();
        }



        private void HistoryForm_Load(object sender, EventArgs e)
        {
            PopulateHistoryListView();
        }

        public void PopulateHistoryListView()
        {
            historyListView.Items.Clear();

            _dbController = new DatabaseController();
            _historyController = new HistoryController(_dbController.GetConnect());

            List<HistoryRecord> historyRecords = _historyController.GetHistoryByUsername(_username);

            if (historyRecords == null)
            {
                return;
            }


            foreach (HistoryRecord record in historyRecords)
            {

                AddListItem(historyListView, record);
            }
            _historyController.Dispose();
            _dbController.Dispose();
        }

        private void AddListItem(System.Windows.Forms.ListView listView, HistoryRecord record)
        {
            ListViewItem listItem = new ListViewItem(record.Location);
            listItem.SubItems.Add(record.Temperature.ToString());
            listItem.SubItems.Add(record.Conditions);
            listItem.SubItems.Add($"{record.Date.ToShortDateString()} at {record.Date.ToShortTimeString()}");
            listView.Items.Add(listItem);
        }
    }
}
