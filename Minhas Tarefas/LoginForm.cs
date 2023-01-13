using System;
using System.Drawing;
using System.Windows.Forms;

namespace Minhas_Tarefas
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string caminho = "../../imgs/";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.CenterToScreen();
            this.Text = "Minhas Tarefas";
            this.Icon = new Icon(caminho + "icon.ico");
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
    }
}
