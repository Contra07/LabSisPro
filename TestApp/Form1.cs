using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var context = new MyDbContext())
            {
                List<Record> res = context.GetAll();
                var bindingList = new BindingList<Record>(res);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
            }
        }
    }
}
