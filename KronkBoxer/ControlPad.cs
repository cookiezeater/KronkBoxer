using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KronkBoxer
{
    public partial class ControlPad : Form
    {
        public FrmMain main;

        public List<Keys> pressedKeys = new List<Keys>();

        public bool leftMouse = false;

        public ControlPad(FrmMain owner)
        {
            main = owner;
            InitializeComponent();

            for (int i = 0; i < main.clients.Count; i++)
                lstClients.Items.Add("Client " + i);

            lstClients.SelectedIndex = 0;

            numRefreshRate.Value = (decimal)Config.Default.refreshRate;
        }

        public async Task Teleport() //Because async is better for this kind of thing
        {
            string player = "";

            main.Invoke((MethodInvoker)delegate() { player = main.tbxMainPlayer.Text; });
            main.autoTP = 11;

            foreach (Keys keyDown in pressedKeys.ToArray()) //Send all the keys up so they don't interfere with the /tp
                foreach (Client c in main.clients)
                    Native.SendUp(c.clientProcess, keyDown);

            foreach (Client c in main.clients)
                Native.SendString(c.clientProcess, "/teleport " + player);

            foreach (Keys keyDown in pressedKeys.ToArray()) //Since this is async, some keys may be up now - but they were removed from pressedKeys, so sending all of them down will be still accurate.
                foreach (Client c in main.clients)
                    Native.SendDown(c.clientProcess, keyDown);
        }

        private void ControlPad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (main.running != 0)
            {
                Config.Default.refreshRate = (float)numRefreshRate.Value;
                Config.Default.Save();

                tmrSS.Stop();
                main.btnToggle_Click(null, null);
            }
        }

        private void tmrSS_Tick(object sender, EventArgs e)
        {
            if (main.running == 1)
            {
                if (pbxClient.Image != null)
                    pbxClient.Image.Dispose();

                pbxClient.Image = null;
                pbxClient.Image = Native.CaptureApplication(main.clients[lstClients.SelectedIndex].clientProcess.MainWindowHandle);
            }
        }

        private void ControlPad_KeyDown(object sender, KeyEventArgs e)
        {
            if (main.running == 1 && main.keysToSend.Contains(e.KeyCode))
            {
                pressedKeys.Add(e.KeyCode);

                foreach (Client c in main.clients)
                    Native.SendDown(c.clientProcess, e.KeyCode);
            }
        }

        private void ControlPad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys)Enum.Parse(typeof(Keys), Config.Default.macroTPKey))
                Teleport();

            if (main.running == 1 && main.keysToSend.Contains(e.KeyCode))
            {
                //pressedKeys.Remove(e.KeyCode); this wont work because it's removing instances of that REFERENCE
                foreach (Keys key in pressedKeys.ToArray())
                    if (object.Equals(key, e.KeyCode)) 
                        pressedKeys.Remove(key);

                foreach (Client c in main.clients)
                    Native.SendUp(c.clientProcess, e.KeyCode);
            }
        }

        private void numRefreshRate_ValueChanged(object sender, EventArgs e)
        {
            tmrSS.Interval = (int)numRefreshRate.Value;
        }

        private void pbxClient_Click(object sender, EventArgs e)
        {
            pbxClient.Focus();
        }

        private void pbxClient_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (Client c in main.clients)
            {
                Point p = RelativePosition(e.Location, c.clientProcess);
                Native.BackgroundMousePosition(c.clientProcess, p.X, p.Y);
            }
        }

        private void pbxClient_MouseDown(object sender, MouseEventArgs e)
        {
            leftMouse = true;
            foreach (Client c in main.clients)
            {
                Point p = RelativePosition(e.Location, c.clientProcess);
                Native.BackgroundMouseDown(c.clientProcess, p.X, p.Y);
            }
        }

        private void pbxClient_MouseUp(object sender, MouseEventArgs e)
        {
            leftMouse = false;
            foreach (Client c in main.clients)
            {
                Point p = RelativePosition(e.Location, c.clientProcess);
                Native.BackgroundMouseUp(c.clientProcess, p.X, p.Y);
            }
        }

        private Point RelativePosition(Point pos, System.Diagnostics.Process p)
        {
            Size actual = Native.GetWindowSize(p); //size of the other window

            float percentX = (float)actual.Width / (float)pbxClient.Size.Width;// other window / the one that was clicked
            float percentY = (float)actual.Height / (float)pbxClient.Size.Height; // other window / the one that was clicked

            return new Point((int)(percentX * pos.X), (int)(percentY * pos.Y) - 20); //-20 due to menu bar offset
        }
    }
}
