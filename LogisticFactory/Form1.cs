using LogisticFactory.Factory;
using LogisticFactory.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticFactory
{
    public partial class Form1 : Form
    {
        List<Label> labels = new List<Label>();
        Timer timer = new Timer();
        int i = 0;
        int limit = 0;

        public Form1()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            timer.Interval = 500;
            labels.Add(Truck1);
            labels.Add(Truck2);
            labels.Add(Truck3);
            labels.Add(Truck4);
            labels.Add(Ship1);
            labels.Add(Ship2);
            labels.Add(Ship3);
            labels.Add(Ship4);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            textBox1.Clear();

            if (cbTruck.Checked && cbShip.Checked)
            {
                i = 0;
                limit = 8;
                timer.Start();
            }
            else
            {
                if (cbTruck.Checked)
                {
                    i = 0;
                    limit = 4;
                    timer.Start();
                }
                else
                {
                    if (cbShip.Checked)
                    {
                        i = 4;
                        limit = 8;
                        timer.Start();
                    }
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (i == limit)
            {
                labels[i - 1].Visible = false;
                timer.Stop();

                if (cbTruck.Checked && cbShip.Checked)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = true;
                    ITransport truck = TransportFactory.RequestTransport("Truck");
                    textBox1.Text += truck.Deliver();
                    ITransport ship = TransportFactory.RequestTransport("Ship");
                    textBox1.Text += " And " + ship.Deliver();
                }
                else
                {
                    if (cbTruck.Checked)
                    {
                        pictureBox3.Visible = true;
                        ITransport truck = TransportFactory.RequestTransport("Truck");
                        textBox1.Text += truck.Deliver();
                    }
                    else
                    {
                        ITransport ship = TransportFactory.RequestTransport("Ship");
                        textBox1.Text += ship.Deliver();
                        pictureBox2.Visible = true;
                    }
                }
                return;
            }

            if (i == 0)
            {
                labels[i].Visible = true;
            }
            else
            {
                labels[i - 1].Visible = false;
                labels[i].Visible = true;
            }

            i++;
        }
    }
}
