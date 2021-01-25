using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboScale.Items.Add("0.01");
            cboScale.Items.Add("0.03");
            cboScale.Items.Add("0.04");
            cboScale.Items.Add("0.1");
            cboScale.Items.Add("0.3");
            cboScale.Items.Add("0.6");
            cboScale.Items.Add("1");
            cboScale.Items.Add("2");
            cboScale.Items.Add("3");
            cboScale.Items.Add("4");
            cboScale.SelectedIndex = 6;
            axTimelineControl1.SetPreviewWnd((int)pictureBox1.Handle);


        }

        private void button1_Click(object sender, EventArgs e)
        {

            //openFileDialog1.Filter= "All Files (*.*)|*.*|JPEG (*.jpg) | *.jpg||";
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    string strFile = openFileDialog1.FileName;
            //    axTimelineControl1.SetVideoTrackResolution(1024, 768);
            //    axTimelineControl1.AddImageClip(3, strFile, 0, 10, 0);
            //    //axTimelineControl1.DecoderFilterAddToList(strFile);
            //}

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox1.Text = folderBrowserDialog1.SelectedPath;
                DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
                FileInfo[] imageFiles = dir.GetFiles("*.json");
                //string strFile = Convert.ToString(imageFiles);                    
                foreach (FileInfo item in imageFiles)
                {
                    JObject o1 = JObject.Parse(File.ReadAllText(@"c:\videogames.json"));

                    // read JSON directly from a file
                    using (StreamReader file = File.OpenText(@"c:\videogames.json"))
                    using (JsonTextReader reader = new JsonTextReader(file))
                    {
                        JObject o2 = (JObject)JToken.ReadFrom(reader);
                    }
                    //axTimelineControl1.SetVideoTrackResolution(1024, 768);
                    //axTimelineControl1.AddImageClip(3, Convert.ToString(textBox1.Text + "\\" + item.Name), 0, 0.9f, 0);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files (*.*)|*.*|MP3 (*.mp3) | *.mp3||";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string strFile = openFileDialog1.FileName;
                axTimelineControl1.AddAudioClip(5, strFile, 0, 30, 0, 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            axTimelineControl1.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axTimelineControl1.Stop();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            axTimelineControl1.OutputType = 2;
            axTimelineControl1.MP4Height = 768;
            axTimelineControl1.MP4Width = 1024;
            saveFileDialog1.Filter = "MP4 File (*.mp4)|*.mp4||";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int iresult = axTimelineControl1.Save(saveFileDialog1.FileName);

            }
        }


        private void axTimelineControl1_OnConvertProgress(object sender, AxTimelineAxLib._ITimelineControlEvents_OnConvertProgressEvent e)
        {
            progressBar1.Value = e.progress;

        }

        private void axTimelineControl1_OnConvertCompleted(object sender, EventArgs e)
        {
            MessageBox.Show("Convert complete");
        }

        private void cboScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            axTimelineControl1.SetScale(float.Parse(cboScale.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axTimelineControl1.Clear();
        }

        private void axTimelineControl1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            axTimelineControl1.AddTextClip(7, "bui huu chung", 0, 8, (int)fontDialog1.Font.ToHfont(), 0, 0, Color2Unit32(Color.BlueViolet));
        }
        public uint Color2Unit32(Color clr)
        {
            int t;
            byte[] a;
            t = ColorTranslator.ToOle(clr);
            a = BitConverter.GetBytes(t);
            return BitConverter.ToUInt32(a, 0);
        }
    }
}
