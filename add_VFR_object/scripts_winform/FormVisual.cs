using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;

namespace WindowsForms_add_water_tower
{   
    public partial class FormVisual : Form
    {
        
        public FormVisual()
        {
            InitializeComponent();
            StreamReader sr_params = new StreamReader("./param_objects.txt");
            string line;
            string[] parse;

            try
            {
                line = sr_params.ReadLine();
                while (line != null)
                {
                    parse = line.Split(';');
                    Image img = Image.FromFile("./img/"+parse[0]+".png");
                    dataGridView1.Rows.Add(parse[0],img);
                    line = sr_params.ReadLine();
                }
                sr_params.Close();

            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e.Message);
            }


        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
