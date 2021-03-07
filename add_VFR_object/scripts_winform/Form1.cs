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
   // public enum VFR_objects {water_tower=0,aerial};
    public partial class Form1 : Form
    {
        private static string Path_csv;
        private static string[] o_files;
        public DataTable object_table;
        public static string default_VFR_obj;
        public Form1()
        {   
            InitializeComponent();
            StreamReader sr_params = new StreamReader("./param_objects.txt");
            string line;
            string[] parse;

            try
            {
                line = sr_params.ReadLine();
                int i = 0;
                while (line != null)
                {
                    parse = line.Split(';');
                    object_table.Rows.Add(i,parse[0]);
                    line = sr_params.ReadLine();
                    i++;
                }
                default_VFR_obj = (string)(object_table.Rows[0])["Name"];
                sr_params.Close();
                
            }
            catch (Exception e_params)
            {
                Debug.WriteLine("Exception: " + e_params.Message);
            }

            
            object_type.DefaultCellStyle.NullValue = object_table.Rows[0]["Name"];
            object_type.DefaultCellStyle.DataSourceNullValue = object_table.Rows[0]["Name"];
            Debug.WriteLine(object_type.DefaultCellStyle.NullValue);
            Debug.WriteLine(object_type.DefaultCellStyle.DataSourceNullValue);

            refresh_open();
            if (o_files.Length > 0)
            {
                Path_csv = o_files[0];
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   StreamWriter sw = new StreamWriter("C:\\Users\\ultra\\source\\repos\\WindowsForms_add_water_tower\\water_tower.xml",false);
         //   sw.WriteLine("<?xml version=\"1.0\"?>\n<FSData version=\"9.0\">");
            StreamWriter sw = new StreamWriter(Path_csv, false);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    if (row.Cells[1].Value!=null)
                    {
 //                       sw.WriteLine("\t < !--SceneryObject name: Water_Tower_FR-- >");
                        Debug.WriteLine("Val : " + row.Cells[0].Value + row.Cells[1].Value + row.Cells[2].Value + row.Cells[3].Value + row.Cells[4].Value);
                        //                       sw.WriteLine("\t < SceneryObject lat =\"{0}\" lon=\"{1}\" alt=\"0.00000000000000\" pitch=\"0.000068\" bank=\"-0.000068\" heading=\"-179.999991\" imageComplexity=\"VERY_SPARSE\" altitudeIsAgl=\"TRUE\" snapToGround=\"TRUE\" snapToNormal=\"FALSE\">\n\t\t<LibraryObject name=\"{2}{3}{4}\" scale=\"{5}\"/>\n\t</SceneryObject>", col.Cells[1].Value.ToString(), col.Cells[2].Value.ToString(), "{", "93EE3F27 - 3429 - 4CC7 - A9CC - 0FB5ED33AFC2", "}", col.Cells[3].Value.ToString());
                        int int_combo=0;
                        if (row.Cells[0].Value != null)
                        {
                            int_combo = (int)row.Cells[0].Value;
                        }
                        sw.WriteLine("{0};{1};{2};{3};{4}", int_combo, row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString());
                    }
                }
                catch (Exception e2)
                {
                    Debug.WriteLine("Exception: " + e2.Message);
                }
            }
         //   sw.WriteLine("</FSData>");
            sw.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void compile_Click(object sender, EventArgs e)
        {
            FormConfirm f = new FormConfirm();
            f.ShowDialog();
        }

        private void add_object_Click(object sender, EventArgs e)
        {
            try
            {
                string[] parse_obj;
                parse_obj = textBox1.Text.Split(new[] { ", " }, StringSplitOptions.None);
                dataGridView1.Rows.Add(0,"", parse_obj[0], parse_obj[1], "15.0");
                textBox1.Text = "";
            }
            catch (Exception e_add)
            {
                Debug.WriteLine("Exception: " + e_add.Message);
            }
        }

        private void refresh_open()
        {
            try
            {
                o_files = Directory.GetFiles(@"./object_datas", "*.csv");
                listOpen.Items.Clear();
                
                foreach(string o_file in o_files)
                {
                    listOpen.Items.Add(o_file.Split('\\')[1]);
                }
                listOpen.SelectedItem=o_files[0].Split('\\')[1];
            }
            catch(Exception e)
            {
                Debug.WriteLine("Exception: " + e.Message);
            }
            
        }

        private void refresh_table()
        {
            String line;
            string[] parse;

            //            float lat, lon, scale;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(Path_csv);
                //Read the first line of text
                line = sr.ReadLine();
                dataGridView1.Rows.Clear();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Debug.WriteLine(line);
                    parse = line.Split(';');
                    int obj = int.Parse(parse[0]);
                    dataGridView1.Rows.Add(obj, parse[1], parse[2], parse[3],parse[4]);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                //     Console.ReadLine();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Debug.WriteLine("Executing finally block.");
            }
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            Path_csv = "./object_datas/" + listOpen.SelectedItem;
            refresh_table();
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            Path_csv = "./object_datas/" + new_text.Text + ".csv";
            FileStream fs_n = File.Create(Path_csv);
            fs_n.Close();
            refresh_open();
            refresh_table();
            listOpen.SelectedItem = new_text.Text + ".csv";
            new_text.Text = "";
        }
    }
}
