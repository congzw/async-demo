using System;
using System.Windows.Forms;
using AsyncLibs;

namespace AsyncWinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Helper = new DemoHelper();
        }

        public DemoHelper Helper { get; set; }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            var result = Helper.GetInfo();
            this.txtResult.Text = result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnFoo_Click(object sender, EventArgs e)
        {
            this.textBox1.AppendText("Foo: " + DateTime.Now + Environment.NewLine);
        }

        private async void btnAsync_Click(object sender, EventArgs e)
        {
            //magic await:
            //1 wait and validate result
            //2 introduces a continuation which is code executed after async ops, and in original context(eg: UI thread, ex handling)

            //async void is bad, should only used in event handlers!(use async Task)

            //using async and await in asp.net means the web server can handle other requests

            //best practices
            //never use async void unless it's event handler or delegate



            var result = await Helper.GetInfoAsync();
            this.txtResult.Text = result;
        }
    }
}
