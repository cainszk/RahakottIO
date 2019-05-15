using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using System.Web;
using System.Text;
using System.Drawing;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Runtime.InteropServices;
using QRCoder;
using System.Drawing.Imaging;

namespace RahakottIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Url= "https://rahakott.io/api/v1.1";

        string strValue;
        string apikey;
        string btc0oid;
        string bch0oid;
        string dash0oid;
        string ltc0oid;
        string zec0oid;
        string usdtprice="6.7";
        string zec0confirmed;
        void getBTCprice()
        {
            getwebstr("btc");
            lb4btc0price.Text = strValue+" 元";
        }
        void getBCHprice()
        {
            getwebstr("bch");
            lb4bch0price.Text = strValue + " 元";
        }
        void getDASHprice()
        {
            getwebstr("dash");
            lb4dash0price.Text = strValue + " 元";
        }
        void getLTCprice()
        {
            getwebstr("ltc");
            lb4ltc0price.Text = strValue + " 元";
        }
        void getZECprice()
        {
            getwebstr("zec");
            lb4zec0price.Text = strValue + " 元";
        }
        string getwebstr(string coin)
        {
            try
            {
                string strURL = "https://data.gateio.co/api2/1/ticker/" + coin + "_usdt";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Accept = "application/json";
                string paraUrlCoded = "";
                byte[] payload;
                payload = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
                request.ContentLength = payload.Length;
                Stream writer;
                try
                {
                    writer = request.GetRequestStream();
                }
                catch (Exception)
                {
                    writer = null;
                    Console.Write("连接服务器失败!");
                }
                writer.Write(payload, 0, payload.Length);
                writer.Close();
                strValue = "";
                HttpWebResponse response;
                try
                {
                    response = (HttpWebResponse)request.GetResponse();
                }
                catch (WebException ex)
                {
                    response = ex.Response as HttpWebResponse;
                }
                Stream s = response.GetResponseStream();
                StreamReader sr = new StreamReader(s, Encoding.Default);
                strValue = sr.ReadToEnd();
                sr.Close();
                JObject jo4webstr = (JObject)JsonConvert.DeserializeObject(strValue.ToString());
                string coinprice4usdt = jo4webstr["last"].ToString();
                strValue = ((int)(double.Parse(usdtprice) * double.Parse(coinprice4usdt))).ToString();
                return strValue;
            }
            catch
            {
                MessageBox.Show("无法发送请求！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return strValue;
            }
        }
        string Post1(string methodName, string ParasKey, string ParasValue)
        {
            try
            {
                string strURL = Url + "/" + methodName;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Accept = "application/json";
                FileStream fsrd = File.OpenRead(@"config/apikey.cain");
                StreamReader sr = new StreamReader(fsrd, System.Text.Encoding.Default);
                string strrd = sr.ReadToEnd();
                sr.Close();
                fsrd.Close();
                apikey = strrd;
                string paraUrlCoded = "{\"" + HttpUtility.UrlEncode("api_key") + "\":\"" + apikey + "\",\"" + HttpUtility.UrlEncode(ParasKey) + "\":\"" + HttpUtility.UrlEncode(ParasValue) + "\"}";
                byte[] payload;
                payload = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
                request.ContentLength = payload.Length;
                Stream writer;
                try
                {
                    writer = request.GetRequestStream();
                }
                catch (Exception)
                {
                    writer = null;
                    Console.Write("连接服务器失败!");
                }
                writer.Write(payload, 0, payload.Length);
                writer.Close();
                strValue = "";
                HttpWebResponse response;
                try
                {
                    response = (HttpWebResponse)request.GetResponse();
                }
                catch (WebException ex)
                {
                    response = ex.Response as HttpWebResponse;
                }
                Stream s = response.GetResponseStream();
                sr = new StreamReader(s, Encoding.Default);
                strValue = sr.ReadToEnd();
                sr.Close();
                return strValue;
            }
            catch
            {
                MessageBox.Show("无法发送请求！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return strValue;
            }
        }
        string Post2(string methodName, string ParasKey1, string ParasValue1, string ParasKey2, string ParasValue2)
        {
            try
            {
                string strURL = Url + "/" + methodName;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Accept = "application/json";
                FileStream fsrd = File.OpenRead(@"config/apikey.cain");
                StreamReader sr = new StreamReader(fsrd, System.Text.Encoding.Default);
                string strrd = sr.ReadToEnd();
                sr.Close();
                fsrd.Close();
                apikey = strrd;
                string paraUrlCoded = "{\"" + HttpUtility.UrlEncode("api_key") + "\":\"" + apikey + "\",\"" + HttpUtility.UrlEncode(ParasKey1) + "\":\"" + HttpUtility.UrlEncode(ParasValue1) + "\",\"" + HttpUtility.UrlEncode(ParasKey2) + "\":\"" + HttpUtility.UrlEncode(ParasValue2) + "\"}";
                byte[] payload;
                payload = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
                request.ContentLength = payload.Length;
                Stream writer;
                try
                {
                    writer = request.GetRequestStream();
                }
                catch (Exception)
                {
                    writer = null;
                    Console.Write("连接服务器失败!");
                }
                writer.Write(payload, 0, payload.Length);
                writer.Close();
                strValue = "";
                HttpWebResponse response;
                try
                {
                    response = (HttpWebResponse)request.GetResponse();
                }
                catch (WebException ex)
                {
                    response = ex.Response as HttpWebResponse;
                }
                Stream s = response.GetResponseStream();
                sr = new StreamReader(s, Encoding.Default);
                strValue = sr.ReadToEnd();
                sr.Close();
                return strValue;
            }
            catch
            {
                MessageBox.Show("无法发送请求！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return strValue;
            }
        }
        string Post3(string methodName, string ParasKey1, string ParasValue1, string ParasKey2, string ParasValue2, string ParasKey3, string ParasValue3)
        {
            try
            {
                string strURL = Url + "/" + methodName;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Accept = "application/json";
                FileStream fsrd = File.OpenRead(@"config/apikey.cain");
                StreamReader sr = new StreamReader(fsrd, System.Text.Encoding.Default);
                string strrd = sr.ReadToEnd();
                sr.Close();
                fsrd.Close();
                apikey = strrd;
                string paraUrlCoded = "{\"" + HttpUtility.UrlEncode("api_key") + "\":\"" + apikey + "\",\"" + HttpUtility.UrlEncode(ParasKey1) + "\":\"" + HttpUtility.UrlEncode(ParasValue1) + "\",\"" + HttpUtility.UrlEncode(ParasKey2) + "\":\"" + HttpUtility.UrlEncode(ParasValue2) + "\",\"" + HttpUtility.UrlEncode(ParasKey2) + "\":\"" + HttpUtility.UrlEncode(ParasValue2) + "\"}";
                byte[] payload;
                payload = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
                request.ContentLength = payload.Length;
                Stream writer;
                try
                {
                    writer = request.GetRequestStream();
                }
                catch (Exception)
                {
                    writer = null;
                    Console.Write("连接服务器失败!");
                }
                writer.Write(payload, 0, payload.Length);
                writer.Close();
                strValue = "";
                HttpWebResponse response;
                try
                {
                    response = (HttpWebResponse)request.GetResponse();
                }
                catch (WebException ex)
                {
                    response = ex.Response as HttpWebResponse;
                }
                Stream s = response.GetResponseStream();
                sr = new StreamReader(s, Encoding.Default);
                strValue = sr.ReadToEnd();
                sr.Close();
                return strValue;
            }
            catch
            {
                MessageBox.Show("无法发送请求！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return strValue;
            }
        }
        void getBTC()
        {
            //=======获取BTC信息=======//
            Post1("wallets", "currency", "BTC");
            JArray ja4get0btc0addr = (JArray)JsonConvert.DeserializeObject(strValue);
            string btc0oid = ja4get0btc0addr[0]["oid"].ToString();
            string btc0current_address = ja4get0btc0addr[0]["current_address"].ToString();
            Post1("wallets/balance", "oid", btc0oid);
            JObject jo4get0btc0balance = (JObject)JsonConvert.DeserializeObject(strValue);
            string btc0unconfirmed = jo4get0btc0balance["unconfirmed"].ToString();
            string btc0confirmed = jo4get0btc0balance["confirmed"].ToString();
            lb4btc0addr.Text = btc0current_address;
            lb4btc0cf.Text = (double.Parse(btc0confirmed) / 100000000).ToString() + " BTC";
            lb4btc0ucf.Text = (double.Parse(btc0unconfirmed) / 100000000).ToString() + " BTC";
        }
        void getBCH()
        {
            //=======获取BCH信息=======//
            Post1("wallets", "currency", "BCH");
            JArray ja4get0bch0addr = (JArray)JsonConvert.DeserializeObject(strValue);
            string bch0oid = ja4get0bch0addr[0]["oid"].ToString();
            string bch0current_address = ja4get0bch0addr[0]["current_address"].ToString();
            Post1("wallets/balance", "oid", bch0oid);
            JObject jo4get0bch0balance = (JObject)JsonConvert.DeserializeObject(strValue);
            string bch0unconfirmed = jo4get0bch0balance["unconfirmed"].ToString();
            string bch0confirmed = jo4get0bch0balance["confirmed"].ToString();
            lb4bch0addr.Text = bch0current_address;
            lb4bch0cf.Text = (double.Parse(bch0confirmed) / 100000000).ToString() + " BCH";
            lb4bch0ucf.Text = (double.Parse(bch0unconfirmed) / 100000000).ToString() + " BCH";
        }
        void getDASH()
        {
            //=======获取DASH信息=======//
            Post1("wallets", "currency", "DASH");
            JArray ja4get0dash0addr = (JArray)JsonConvert.DeserializeObject(strValue);
            string dash0oid = ja4get0dash0addr[0]["oid"].ToString();
            string dash0current_address = ja4get0dash0addr[0]["current_address"].ToString();
            Post1("wallets/balance", "oid", dash0oid);
            JObject jo4get0dash0balance = (JObject)JsonConvert.DeserializeObject(strValue);
            string dash0unconfirmed = jo4get0dash0balance["unconfirmed"].ToString();
            string dash0confirmed = jo4get0dash0balance["confirmed"].ToString();
            lb4dash0addr.Text = dash0current_address;
            lb4dash0cf.Text = (double.Parse(dash0confirmed) / 100000000).ToString() + " DASH";
            lb4dash0ucf.Text = (double.Parse(dash0unconfirmed) / 100000000).ToString() + " DASH";
        }
        void getLTC()
        {
            //=======获取LTC信息=======//
            Post1("wallets", "currency", "LTC");
            JArray ja4get0ltc0addr = (JArray)JsonConvert.DeserializeObject(strValue);
            string ltc0oid = ja4get0ltc0addr[0]["oid"].ToString();
            string ltc0current_address = ja4get0ltc0addr[0]["current_address"].ToString();
            Post1("wallets/balance", "oid", ltc0oid);
            JObject jo4get0ltc0balance = (JObject)JsonConvert.DeserializeObject(strValue);
            string ltc0unconfirmed = jo4get0ltc0balance["unconfirmed"].ToString();
            string ltc0confirmed = jo4get0ltc0balance["confirmed"].ToString();
            lb4ltc0addr.Text = ltc0current_address;
            lb4ltc0cf.Text = (double.Parse(ltc0confirmed) / 100000000).ToString() + " LTC";
            lb4ltc0ucf.Text = (double.Parse(ltc0unconfirmed) / 100000000).ToString() + " LTC";
        }
        void getZEC()
        {
            //=======获取ZEC信息=======//
            Post1("wallets", "currency", "ZEC");
            JArray ja4get0zec0addr = (JArray)JsonConvert.DeserializeObject(strValue);
            string zec0oid = ja4get0zec0addr[0]["oid"].ToString();
            string zec0current_address = ja4get0zec0addr[0]["current_address"].ToString();
            Post1("wallets/balance", "oid", zec0oid);
            JObject jo4get0zec0balance = (JObject)JsonConvert.DeserializeObject(strValue);
            string zec0unconfirmed = jo4get0zec0balance["unconfirmed"].ToString();
            zec0confirmed = jo4get0zec0balance["confirmed"].ToString();
            lb4zec0addr.Text = zec0current_address;
            lb4zec0cf.Text = (double.Parse(zec0confirmed) / 100000000).ToString() + " ZEC≈"+ (double.Parse(zec0confirmed) / 100000000)* int.Parse(lb4zec0price.Text.Substring(0,lb4zec0price.Text.Length-1)) + "元";
            lb4zec0ucf.Text = (double.Parse(zec0unconfirmed) / 100000000).ToString() + " ZEC";
        }
        void readsync()
        {
            //=======读取本地BTC信息=======//
            FileStream fsrd = File.OpenRead(@"sync\BTC\addr.cain");
            StreamReader sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            string strrd = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            lb4btc0addr.Text = strrd;
            fsrd = File.OpenRead(@"sync\BTC\ucf.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            strrd = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            lb4btc0ucf.Text = strrd + " BTC";
            fsrd = File.OpenRead(@"sync\BTC\cf.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            strrd = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            lb4btc0cf.Text = strrd + " BTC ≈ " + (int)(double.Parse(strrd) * int.Parse(lb4btc0price.Text.Substring(0, lb4btc0price.Text.Length - 2))) + " 元";
            fsrd = File.OpenRead(@"sync\BTC\oid.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            btc0oid = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            //=======读取本地BCH信息=======//
            fsrd = File.OpenRead(@"sync\BCH\addr.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            strrd = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            lb4bch0addr.Text = strrd;
            fsrd = File.OpenRead(@"sync\BCH\ucf.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            strrd = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            lb4bch0ucf.Text = strrd + " BCH";
            fsrd = File.OpenRead(@"sync\BCH\cf.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            strrd = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            lb4bch0cf.Text = strrd + " BCH ≈ " + (int)(double.Parse(strrd) * int.Parse(lb4bch0price.Text.Substring(0, lb4bch0price.Text.Length - 2))) + " 元";
            fsrd = File.OpenRead(@"sync\BCH\oid.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            bch0oid = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            //=======读取本地DASH信息=======//
            fsrd = File.OpenRead(@"sync\DASH\addr.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            strrd = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            lb4dash0addr.Text = strrd;
            fsrd = File.OpenRead(@"sync\DASH\ucf.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            strrd = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            lb4dash0ucf.Text = strrd + " DASH";
            fsrd = File.OpenRead(@"sync\DASH\cf.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            strrd = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            lb4dash0cf.Text = strrd + " DASH ≈ " + (int)(double.Parse(strrd) * int.Parse(lb4dash0price.Text.Substring(0, lb4dash0price.Text.Length - 2))) + " 元";
            fsrd = File.OpenRead(@"sync\DASH\oid.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            dash0oid = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            //=======读取本地LTC信息=======//
            fsrd = File.OpenRead(@"sync\LTC\addr.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            strrd = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            lb4ltc0addr.Text = strrd;
            fsrd = File.OpenRead(@"sync\LTC\ucf.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            strrd = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            lb4ltc0ucf.Text = strrd + " LTC";
            fsrd = File.OpenRead(@"sync\LTC\cf.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            strrd = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            lb4ltc0cf.Text = strrd + " LTC ≈ " + (int)(double.Parse(strrd) * int.Parse(lb4ltc0price.Text.Substring(0, lb4ltc0price.Text.Length - 2))) + " 元";
            fsrd = File.OpenRead(@"sync\LTC\oid.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            ltc0oid = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            //=======读取本地ZEC信息=======//
            fsrd = File.OpenRead(@"sync\ZEC\addr.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            strrd = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            lb4zec0addr.Text = strrd;
            fsrd = File.OpenRead(@"sync\ZEC\ucf.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            strrd = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            lb4zec0ucf.Text = strrd + " ZEC";
            fsrd = File.OpenRead(@"sync\ZEC\cf.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            strrd = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            lb4zec0cf.Text = strrd + " ZEC ≈ "+ (int)(double.Parse(strrd) * int.Parse(lb4zec0price.Text.Substring(0,lb4zec0price.Text.Length-2))) + " 元";
            fsrd = File.OpenRead(@"sync\ZEC\oid.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            zec0oid = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
        }
        void getsync()
        {
            readsync();
            DateTime dt = DateTime.Now;
            string time4sync = dt.ToString();
            lb4sync0status.Text = "同步时间戳："+ time4sync;
        }
        void getcoinsprice()
        {
            //=======读取本地BTC价格=======//
            FileStream fsrd = File.OpenRead(@"price\BTC.cain");
            StreamReader sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            string strrd = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            lb4btc0price.Text = strrd;
            //=======读取本地BCH价格=======//
            fsrd = File.OpenRead(@"price\BCH.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            strrd = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            lb4bch0price.Text = strrd;
            //=======读取本地DASH价格=======//
            fsrd = File.OpenRead(@"price\DASH.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            strrd = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            lb4dash0price.Text = strrd;
            //=======读取本地LTC价格=======//
            fsrd = File.OpenRead(@"price\LTC.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            strrd = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            lb4ltc0price.Text = strrd;
            //=======读取本地ZEC价格=======//
            fsrd = File.OpenRead(@"price\ZEC.cain");
            sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            strrd = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            lb4zec0price.Text = strrd;
        }
        void genQrcode4btc()
        {
            //=======生成BTC钱包二维码=======//
            string strCode = lb4btc0addr.Text;
            QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(strCode, QRCodeGenerator.ECCLevel.Q);
            QRCode qrcode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrcode.GetGraphic(5, Color.Teal, Color.White, null, 15, 6, false);
            MemoryStream ms = new MemoryStream();
            qrCodeImage.Save(ms, ImageFormat.Jpeg);
            qr4btc.Image = qrCodeImage;
        }
        void genQrcode4bch()
        {
            //=======生成BCH钱包二维码=======//
            string strCode = lb4bch0addr.Text;
            QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(strCode, QRCodeGenerator.ECCLevel.Q);
            QRCode qrcode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrcode.GetGraphic(5, Color.Teal, Color.White, null, 15, 6, false);
            MemoryStream ms = new MemoryStream();
            qrCodeImage.Save(ms, ImageFormat.Jpeg);
            qr4bch.Image = qrCodeImage;
        }
        void genQrcode4dash()
        {
            //=======生成DASH钱包二维码=======//
            string strCode = lb4dash0addr.Text;
            QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(strCode, QRCodeGenerator.ECCLevel.Q);
            QRCode qrcode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrcode.GetGraphic(5, Color.Teal, Color.White, null, 15, 6, false);
            MemoryStream ms = new MemoryStream();
            qrCodeImage.Save(ms, ImageFormat.Jpeg);
            qr4dash.Image = qrCodeImage;
        }
        void genQrcode4ltc()
        {
            //=======生成LTC钱包二维码=======//
            string strCode = lb4ltc0addr.Text;
            QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(strCode, QRCodeGenerator.ECCLevel.Q);
            QRCode qrcode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrcode.GetGraphic(5, Color.Teal, Color.White, null, 15, 6, false);
            MemoryStream ms = new MemoryStream();
            qrCodeImage.Save(ms, ImageFormat.Jpeg);
            qr4ltc.Image = qrCodeImage;
        }
        void genQrcode4zec()
        {
            //=======生成ZEC钱包二维码=======//
            string strCode = lb4zec0addr.Text;
            QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(strCode, QRCodeGenerator.ECCLevel.Q);
            QRCode qrcode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrcode.GetGraphic(5, Color.Teal, Color.White, null, 15, 6, false);
            MemoryStream ms = new MemoryStream();
            qrCodeImage.Save(ms, ImageFormat.Jpeg);
            qr4zec.Image = qrCodeImage;
        }
        //=======判断是否上网=======//
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(int Description, int ReservedValue);
        bool IsConnectInternet()
        {
            int Description = 0;
            return InternetGetConnectedState(Description, 0);
        }
        //=======判断是否上网=======//
        private void Form1_Load(object sender, EventArgs e)
        {
            if (IsConnectInternet() == true)
            {
                lb4netstatus.Text = "√ 网络已连接，一切准备就绪";
                lb4netstatus.ForeColor = Color.Teal;
                //getBTCprice();
                //getBCHprice();
                //getDASHprice();
                //getLTCprice();
                //getZECprice();
            }
            else
            {
                lb4netstatus.Text = "× 网络未连接，无法同步钱包数据";
                lb4netstatus.ForeColor = Color.Gray;
            }
            getcoinsprice();
            getsync();
            cmb4zec0hisnum.SelectedIndex = 0;
            FileStream fsrd = File.OpenRead(@"config/apikey.cain");
            StreamReader sr = new StreamReader(fsrd, System.Text.Encoding.Default);
            string strrd = sr.ReadToEnd();
            sr.Close();
            fsrd.Close();
            apikey = strrd;
            txt4apikey.Text = apikey;
            genQrcode4btc();
            genQrcode4bch();
            genQrcode4dash();
            genQrcode4ltc();
            genQrcode4zec();
        }
        private void cb4showapi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb4showapi.Checked == true)
            {
                txt4apikey.PasswordChar = '\0';
            }
            else
            {
                txt4apikey.PasswordChar = '*'; 
            }
        }
        private void timer4sync_Tick(object sender, EventArgs e)
        {
            getsync();
        }
        private void btn4sync_Click(object sender, EventArgs e)
        {
            getsync();
            toolTip4clip.SetToolTip(btn4sync, "同步完成");
        }
        private void lb4btc0addr_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lb4btc0addr.Text);
            toolTip4clip.SetToolTip(lb4btc0addr, "钱包地址已复制到剪贴板");
        }
        private void lb4bch0addr_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lb4bch0addr.Text);
            toolTip4clip.SetToolTip(lb4bch0addr, "钱包地址已复制到剪贴板");
        }
        private void lb4dash0addr_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lb4dash0addr.Text);
            toolTip4clip.SetToolTip(lb4dash0addr, "钱包地址已复制到剪贴板");
        }
        private void lb4ltc0addr_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lb4ltc0addr.Text);
            toolTip4clip.SetToolTip(lb4ltc0addr, "钱包地址已复制到剪贴板");
        }
        private void lb4zec0addr_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lb4zec0addr.Text);
            toolTip4clip.SetToolTip(lb4zec0addr, "钱包地址已复制到剪贴板");
        }
        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            toolTip4clip.RemoveAll();
        }
        private void btn4zec0gethis_Click(object sender, EventArgs e)
        {
            dgv4zec0his.Rows.Clear();
            try
            {
                Post1("history/count", "wallet", zec0oid);
                JObject jo4zec0his0count = (JObject)JsonConvert.DeserializeObject(strValue);
                string his0count4zec = jo4zec0his0count["history_count"].ToString();
                lb4hiscount.Text= "显示             条，共 "+ his0count4zec + " 条";
                string maxnumtxt = cmb4zec0hisnum.SelectedItem.ToString();
                int maxnum = int.Parse(maxnumtxt);
                Post3("history", "wallet", zec0oid, "offset", "0", "limit", maxnumtxt);
                JObject jo4zec0history = (JObject)JsonConvert.DeserializeObject(strValue);
                JArray ja4zec0history = (JArray)JsonConvert.DeserializeObject(jo4zec0history["history"].ToString());
                for (int i = 0; i < maxnum; i++)
                {
                    try
                    {
                        string his4zec0amount = ja4zec0history[i]["amount"].ToString();
                        string his4zec0txid = ja4zec0history[i]["txid"].ToString();
                        string his4zec0address = ja4zec0history[i]["address"].ToString();
                        string his4zec0failed = ja4zec0history[i]["failed"].ToString();
                        string his4zec0created_at = ja4zec0history[i]["created_at"].ToString();
                        string his4zec0request_id = ja4zec0history[i]["request_id"].ToString();
                        dgv4zec0his.Rows.Add();
                        if (his4zec0amount.Substring(0, 1) == "-")
                        {
                            dgv4zec0his.Rows[i].Cells[0].Value = "支出";
                        }
                        else
                        {
                            dgv4zec0his.Rows[i].Cells[0].Value = "收入";
                        }
                        dgv4zec0his.Rows[i].Cells[1].Value = (double.Parse(his4zec0amount) / 100000000).ToString();
                        dgv4zec0his.Rows[i].Cells[2].Value = his4zec0created_at;
                        dgv4zec0his.Rows[i].Cells[3].Value = his4zec0address;
                        dgv4zec0his.Rows[i].Cells[4].Value = his4zec0txid;
                        if (his4zec0failed == "False")
                        {
                            dgv4zec0his.Rows[i].Cells[5].Value = "否";
                        }
                        else
                        {
                            dgv4zec0his.Rows[i].Cells[5].Value = "是";
                        }
                    }
                    catch
                    {
                        
                    }
                }
            }
            catch
            {
                MessageBox.Show("无法发送请求！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn4test_Click(object sender, EventArgs e)
        {
            genQrcode4zec();
        }
        private void btn4send0zec_Click(object sender, EventArgs e)
        {

        }
        private void txt4zec0send0amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
            //小数点的处理。
            if ((int)e.KeyChar == 46)//小数点
            {
                if (txt4zec0send0amount.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void qr4zec_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lb4zec0addr.Text);
            toolTip4clip.SetToolTip(qr4zec, "钱包地址已复制到剪贴板");
        }
    }
}
