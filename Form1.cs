using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRpcDemo;

namespace DiscordRPC_Maker
{
   
    public partial class Form1 : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void label1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            pictureBox2.Visible = true;
            pictureBox1.Visible = true;
            button2.Visible = false;
            button3.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            button2.Visible = true;
            button3.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize(textBox5.Text, ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize(textBox5.Text, ref this.handlers, true, null);
            this.presence.details = textBox1.Text;
            this.presence.state = textBox2.Text;
            this.presence.largeImageKey = textBox6.Text;
            this.presence.smallImageKey = textBox7.Text;
            this.presence.largeImageText = textBox8.Text;
            this.presence.smallImageText = textBox9.Text;
            DiscordRpc.UpdatePresence(ref this.presence);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
