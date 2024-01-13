using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int calis = 0;
            while (calis < 9) ;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Form1, uygulama başladığında görüntülenecek ana formdur.
            Application.Run(new Form1());
        }
    }
}
