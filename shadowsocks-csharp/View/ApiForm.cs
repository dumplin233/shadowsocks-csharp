using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Shadowsocks.Controller;
using Shadowsocks.Model;
using Shadowsocks.Properties;

namespace Shadowsocks.View
{
    public partial class ApiForm : Form
    {
        private ShadowsocksController controller;
        // this is a copy of configuration that we are working on
        private Configuration _modifiedConfiguration;

        public ApiForm(ShadowsocksController controller)
        {
            this.Font = System.Drawing.SystemFonts.MessageBoxFont;
            InitializeComponent();
            this.Icon = Icon.FromHandle(Resources.ssw128.GetHicon());
            this.controller = controller;
            LoadCurrentConfiguration();
            UpdateTexts();
        }

        private void LoadCurrentConfiguration()
        {
            _modifiedConfiguration = controller.GetConfiguration();
        }

        private void UpdateTexts()
        {
            //Configuration config = controller.GetCurrentConfiguration();
            textBox1.Text = _modifiedConfiguration.ApiEmail;
            textBox2.Text = _modifiedConfiguration.ApiPassword;
            textBox3.Text = _modifiedConfiguration.ApiUrl;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _modifiedConfiguration.ApiEmail = textBox1.Text;
            _modifiedConfiguration.ApiPassword = textBox2.Text;
            _modifiedConfiguration.ApiUrl = textBox3.Text;
            controller.SaveServersConfig(_modifiedConfiguration);
            //Configuration cfg = Configuration.Load();
            //Configuration.SetApiSettings(textBox1.Text, textBox2.Text, textBox3.Text);
            //Configuration.Save(cfg);
            Close();
        }
    }
}
