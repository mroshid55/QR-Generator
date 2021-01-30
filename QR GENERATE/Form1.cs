using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using ZXing.Common;
using ZXing;
using ZXing.QrCode;


namespace QR_GENERATE
{
    public partial class Form1 : Form
    {

        private QrCodeEncodingOptions options;
        public Form1()
        {
            InitializeComponent();

            options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 250,
                Height = 250,
            };
            var writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;

        }

        private void btn_g_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrEmpty(textBox1.Text))
            {
                pictureBox1.Image = null;
                MessageBox.Show("Text not found", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var qr = new ZXing.BarcodeWriter();
                qr.Options = options;
                qr.Format = ZXing.BarcodeFormat.QR_CODE;
                var result = new Bitmap(qr.Write(textBox1.Text.Trim()));
                pictureBox1.Image = result;
                textBox1.Clear();
            }
        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            // Step 6: Create Download Button
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Image not found", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.CreatePrompt = true;
                save.OverwritePrompt = true;
                save.FileName = "GHL_QR";
                save.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBox1.Image.Save(save.FileName);
                    save.InitialDirectory = Environment.GetFolderPath
                                (Environment.SpecialFolder.Desktop);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Font fnt = new Font(textBox1.Font.FontFamily, 8.0F);
            textBox1.Font = fnt;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Font fnt = new Font(textBox1.Font.FontFamily, 9.0F);
            textBox1.Font = fnt;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Font fnt = new Font(textBox1.Font.FontFamily, 10.0F);
            textBox1.Font = fnt;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Font fnt = new Font(textBox1.Font.FontFamily, 11.0F);
            textBox1.Font = fnt;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Font fnt = new Font(textBox1.Font.FontFamily, 12.0F);
            textBox1.Font = fnt;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Font fnt = new Font(textBox1.Font.FontFamily, 13.0F);
            textBox1.Font = fnt;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Font fnt = new Font(textBox1.Font.FontFamily, 14.0F);
            textBox1.Font = fnt;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Font fnt = new Font(textBox1.Font.FontFamily, 15.0F);
            textBox1.Font = fnt;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Font fnt = new Font(textBox1.Font.FontFamily, 16.0F);
            textBox1.Font = fnt;
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Font fnt = new Font(textBox1.Font.FontFamily, 17.0F);
            textBox1.Font = fnt;
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Font fnt = new Font(textBox1.Font.FontFamily, 18.0F);
            textBox1.Font = fnt;
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font font = new Font("Times New Roman",11.0F);
            textBox1.Font = font;
        }

        private void microsoftSansSerifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 11.0F);
            textBox1.Font = font;
        }

        private void modernNo20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font font = new Font("Modern No. 20", 11.0F);
            textBox1.Font = font;
        }

        private void palatinoLinotypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font font = new Font("Palatino Linotype", 11.0F);
            textBox1.Font = font;
        }

        private void niagaraSolidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font font = new Font("Niagara Solid", 11.0F);
            textBox1.Font = font;
        }

        private void kristenITCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font font = new Font("Kristen ITC", 11.0F);
            textBox1.Font = font;
        }

        private void segoePrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font font = new Font("Segoe Print", 11.0F);
            textBox1.Font = font;
        }

        private void lucidaCalligraphyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font font = new Font("Lucida Calligraphy", 11.0F);
            textBox1.Font = font;
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
        }

        private void underlineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
        }

        private void strikeoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Strikeout);
        }
    }
}
