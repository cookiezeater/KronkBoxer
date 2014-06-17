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
using System.Diagnostics;
using System.IO;

namespace KronkBoxer
{
    public partial class FrmMain : Form
    {
        public List<Keys> keysToSend = new List<Keys>();
        public List<Panel> panels = new List<Panel>();
        public List<Client> clients = new List<Client>();
        public int running = 0; //0 = stopped, 1 = running, 2 = paused

        public ControlPad controlPad;

        public FrmMain()
        {
            InitializeComponent();

            //Populate keys listboxes
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            {
                lstKeys.Items.Add(key.ToString());
                lstTPAllKey.Items.Add(key.ToString());
            }
            lstKeys.SelectedIndex = 0;
            //Panels available for clients to be parented to
            panels.Add(splitTop.Panel1);
            panels.Add(splitTop.Panel2);
            panels.Add(splitBottom.Panel1);
            panels.Add(splitBottom.Panel2);
            numClients.Maximum = panels.Count;
            //Load config
            numClients.Value = Config.Default.numClients;
            tbxClientPath.Text = Config.Default.clientPath;
            tbxMainPlayer.Text = Config.Default.mainPlayer;
            tbxKeysToSend.Text = Config.Default.keysToSend;
            lstTPAllKey.SelectedItem = Config.Default.macroTPKey;
            foreach (string s in Config.Default.keysToSend.Split(','))
                if (s.Length > 0)
                    keysToSend.Add((Keys)Enum.Parse(typeof(Keys), s));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Client c in clients)
                if (!c.clientProcess.HasExited)
                    c.clientProcess.Kill();

            Config.Default.numClients = (int)numClients.Value;
            Config.Default.mainPlayer = tbxMainPlayer.Text;

            Config.Default.Save();
        }

        public void btnToggle_Click(object sender, EventArgs e)
        {
            if (running == 0) //start
            {
                if (!File.Exists(tbxClientPath.Text))
                {
                    MessageBox.Show("Invalid file path chosen for the client to be used.", "KronkBoxer");
                    return;
                }

                btnToggle.ImageIndex = 1;
                btnToggle.BackColor = Color.FromArgb(220, 0, 0);

                int count = (int)numClients.Value;

                try
                {
                    for (int i = 0; i < count; i++)
                        clients.Add(new Client(panels[i], tbxClientPath.Text));
                }
                catch
                {
                    MessageBox.Show("You have not set .SWF files to open with Flash Player Projector.\nPlease download it from here:\nhttp://download.macromedia.com/pub/flashplayer/updaters/14/flashplayer_14_sa.exe\nAnd then set it to open with flashplayer_14_sa by right clicking your client and clicking Open With.");
                    clients.Clear();

                    btnToggle.ImageIndex = 0;
                    btnToggle.BackColor = Color.FromArgb(60, 170, 60);

                    return;
                }

                controlPad = new ControlPad(this);
                controlPad.Show();

                running = 1;
                lblStatus.Text = "Running [" + clients.Count + "]";
            }
            else //stop
            {
                btnToggle.ImageIndex = 0;
                btnToggle.BackColor = Color.FromArgb(60, 170, 60);

                foreach (Client c in clients)
                    if (!c.clientProcess.HasExited)
                        c.clientProcess.Kill();

                clients.Clear();

                running = 0;
                lblStatus.Text = "Stopped";

                controlPad.Close();
                controlPad = null;
            }
        }

        private PerformanceCounter perfCPU =
            new PerformanceCounter("Processor", "% Processor Time", "_Total");
        public int autoTP = 0;

        private void tmrChecker_Tick(object sender, EventArgs e)
        {
            //Performance
            lblPerformance.Text = "CPU " + (int)perfCPU.NextValue() + "%  |  RAM: ";

            for (int i = 0; i < clients.Count; i++)
                if (!clients[i].clientProcess.HasExited)
                    lblPerformance.Text += "[" + i + "] " + clients[i].clientProcess.VirtualMemorySize64 / 1024 / 1024 + "mb   :   ";

            lblPerformance.Location = new Point(this.Width - 50 - lblPerformance.Size.Width, lblPerformance.Location.Y);

            //Auto T
            if (autoTP > 0)
                autoTP--;

            lblTPCountdown.Text = "Able to teleport in " + autoTP + "...";

            if (autoTP == 0 && chkAutoTeleport.Checked && running == 1)
                controlPad.Teleport();
        }

        private void btnClientBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog FD = new OpenFileDialog();

            if (FD.ShowDialog() == DialogResult.OK)
                tbxClientPath.Text = FD.FileName;
        }

        private void btnConfigKeys_Click(object sender, EventArgs e)
        {
            pnlSettings.Visible = !pnlSettings.Visible;
        }


        private void btnAddKey_Click(object sender, EventArgs e)
        {
            if (lstKeys.SelectedIndex > 0)
            {
                if (tbxKeysToSend.Text.EndsWith(","))
                    tbxKeysToSend.Text += lstKeys.Items[lstKeys.SelectedIndex].ToString();
                else
                    tbxKeysToSend.Text += "," + lstKeys.Items[lstKeys.SelectedIndex].ToString();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string s in tbxKeysToSend.Text.Split(','))
                    if (s.Length > 0)
                        Enum.Parse(typeof(Keys), s);
            }
            catch
            {
                MessageBox.Show("Input was invalid.\nPlease make sure you're using only valid names of keys and are seperating them with commas (NO SPACES).\n\nFor a list of key names, please refer to http://msdn.microsoft.com/en-us/library/system.windows.forms.keys.aspx", "KronkBoxer Key Config");
                return;
            }

            keysToSend.Clear();

            foreach (string s in tbxKeysToSend.Text.Split(','))
                if (s.Length > 0)
                    keysToSend.Add((Keys)Enum.Parse(typeof(Keys), s));

            Config.Default.macroTPKey = lstTPAllKey.Items[lstTPAllKey.SelectedIndex].ToString();
            Config.Default.keysToSend = tbxKeysToSend.Text;
            Config.Default.clientPath = tbxClientPath.Text;
            Config.Default.Save();

            pnlSettings.Visible = false;
        }

        private void lblKeysInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://msdn.microsoft.com/en-us/library/system.windows.forms.keys.aspx");
        }
    }
}
