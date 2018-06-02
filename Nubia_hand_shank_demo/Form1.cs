using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using CCWin;
using Nubia_hand_shank_demo.Properties;

namespace Nubia_hand_shank_demo
{
    public partial class Form1 : CCSkinMain
    {
        private Thread _thrdReadFWSignal;
        private bool _stop_read;
        private int[] rawdata_cur = new int[4];
        private int[] rawdata_last = new int[4];
        private int[] baseline_cur = new int[4];
        private int[] baseline_last = new int[4];
        private int _channel_num = 4;
        private int sigma_wave = 100;
        private int sigma_tsunami = 200;
        private StringBuilder _sb;
        private bool _isFirstFrame;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void skbtnStart_Click(object sender, EventArgs e)
        {
            if (_thrdReadFWSignal == null)
            {
                skbtnStart.Text = "Disable";
                skrtbLog.Enabled = false;
                _stop_read = false;
                _isFirstFrame = true;
                IICoperation.IICOpen(false);
                IICoperation.SetIICSpeed(false);
                _sb = new StringBuilder();
                _thrdReadFWSignal = new Thread(read_data) { IsBackground = true };
                _thrdReadFWSignal.Start();
            }
            else
            {
                if (_thrdReadFWSignal.IsAlive)
                {
                    _stop_read = true;
                    _thrdReadFWSignal.Abort();
                    _thrdReadFWSignal = null;
                    IICoperation.IICClose(true);
                    skbtnStart.Text = "Activate";
                    skrtbLog.Enabled = true;
                }
                save_sb_to_file();
                call_python_draw_figure();
            }
        }

        private void read_data()
        {
            while (!_stop_read)
            {
                Thread.Sleep(1);
                object[] data = IICoperation.IICReadData(_channel_num);
                int[] threshold = data[0] as int[];
                int[] rawdata = data[1] as int[];
                int[] forcesig = data[2] as int[];
                int[] touch_event = data[3] as int[];
                ShowLogUtils.ShowLog(skrtbLog,
                    rawdata[0] + ", " +
                    rawdata[1] + ", " +
                    rawdata[2] + ", " +
                    rawdata[3] + ", " +
                    forcesig[0] + ", " +
                    forcesig[1] + ", " +
                    forcesig[2] + ", " +
                    forcesig[3] + ", "
                    );
                Array.Copy(rawdata, rawdata_cur, rawdata.Length);
                calc_baseline();
                save_rawdata_and_baseline();
                Array.Copy(baseline_cur, baseline_last, baseline_cur.Length);
                Array.Copy(rawdata_cur, rawdata_last, rawdata_cur.Length);
                if (touch_event[0] == 1)
                {
                    Invoke(new EventHandler(delegate
                    {
                        skpbHandShank.BackgroundImage = Resources.HandShank2;
                        System.Media.SystemSounds.Hand.Play();
                    }));
                }
                else
                {
                    Invoke(new EventHandler(delegate
                    {
                        skpbHandShank.BackgroundImage = Resources.HandShank;
                    }));
                }
            }
        }

        private void calc_baseline()
        {
            for (int i = 0; i < _channel_num; i++)
            {
                if (_isFirstFrame)
                {
                    baseline_cur[i] = rawdata_cur[i];
                }
                else
                {
                    baseline_cur[i] = (int) (baseline_last[i] +
                                             (rawdata_cur[i] - rawdata_last[i]) *
                                             Math.Exp(-Math.Pow(rawdata_cur[i] - rawdata_last[i], 2) / sigma_wave) +
                                             (rawdata_last[i] - baseline_last[i]) *
                                             Math.Exp(-Math.Pow(rawdata_last[i] - baseline_last[i], 2) /sigma_tsunami));
                }
            }
            _isFirstFrame = false;
        }

        private void save_rawdata_and_baseline()
        {
            rawdata_cur.ToList().ForEach(x => _sb.Append(x + "\t"));
            baseline_cur.ToList().ForEach(x => _sb.Append(x + "\t"));
            _sb.Append("\r\n");
        }

        private void save_sb_to_file()
        {
            byte[] buffer = Encoding.UTF8.GetBytes(_sb.ToString());
            _sb = null;
            using (FileStream fs = new FileStream("data\\" + DateTime.Now.ToString("yyyy-M-d-HH-mm-ss") + ".txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                fs.Write(buffer, 0, buffer.Length);
                fs.Close();
                fs.Dispose();
            }
        }

        private void call_python_draw_figure()
        {
            try
            {
                CallPython.RunPythonScript("draw.py");
            }
            catch
            {

            }
        }

        private void Form1_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            _stop_read = true;
            if (_thrdReadFWSignal != null)
            {
                if (_thrdReadFWSignal.IsAlive)
                {
                    _thrdReadFWSignal.Abort();
                    _thrdReadFWSignal = null;
                    IICoperation.IICClose(true);
                }
            }
        }
    }
}