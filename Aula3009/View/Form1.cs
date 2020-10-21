using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;

namespace Aula3009
{
    public partial class Principal : Form
    {
        private Form currentChildForm;
        private Panel leftBorderBtn;
        private IconButton currentBtn;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwn, int wMsg, int wParam, int lParam);

        private void pnlMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public Principal()
        {      
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            pnlMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }        

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }        

        private void ibtnDashboard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new frmDashboard());
        }

        private void ibtnOrders_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new frmOrders());
        }

        private void ibtnProdutos_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new frmProdutos());
        }

        private void ibtnClientes_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            OpenChildForm(new frmClientes());
        }

        private void ibtnMarketing_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            OpenChildForm(new frmMarketing());
        }

        private void ibtnFerramentas_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
            OpenChildForm(new frmFerramentas());
        }

        private void ibtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlBody.Controls.Add(childForm);
            pnlBody.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
            lblTitulo.Text = childForm.Text;
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 118, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                ibtnHome.IconChar = currentBtn.IconChar;
                ibtnHome.IconColor = color;
                lblTitulo.ForeColor = color;
            }
        }
    }
}
