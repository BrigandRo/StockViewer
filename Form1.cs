using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace StockViewer
{
    public partial class Form1 : Form
    {
        public static string settings_path = 
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\StockViewer.json";

        TextData[] textData = new TextData[2];
        HttpClient client = new HttpClient();
        Settings settings;

        int ScreenWidth = 0;
        Point midPoint;

        DateTime time_now = DateTime.Now, last_time = DateTime.Now;
        float deltaTime, price_elapseTime = 0, mouse_elapseTime = 0;

        public Form1()
        {
            bool firstTime = false;
            settings = Settings.Load(settings_path);
            if (settings.fontSize == 0)
            {
                settings = new Settings() { fontSize = 10, opacity = 100, nrSpaces = 10, speed = 30, monitor = 0, companies = "TSLA,XMR-USD,BTC-USD" };
                settings.Save(settings_path);
                firstTime = true;
            }

            InitializeComponent();
            Init_TextData();
            Set_Form();
            Change_FormColor(Misc.GetColorAt(midPoint));

            StartPosition = FormStartPosition.Manual;
            ShowInTaskbar = false;
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;

            Thread t = new Thread(Update_Loop);
            t.IsBackground = true;
            t.Start();

            textData[0].Set_Text("Connecting...");

            if (firstTime)
                notifyIcon1.ShowBalloonTip(1000, "Info", "↓↓↓↓↓  I am Here!", ToolTipIcon.None);

            string startup_path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + 
                @"\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup";

            if (Directory.GetCurrentDirectory() == startup_path || !Directory.Exists(startup_path))
                contextMenuStrip1.Items.RemoveAt(0);
        }

        void Update_Loop()
        {
            Thread.Sleep(1000);
            while (true)
            {
                time_now = DateTime.Now;
                deltaTime = (time_now.Ticks - last_time.Ticks) / 10000000f;
                last_time = time_now;
                price_elapseTime += deltaTime;
                mouse_elapseTime += deltaTime;

                if (price_elapseTime > 2f)
                {
                    Refresh_Text();
                    price_elapseTime = 0;
                }

                if (mouse_elapseTime > 0.2f)
                {
                    Color backColor = Misc.GetColorAt(midPoint);
                    if (Misc.ContrastColor(backColor) != textData[0].white)
                        this.Invoke((MethodInvoker)delegate { Change_FormColor(backColor); });

                    this.Invoke((MethodInvoker)delegate {
                        Check_Mouse();
                        Misc.Unclikcable(this.Handle);
                    });

                    mouse_elapseTime = 0;
                }

                this.Invoke((MethodInvoker)delegate { Update_Poz(); });
                Thread.Sleep(10);
            }
        }

        void Update_Poz()
        {
            if (settings.speed == 0)
                return;

            foreach (var t in textData)
                t.Update_Poz(settings.speed * deltaTime);

            if (textData[0].CordX > ScreenWidth - textData[0].TextBox.Size.Width)
            {
                textData[1].CordX = textData[0].CordX;
                textData[0].CordX = -textData[0].TextBox.Size.Width;
            }
        }

        async void Refresh_Text()
        {
            string html;
            try { html = await client.GetStringAsync("https://query1.finance.yahoo.com/v7/finance/quote?fields=regularMarketPrice,postMarketPrice,preMarketPrice,regularMarketPreviousClose&symbols=" + settings.companies); }
            catch { client = new HttpClient(); return; }

            YahooData jsonData = JsonConvert.DeserializeObject<YahooData>(html);
            var result = jsonData.quoteResponse.result;

            string text = result[0].MarketState + ":" + new String(' ', settings.nrSpaces / 2);
            for (int i = 0; i < result.Count; i++)
            {
                float price = result[i].RegularMarketPrice;

                float procent = 0;
                if (result[i].RegularMarketPreviousClose > price)
                    procent = ((result[i].RegularMarketPreviousClose - price) / result[i].RegularMarketPreviousClose) * -100;
                else
                    procent = ((price - result[i].RegularMarketPreviousClose) / result[i].RegularMarketPreviousClose) * 100;

                text += $"{result[i].Symbol}  {price.ToString("0.00")}  ({procent.ToString("+0.00;-0.00;0")}%)";

                if (i < result.Count - 1)
                    text += new String(' ', settings.nrSpaces);
            }

            this.Invoke((MethodInvoker)delegate {
                foreach (var t in textData)
                    t.Set_Text(text);
            });
        }

        void Init_TextData()
        {
            for (int i = 0; i < 2; i++)
            {
                var textBox = new RichTextBox();
                textBox.Font = new Font("Serif", 8, FontStyle.Regular);
                textBox.BorderStyle = BorderStyle.None;
                textBox.WordWrap = false;
                textBox.ContentsResized += (object sender, ContentsResizedEventArgs e) =>
                {
                    var richTextBox = (RichTextBox)sender;
                    richTextBox.Width = e.NewRectangle.Width;
                    richTextBox.Height = e.NewRectangle.Height;
                    textBox.Width += textBox.Margin.Horizontal + SystemInformation.HorizontalResizeBorderThickness;
                };

                this.Controls.Add(textBox);

                textData[i] = new TextData(textBox);
            }
        }

        void Set_Form()
        {
            var area = Screen.AllScreens[settings.monitor].WorkingArea;
            var location = area.Location;
            location.Offset(area.Width / 2, 0);
            midPoint = location;

            Rectangle bounds = Screen.AllScreens[settings.monitor].Bounds;
            ScreenWidth = bounds.Width;
            this.SetBounds(bounds.X, bounds.Y, ScreenWidth, 100);


            foreach (var t in textData)
                t.Set_FontSize(settings.fontSize);

            this.Opacity = settings.opacity / 100.0f;
        }

        void Change_FormColor(Color backColor)
        {
            BackColor = backColor;
            TransparencyKey = backColor;

            foreach (var t in textData)
                t.Update_Color(backColor);
        }

        void Check_Mouse()
        {
            int startX = Screen.AllScreens[settings.monitor].WorkingArea.X;
            int width = Screen.AllScreens[settings.monitor].WorkingArea.Width;
            bool x = Cursor.Position.X > startX && Cursor.Position.X < startX + width;

            Opacity = 0;
            if (!x || Cursor.Position.Y > Screen.AllScreens[settings.monitor].WorkingArea.Y + 32)
                Opacity = settings.opacity / 100.0f;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void runWithWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Put the (.exe) in the Startup (Run: shell:startup) for it to open with windows");
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SettingsForm form = new SettingsForm())
            {
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    settings = Settings.Load(settings_path);
                    Set_Form();

                    if (settings.speed == 0)
                    {
                        textData[0].CordX = 0;
                        textData[1].CordX = ScreenWidth;
                    }
                }
            }
        }
    }
}
