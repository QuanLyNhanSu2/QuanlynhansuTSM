using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlynhansu.View
{
    public partial class LuongCongTi : UserControl
    {
        public LuongCongTi()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int luongID = 0;
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.CurrentRow.Index;
                luongID = int.Parse(dataGridView1["LuongID", selectedIndex].Value.ToString());

            }
            string cm = "delete from Luong where LuongID =" + luongID;

        }
    }
}
