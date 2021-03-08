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
    public partial class FormConfirm : Form
    {
        
        public FormConfirm()
        {
            InitializeComponent();

            try
            {
                string[] o_files = Directory.GetFiles(@"./object_datas", "*.csv");
                checkedListBox1.Items.Clear();

                foreach (string o_file in o_files)
                {
                    checkedListBox1.Items.Add(o_file.Split('\\')[1]);
                }
                checkedListBox1.SelectedItem = o_files[0].Split('\\')[1];
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e.Message);
            }


        }

        private void checkBoxSelAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSelAll.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            string parameters_batch = "";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                parameters_batch += ("../object_datas/" + checkedListBox1.CheckedItems[i] + " ");

            }
    
            string relpath = "./exec_form.bat";
            string exactPath = Path.GetFullPath(relpath);
            Process.Start(exactPath,parameters_batch);
            Close();


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
