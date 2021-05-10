/* Undergraduate Final Project
 * Electrical Engineering Diponegoro University
 * By : Ibrahim (21060116130099)
 * My repo: github.com/ibmgrx
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.IO;

namespace GCS
{
    public partial class Form1 : Form
    {
        static SerialPort port;
        string dataIn, start="0";
        double lon_gps;
        decimal s, vKp, vKi, vKd, vSp;
        int i,j,k;
        double lat_gps;
        List<PointLatLng> points;
        double latN, lonN, latB, lonB, head, spK, error, 
               lim, jarak, pwm, rSt, rKp, rKi, rKd, rSp, rEm;
        String WP1Lat, WP1Lon, WP2Lat, WP2Lon,
               WP3Lat, WP3Lon, WP4Lat, WP4Lon,
               WP5Lat, WP5Lon, WP6Lat, WP6Lon,
               WP7Lat, WP7Lon;

        public Form1()
        {
            InitializeComponent();
            port = new SerialPort();
            gmap.MapProvider = GoogleHybridMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            points = new List<PointLatLng>();
            timer1.Start();
            Tanggal.Text = DateTime.Now.ToLongDateString();
            Waktu.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            Tanggal.Text = DateTime.Now.ToLongDateString();
            Waktu.Text = DateTime.Now.ToLongTimeString();
        }

        private void ComboBox1_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            PortNumber.Items.Clear();
            PortNumber.Items.AddRange(ports);
        }

        private void OpenClose_Click(object sender, EventArgs e)
        {
            if (OpenClose.Text == "CONNECT HERE")
            {
                if (PortNumber.Text.Length > 1)
                {
                    port = new SerialPort(PortNumber.Text, 57600, Parity.None, 8, StopBits.One);

                    port.Open();
                    port.DataReceived += DataReceived;

                    progressBar1.Value = 100;
                    OpenClose.Text = "Close";
                }
            }
            else
            {
                port.Close();
                progressBar1.Value = 0;
                timer1.Stop();
                OpenClose.Text = "CONNECT HERE";
            }
        }

        void DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            dataIn = port.ReadLine();
            this.Invoke(new EventHandler(get_data));
            k = k + 100;
        }

        private void get_data(object sender, EventArgs e)
        {
            try
            {
                System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
                customCulture.NumberFormat.NumberDecimalSeparator = ".";
                System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;//format penulisan desimal

                if (dataIn.StartsWith("#"))
                {
                    string[] dataArray = dataIn.Split(',');
                    latN = double.Parse(dataArray[1], customCulture);
                    lonN = double.Parse(dataArray[2], customCulture);
                    latB = double.Parse(dataArray[3], customCulture);
                    lonB = double.Parse(dataArray[4], customCulture);
                    head = double.Parse(dataArray[5], customCulture);
                    spK = double.Parse(dataArray[6], customCulture);
                    error = double.Parse(dataArray[7], customCulture);
                    jarak = double.Parse(dataArray[8], customCulture);
                    pwm = double.Parse(dataArray[9], customCulture);
                    rSt = double.Parse(dataArray[10], customCulture);
                    rKp = double.Parse(dataArray[11], customCulture);
                    rKi = double.Parse(dataArray[12], customCulture);
                    rKd = double.Parse(dataArray[13], customCulture);
                    rSp = double.Parse(dataArray[14], customCulture);
                    rEm = double.Parse(dataArray[15], customCulture);
                }

                dataGridView2.Rows.Add();
                dataGridView2.Rows[j].Cells[0].Value = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
                dataGridView2.Rows[j].Cells[1].Value = Waktu.Text;
                dataGridView2.Rows[j].Cells[2].Value = head;
                dataGridView2.Rows[j].Cells[3].Value = latN;
                dataGridView2.Rows[j].Cells[4].Value = lonN;
                dataGridView2.Rows[j].Cells[5].Value = spK;
                dataGridView2.Rows[j].Cells[6].Value = error;
                dataGridView2.Rows[j].Cells[7].Value = jarak;
                dataGridView2.Rows[j].Cells[8].Value = pwm;
                dataGridView2.Rows[j].Cells[9].Value = start;
                j++;

                label4.Text = Convert.ToString(latN);
                label5.Text = Convert.ToString(lonN);
                label7.Text = Convert.ToString(head);
                label17.Text = Convert.ToString(spK);
                label12.Text = Convert.ToString(error);
                label13.Text = Convert.ToString(jarak);
                label19.Text = Convert.ToString(pwm);
                label31.Text = Convert.ToString(rSt);
                label27.Text = Convert.ToString(rKp);
                label28.Text = Convert.ToString(rKi);
                label29.Text = Convert.ToString(rKd);
                label30.Text = Convert.ToString(rSp);
                label22.Text = Convert.ToString(rEm);

                lim = latN - lonB;
                if (latN != 0 && lonN != 0 && latB != 0 && lonB != 0)
                {
                    GMapOverlay jejak = new GMapOverlay("jejak");
                    List<PointLatLng> jalur = new List<PointLatLng>();
                    jalur.Add(new PointLatLng(latN, lonN));
                    jalur.Add(new PointLatLng(latB, lonB));
                    GMapRoute rute = new GMapRoute(jalur, "rute");
                    rute.Stroke = new Pen(Color.Yellow, 5);
                    rute.Stroke.StartCap = LineCap.Round;
                    rute.Stroke.LineJoin = LineJoin.Round;
                    rute.Stroke.EndCap = LineCap.Round;
                    jejak.Routes.Add(rute);
                    gmap.Overlays.Add(jejak);
                }
            }
            catch { }

        }

//================================== M A P =======================================//
        private void gmap_Load(object sender, EventArgs e)
        {
            gmap.Position = new PointLatLng(-7.05250157725237, 110.445610284805);
            gmap.ShowCenter = false;
            gmap.Zoom = 17;
        }

        private void gmap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var points = gmap.FromLocalToLatLng(e.X, e.Y);
                lat_gps = points.Lat;
                lon_gps = points.Lng;

                txtLat.Text = lat_gps + "";
                txtLon.Text = lon_gps + "";
            }
        }

        private void loadGPS_Click(object sender, EventArgs e)
        {
            try
            {
                GMapOverlay markers = new GMapOverlay("markers");
                lat_gps = Convert.ToDouble(txtLat.Text);
                lon_gps = Convert.ToDouble(txtLon.Text);
                gmap.Position = new PointLatLng(lat_gps, lon_gps);
                gmap.Zoom = 20;

                
                GMapMarker marker = new GMarkerGoogle(
                    new PointLatLng(lat_gps, lon_gps),
                    GMarkerGoogleType.red);
                markers.Markers.Add(marker);
                gmap.Overlays.Add(markers);
            }

            catch
            {
                MessageBox.Show("Please Input Number", "Try Again");
            }
        }

        public void addPos_Click(object sender, EventArgs e)
        {
            try
            {
                points.Add(new PointLatLng(Convert.ToDouble(txtLat.Text),
                    Convert.ToDouble(txtLon.Text)));
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = Convert.ToDouble(txtLat.Text);
                dataGridView1.Rows[i].Cells[1].Value = Convert.ToDouble(txtLon.Text);
                i++;
            }

            catch
            {
                MessageBox.Show("Load First");
            }
        }

        public void routBtn_Click(object sender, EventArgs e)
        {
            GMapOverlay routes = new GMapOverlay("routes");
            GMapRoute route = new GMapRoute(points, "rute");
            route.Stroke = new Pen(Color.Red, 3);
            routes.Routes.Add(route);
            gmap.Overlays.Add(routes);
            gmap.Refresh();
        }

        public void clrBtn_Click(object sender, EventArgs e)
        {
            for (int m = 0; m < gmap.Overlays.Count; m = 0)
            {
                gmap.Overlays.RemoveAt(m);
                gmap.Refresh();
            }
        }

        private void sendWP_Click(object sender, EventArgs e)
        {
            
            if (port.IsOpen)
            {
                if (dataGridView1.Rows[0].Cells[0].Value != null)
                {
                    WP1Lat = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    WP1Lon = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    if (dataGridView1.Rows[1].Cells[0].Value != null)
                    {
                        WP2Lat = dataGridView1.Rows[1].Cells[0].Value.ToString();
                        WP2Lon = dataGridView1.Rows[1].Cells[1].Value.ToString();
                        if (dataGridView1.Rows[2].Cells[0].Value != null)
                        {
                            WP3Lat = dataGridView1.Rows[2].Cells[0].Value.ToString();
                            WP3Lon = dataGridView1.Rows[2].Cells[1].Value.ToString();
                            if (dataGridView1.Rows[3].Cells[0].Value != null)
                            {
                                WP4Lat = dataGridView1.Rows[3].Cells[0].Value.ToString();
                                WP4Lon = dataGridView1.Rows[3].Cells[1].Value.ToString();
                                if (dataGridView1.Rows[4].Cells[0].Value != null)
                                {
                                    WP5Lat = dataGridView1.Rows[4].Cells[0].Value.ToString();
                                    WP5Lon = dataGridView1.Rows[4].Cells[1].Value.ToString();
                                    if (dataGridView1.Rows[5].Cells[0].Value != null)
                                    {
                                        WP6Lat = dataGridView1.Rows[5].Cells[0].Value.ToString();
                                        WP6Lon = dataGridView1.Rows[5].Cells[1].Value.ToString();
                                        if (dataGridView1.Rows[6].Cells[0].Value != null)
                                        {
                                            WP7Lat = dataGridView1.Rows[6].Cells[0].Value.ToString();
                                            WP7Lon = dataGridView1.Rows[6].Cells[1].Value.ToString();
                                        }
                                        else { WP7Lat = "0"; WP7Lon = "0"; }
                                    }
                                    else { WP6Lat = "0"; WP6Lon = "0";
                                           WP7Lat = "0"; WP7Lon = "0"; }
                                }
                                else { WP5Lat = "0"; WP5Lon = "0";
                                       WP6Lat = "0"; WP6Lon = "0";
                                       WP7Lat = "0"; WP7Lon = "0"; }
                            }
                            else { WP4Lat = "0"; WP4Lon = "0";
                                   WP5Lat = "0"; WP5Lon = "0";
                                   WP6Lat = "0"; WP6Lon = "0";
                                   WP7Lat = "0"; WP7Lon = "0"; }
                        }
                        else { WP3Lat = "0"; WP3Lon = "0";
                               WP4Lat = "0"; WP4Lon = "0";
                               WP5Lat = "0"; WP5Lon = "0";
                               WP6Lat = "0"; WP6Lon = "0";
                               WP7Lat = "0"; WP7Lon = "0"; }
                        }
                    
                    else { WP2Lat = "0"; WP2Lon = "0";
                           WP3Lat = "0"; WP3Lon = "0";
                           WP4Lat = "0"; WP4Lon = "0";
                           WP5Lat = "0"; WP5Lon = "0";
                           WP6Lat = "0"; WP6Lon = "0";
                           WP7Lat = "0"; WP7Lon = "0"; }
                }
                else
                {
                    WP1Lat = "0"; WP1Lon = "0";
                    WP2Lat = "0"; WP2Lon = "0";
                    WP3Lat = "0"; WP3Lon = "0";
                    WP4Lat = "0"; WP4Lon = "0";
                    WP5Lat = "0"; WP5Lon = "0";
                    WP6Lat = "0"; WP6Lon = "0";
                    WP7Lat = "0"; WP7Lon = "0";
                }
                port.Write("!" + "wp" + "|"
                            + WP1Lat + "|" + WP1Lon + "|"
                            + WP2Lat + "|" + WP2Lon + "|"
                            + WP3Lat + "|" + WP3Lon + "|"
                            + WP4Lat + "|" + WP4Lon + "|"
                            + WP5Lat + "|" + WP5Lon + "|"
                            + WP6Lat + "|" + WP6Lon + "|"
                            + WP7Lat + "|" + WP7Lon +  ">");
                MessageBox.Show("!" + "wp" + "|"
                            + WP1Lat + "|" + WP1Lon + "|"
                            + WP2Lat + "|" + WP2Lon + "|"
                            + WP3Lat + "|" + WP3Lon + "|"
                            + WP4Lat + "|" + WP4Lon + "|"
                            + WP5Lat + "|" + WP5Lon + "|"
                            + WP6Lat + "|" + WP6Lon + "|"
                            + WP7Lat + "|" + WP7Lon +  ">");
            }
        }

        private void saveWP_Click(object sender, EventArgs e)
        {
            SaveWPtoCSV();
        }

        private void SaveWPtoCSV()
        {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "Data_WP.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Data akan disimpan.");
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error" + ex.Message);
                    }
                }
                int columnCount = dataGridView1.ColumnCount;
                string columnNames = "";
                string[] output = new string[dataGridView1.RowCount + 1];
                for (int i = 0; i < columnCount; i++)
                {
                    columnNames += dataGridView1.Columns[i].Name.ToString() + ",";
                }
                output[0] += columnNames;
                for (int i = 1; (i - 1) < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        if (dataGridView1.Rows[i - 1].Cells[j].Value != null) output[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                    }
                }
                System.IO.File.WriteAllLines(sfd.FileName, output, System.Text.Encoding.UTF8);
                MessageBox.Show("Data berhasil disimpan.");
            }
        }


//=================================== S P E E D ==================================//
        private void speed_ValueChanged(object sender, EventArgs e)
        {
            s = ((speed.Value)*5) + 1000;
        }

        private void btnSend(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                String ok = s.ToString();
                port.Write("@" + "speed" + "|" + ok + ">");
            }
        }

//================================= T U N I N G =================================//
        private void Kp_ValueChanged(object sender, EventArgs e)
        {
            vKp = Kp.Value;
        }

        private void Ki_ValueChanged(object sender, EventArgs e)
        {
            vKi = Ki.Value;
        }

        private void Kd_ValueChanged(object sender, EventArgs e)
        {
            vKd = Kd.Value;
        }

        private void Sp_ValueChanged(object sender, EventArgs e)
        {
            vSp = Sp.Value;
        }

        private void btnTuning_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                String kpValue = vKp.ToString();
                String kiValue = vKi.ToString();
                String kdValue = vKd.ToString();
                String spValue = vSp.ToString();
                port.Write("^" + "tuning" + "|" + kpValue + "|" + kiValue + "|" + kdValue + "|" + spValue + ">");
            }
        }

//============================= S T A R T / S T O P ==============================//
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                start = "1";
                port.Write("#" + "start" + "|" + start + ">");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                start = "0";
                port.Write("#" + "start" + "|" + start + ">");
            }
        }

//============================= F A I L S A F E ================================//
        private void btnEmg_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                String danger = "1";
                port.Write("$" + "emergency" + "|" + danger + ">");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveToCSV();
        }

//============================= S A V E  F I L E =================================//
        private void SaveToCSV()
        {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "Data_ASV.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Data akan disimpan.");
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error" + ex.Message);
                    }
                }
                int columnCount = dataGridView2.ColumnCount;
                string columnNames = "";
                string[] output = new string[dataGridView2.RowCount + 1];
                for (int i = 0; i < columnCount; i++)
                {
                    columnNames += dataGridView2.Columns[i].Name.ToString() + ",";
                }
                output[0] += columnNames;
                for (int i = 1; (i - 1) < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        if (dataGridView2.Rows[i - 1].Cells[j].Value != null) output[i] += dataGridView2.Rows[i - 1].Cells[j].Value.ToString() + ",";
                    }
                }
                System.IO.File.WriteAllLines(sfd.FileName, output, System.Text.Encoding.UTF8);
                MessageBox.Show("Data berhasil disimpan.");
            }
        }

        private void clrData_Click(object sender, EventArgs e)
        {
            reset();
            j = 0;
        }

        private void reset()
        {
            int numRows = dataGridView2.Rows.Count;
            for (int l = 0; l < numRows; l++)
            {
                try
                {
                    int max = dataGridView2.Rows.Count - 1;
                    dataGridView2.Rows.Remove(dataGridView2.Rows[max]);
                }
                catch (Exception exe)
                {
                    MessageBox.Show("try again" + exe, "deleted",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}