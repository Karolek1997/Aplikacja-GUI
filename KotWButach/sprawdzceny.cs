using System;
using System.Data;
using System.Windows.Forms;

namespace KotWButach
{
    public partial class sprawdzceny : Form
    {
        public DataGridView produktybezcenGrid; // Zmieniono nazwę zmiennej

        public sprawdzceny()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            produktybezcenGrid = new DataGridView(); // Zmieniono nazwę zmiennej
            produktybezcenGrid.Dock = DockStyle.Fill;
            Controls.Add(produktybezcenGrid);
        }
    }
}
