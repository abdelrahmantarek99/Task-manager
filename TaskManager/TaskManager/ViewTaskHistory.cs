using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class ViewTaskHistory : UserControl
    {
        Form form;
        ViewTaskHistoryForm viewTaskHistoryForm;
        int id;
        public ViewTaskHistory()
        {
            InitializeComponent();
        }

        public void initialize(Form form, ViewTaskHistoryForm viewTaskHistoryForm, int id)
        {
            this.form = form;
            this.viewTaskHistoryForm = viewTaskHistoryForm;
            this.id = id;
        }

        private void ViewTaskHistory_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            viewTaskHistoryForm.Dispose();
            form.Show();
        }
    }
}
