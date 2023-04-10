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
using System.Xml.Linq;
using System.Security.Policy;
using System.Threading;

namespace 学习通音频解锁助手
{
    public partial class MediaContainerForm : Form
    {
        MainMenu mnuMain = new MainMenu();
        MenuItem WindowMenu;
        string UrlIn;
        public MediaContainerForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            Control.CheckForIllegalCrossThreadCalls = false;
            WindowMenu = new MenuItem();
            WindowMenu.Text = "窗口(&W)";
            WindowMenu.MenuItems.Add("窗体层叠(&C)", new EventHandler(Cascade_Click));
            WindowMenu.MenuItems.Add("水平平铺(&H)", new EventHandler(TileH_Click));
            WindowMenu.MenuItems.Add("垂直平铺(&V)", new EventHandler(TileV_Click));
            WindowMenu.MenuItems.Add("清除所有窗口(&A)", new EventHandler(Clear_Click));
            WindowMenu.MdiList = true;
            mnuMain.MenuItems.Add(WindowMenu);
            this.Menu = mnuMain;
        }

        private void Cascade_Click(object sender, EventArgs e)
        //实现对主窗体中的MDI窗体的层叠操作
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void TileH_Click(object sender, EventArgs e)
        //实现对主窗体中的MDI窗体的水平平铺操作
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void TileV_Click(object sender, EventArgs e)
        //实现对主窗体中的MDI窗体的垂直平铺操作
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void Clear_Click(object sender, EventArgs e)
        //实现对主窗体中的MDI窗体全部清除
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }
    }
}
