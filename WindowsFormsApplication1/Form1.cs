using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Photoshop;
using System.IO;
//using Photoshop.PsdFile;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        PsdFile m_File;

        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg= new OpenFileDialog();
            dlg.Filter="Photoshop Files(*.psd)|*.psd";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                m_File = new PsdFile();
                m_File.Load(dlg.FileName);

                txtLoadPath.Text = dlg.FileName;

                foreach (Layer L in m_File.Layers)
                {
                    lstLayers.Items.Add(L.Name);
                }

                Image img = m_File.CompositImage;
                picLayerImage.Image = img;
                picLayerImage.Refresh();

                MessageBox.Show("Layer count : "+m_File.Layers.Count);
                MessageBox.Show("ImageResource count : " + m_File.ImageResources.Count);
                MessageBox.Show("ImageData count : " + m_File.ImageData.Length);
                MessageBox.Show("Rows : " + m_File.Rows);
                MessageBox.Show("WidthUnit : " + m_File.Resolution.WidthUnit + "\n" + "HeightUnit : " + m_File.Resolution.HeightUnit);
                MessageBox.Show("Depth : "+m_File.Depth);

                //m_File.Load("")
                
            }

            
        }

        private void lstLayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Layer L= m_File.Layers[ lstLayers.SelectedIndex ];
            txtInfo.Text = "X : " + L.Rect.Left + ", Y : " + L.Rect.Top + ", W : " + L.Rect.Right + ", H : " + L.Rect.Bottom;

            m_File.ImageCompression.ToString();
            

            ImageResource IR = m_File.ImageResources[lstLayers.SelectedIndex];
            byte[] bPic= IR.Data.ToArray();
            //m_File.
            //byte[] picture = m_File.[lstLayers.SelectedIndex];
            picLayerImage.Image = Image.FromStream(new MemoryStream(bPic));
            picLayerImage.Refresh();
        }
    }
}
