using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivServiceClientApp
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client client = null;
        public Form1()
        {
            InitializeComponent();
            client = new ServiceReference1.Service1Client("NetTcpBinding_IService1");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "Result: " + client.div(Convert.ToInt32(tbNum.Text), Convert.ToInt32(tbDen.Text));
            }
            catch (FaultException<ServiceReference1.DivideFault> obj)
            {
                label3.Text = obj.Detail.Error + " " + obj.Detail.Details;
            }
        }
    }
}
