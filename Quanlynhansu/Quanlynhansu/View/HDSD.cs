using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlynhansu.View
{
    public partial class HDSD : Form
    {
        public HDSD()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            wbrChucnang.Navigate("HuongDanSuDung/them.mht");
        }
    }
}
