﻿using System;
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
    public partial class Danhmuc : UserControl
    {
        public Danhmuc()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id_NhanVien;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectIndex = dataGridView1.CurrentRow.Index;
                id_NhanVien = dataGridView1["", selectIndex].Value;
            }
        }
    }
}
