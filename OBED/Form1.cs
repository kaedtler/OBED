using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace OBED
{
    public partial class Form1 : Form
    {
        const string key = "AvC7RStdqwmiVpozhXflF_cg9ScmQ4zLp1UhQg2tNTAJBPRsSYTXmu6C87Ae_QnP";
        const string reqUrl = @"http://dev.virtualearth.net/REST/V1/Imagery/Metadata/Birdseye/{0},{1}?o=xml&dir={2}&key={3}";
        const string prevUrl = @"http://www.bing.com/maps/default.aspx?cp={0}~{1}&dir={2}&sty=o&lvl=18";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullUrl = string.Format(reqUrl, new string[] { latitudeNumericUpDown.Value.ToString(CultureInfo.CreateSpecificCulture("en-US")), longitudeNumericUpDown.Value.ToString(CultureInfo.CreateSpecificCulture("en-US")), northRadioButton.Checked ? "0" : eastRadioButton.Checked ? "90" : southRadioButton.Checked ? "180" : "270", key });
            Enabled = false;
            backgroundWorker1.RunWorkerAsync(fullUrl);
        }

        private static Image GetImageFromURL(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse();
            Stream stream = httpWebReponse.GetResponseStream();
            return Image.FromStream(stream);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string fullUrl = (string)e.Argument;
            XmlDocument xml = new XmlDocument();
            xml.Load(fullUrl);
            XmlNamespaceManager ns = new XmlNamespaceManager(xml.NameTable);
            ns.AddNamespace("ns", @"http://schemas.microsoft.com/search/local/ws/rest/v1");
            XmlNode statusCode = xml.SelectSingleNode("/ns:Response/ns:StatusCode", ns);
            if (statusCode != null && statusCode.InnerText == "200")
            {
                XmlNode imageNode = xml.SelectSingleNode("/ns:Response/ns:ResourceSets/ns:ResourceSet/ns:Resources/ns:BirdseyeMetadata", ns);
                if (imageNode != null)
                {
                    string url = imageNode.SelectSingleNode("ns:ImageUrl", ns).InnerText.Replace("{subdomain}", "{0}").Replace("{zoom}", "{1}").Replace("{tileId}", "{2}");
                    List<string> subdomains = new List<string>();
                    foreach (XmlNode subdomain in imageNode.SelectNodes("ns:ImageUrlSubdomains/ns:string", ns))
                        subdomains.Add(subdomain.InnerText);
                    int width = int.Parse(imageNode.SelectSingleNode("ns:ImageWidth", ns).InnerText);
                    int height = int.Parse(imageNode.SelectSingleNode("ns:ImageHeight", ns).InnerText);
                    int zoom = int.Parse(imageNode.SelectSingleNode("ns:ZoomMax", ns).InnerText);
                    int tilesX = int.Parse(imageNode.SelectSingleNode("ns:TilesX", ns).InnerText);
                    int tilesY = int.Parse(imageNode.SelectSingleNode("ns:TilesY", ns).InnerText);
                    int tilesCount = tilesX * tilesY;
                    Bitmap bmp = new Bitmap(width * tilesX, height * tilesY);
                    using (Graphics gr = Graphics.FromImage(bmp))
                        for (int i = 0; i < tilesCount; i++)
                        {
                            gr.DrawImage(GetImageFromURL(string.Format(url, subdomains[i % subdomains.Count], zoom, i)), (i % tilesX) * width, (i / tilesX) * height);
                            backgroundWorker1.ReportProgress(i * 100 / tilesCount);
                        }
                    e.Result = bmp;
                }
                else
                    MessageBox.Show("Es sind keine Bilddaten verfügbar", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (statusCode != null)
                MessageBox.Show("Fehler " + statusCode.InnerText, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Unbekannter Fehler", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Bitmap bmp = e.Result as Bitmap;
            if (bmp != null)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "JPG|*.jpg|PNG|*.png|BMP|*.bmp";
                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    switch (Path.GetExtension(save.FileName))
                    {
                        case ".jpg":
                        case ".jpeg":
                            bmp.Save(save.FileName, ImageFormat.Jpeg);
                            break;
                        case ".bmp":
                            bmp.Save(save.FileName, ImageFormat.Bmp);
                            break;
                        default:
                            bmp.Save(save.FileName);
                            break;
                    }
                }
            }
            progressBar1.Value = 0;
            Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(string.Format(prevUrl, latitudeNumericUpDown.Value.ToString(CultureInfo.CreateSpecificCulture("en-US")), longitudeNumericUpDown.Value.ToString(CultureInfo.CreateSpecificCulture("en-US")), northRadioButton.Checked ? "0" : eastRadioButton.Checked ? "90" : southRadioButton.Checked ? "180" : "270"));
        }
    }
}
