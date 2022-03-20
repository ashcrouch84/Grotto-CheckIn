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
using System.Net;
using Renci.SshNet;

namespace Grotto_CheckIn
{
    public partial class Form1 : Form
    {
        int i;
        int lplace;
        string strMessage;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadSettings();
            //loadFile();
            txtRef.Focus();
            timer1.Enabled = true;
        }

        private void loadFile()
        {
            var list = new List<string>();
            string strread = "";

            string str_path = Properties.Settings.Default.savedControl.ToString();
            string str_grotto = "CheckIn.txt";
            string str_address = System.IO.Path.Combine(str_path, str_grotto);

            //check for when the family has been called
            try
            {
                strread = str_address;
                //MessageBox.Show(strread.ToString());
                var fileStream = new FileStream(strread, FileMode.Open, System.IO.FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
                fileStream.Close();

                i = 0;
                while (i < list.Count)
                {
                    string[] strBits = list[i].ToString().Split(',');
                    try { lstBook.Items.Add(strBits[0].ToString()); } catch { }
                    try { lstSofas.Items.Add(strBits[1].ToString()); } catch { }
                    try { lstRef.Items.Add(strBits[2].ToString()); } catch { }
                    try { lstQty.Items.Add(strBits[3].ToString()); } catch { }
                    try { lstTime.Items.Add(strBits[4].ToString()); } catch { }
                    i = i + 1;
                }
            }
            catch
            {

            }
        }

        private void loadSettings()
        {
            timer2.Interval = 1000;

            chkSofa.Checked = Properties.Settings.Default.savedSofas;
            txtAddress.Text = Properties.Settings.Default.savedAddress.ToString();
            txtControl.Text = Properties.Settings.Default.savedControl.ToString();
            txtPlace.Text = Properties.Settings.Default.savedPlace.ToString();

            txtPort.Text = Properties.Settings.Default.savedPort.ToString();
            txtHost.Text = Properties.Settings.Default.savedHost.ToString();
            txtPassword.Text = Properties.Settings.Default.savedPassword.ToString();
            txtUsername.Text = Properties.Settings.Default.savedUsername.ToString();

            txtInterval.Text = Properties.Settings.Default.savedInterval.ToString();
            timer1.Interval = Int32.Parse(txtInterval.Text);
        }

        private void txtRef_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtRef_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                findName();
            }
        }

        private void findName()
        {
            timer1.Enabled = false;
            var list = new List<string>();

            var list1 = new List<string>();
            var ftp_list = new List<string>();

            string str_ref = txtRef.Text;

            string strread = ""; 
            string Host = Properties.Settings.Default.savedHost.ToString();
            int Port = Int32.Parse(Properties.Settings.Default.savedPort);
            string Username = Properties.Settings.Default.savedUsername.ToString();
            string Password = Properties.Settings.Default.savedPassword.ToString();
            String LocalDestinationFilename = Properties.Settings.Default.savedPlace;
            string RemoteFolder = "";
            string c, b;


            try
            {
                string strName = DateTime.Now.ToString("ddMMyyyy") + "Bookings.txt";
                strread = Properties.Settings.Default.savedControl.ToString();
                strread = strread + "\\" + strName;
                //MessageBox.Show(strName);
                //MessageBox.Show(strread);

                ftp_list.Clear();

                using (var sftp = new SftpClient(Host, Port, Username, Password))
                {
                    sftp.Connect(); //connect to server

                    c = strName; //update download file from sftp
                    b = strread;//update download folder to pc 
                    try
                    {
                        using (var file = File.OpenWrite(b))
                        {
                            sftp.DownloadFile(c, file);//download file
                        }
                        
                    }
                    catch
                    {
                        MessageBox.Show("Problem downloading booking info, please find IT Elf", "Pictures :(");
                    }

                    try
                    {
                        var fileStream = new FileStream(strread, FileMode.Open, System.IO.FileAccess.Read);
                        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                        {
                            string line;
                            while ((line = streamReader.ReadLine()) != null)
                            {
                                list.Add(line);
                            }
                        }
                        fileStream.Close();

               
                        i = 0;
                        while (i<list.Count)
                        {
                            string[] strBits = list[i].ToString().Split(',');
                            if (strBits[0].ToString() == str_ref.ToString())
                            {
                                if (strBits[1].ToString()=="Adult")
                                {
                                    strMessage = strMessage +"Adult=" + strBits[2].ToString() +",";
                                    lstDetails.Items.Add("Adult = " + strBits[2].ToString());
                                }
                                if (strBits[1].ToString()=="Child")
                                {
                                    strMessage = strMessage + "Child=" + strBits[2].ToString() + ",";
                                    lstDetails.Items.Add("Child = " + strBits[2].ToString());
                                }
                            }
                            i = i + 1;
                        }
                        if (lstDetails.Items.Count == 0)
                        {
                            MessageBox.Show("Could not find family for this day, please check reference", "Reference Missing");
                            txtRef.Focus();
                            txtRef.Text = "";
                        }
                        else
                        {
                            if (Properties.Settings.Default.savedSofas == true)
                            {
                                groupBox1.Enabled = true;
                                cmdFind.Enabled = false;
                                txtRef.Enabled = false;
                            }
                            else
                            {
                                int x = 0;
                                string strNew = "";
                                while (x < lstDetails.Items.Count)
                                {
                                    strNew = strNew + lstDetails.Items[x].ToString() + " ";
                                    x = x + 1;
                                }
                                string strTime = DateTime.Now.ToString("HH:mm:ss");
                                lstTime.Items.Add(strTime);
                                lstRef.Items.Add(strNew);
                                lstSofas.Items.Add("0");
                                lstQty.Items.Add(lstDetails.Items.Count);
                                lstDetails.Items.Clear();
                                lstBook.Items.Add(txtRef.Text);
                                txtRef.Text = "";
                                txtRef.Focus();
                                groupBox1.Enabled = false;
                                updateList();
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Can't read file", "Error", MessageBoxButtons.OK);
                    }

                    
                }
            }
            catch
            {
                MessageBox.Show("Could not find family for this day, please check reference", "Reference Missing");
                txtRef.Focus();
                txtRef.Text = "";
            }
            timer1.Enabled = true;
        }

        private void updateList()
        {
            timer1.Enabled = false;
            txtRef.Enabled = true;
            cmdFind.Enabled = true;
            txtRef.Focus();
            int intattempts = 0;

            var list = new List<string>();

            sortLists();

            while (intattempts < 50)
            {
            try
            {
                    string str_path = Properties.Settings.Default.savedControl.ToString();
                    string str_grotto = "CheckIn.txt";
                    string str_address = System.IO.Path.Combine(str_path, str_grotto);

                    i = 0;
                    //MessageBox.Show(str_address);
                    while (i < lstRef.Items.Count)
                    {
                        list.Add(lstBook.Items[i].ToString() + "," + lstSofas.Items[i].ToString() + "," + lstRef.Items[i].ToString() + "," + lstQty.Items[i].ToString() + "," + lstTime.Items[i].ToString());
                        i = i + 1;
                    }

                    //var fileStream = new FileStream(str_address, FileMode.Open, System.IO.FileAccess.Read);
                    System.IO.File.WriteAllText(str_address, string.Empty);
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(str_address, true))
                    {
                        foreach (string line in list)
                        {
                            file.WriteLine(line);
                        }
                    }
                    //fileStream.Close();
                  intattempts = 100;
            }
            catch
            {
              intattempts = intattempts + 1;
            }
            }
            if (intattempts==50 || intattempts > 50 && intattempts < 100)
            {
                MessageBox.Show("Could not update controllers list, please get help", "HELP!!!");
            }
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(txtAddress.Text)) folderBrowserDialog1.SelectedPath = txtAddress.Text;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtAddress.Text = folderBrowserDialog1.SelectedPath;
                    Properties.Settings.Default.savedAddress = txtAddress.Text;
                    Properties.Settings.Default.Save();
                }
            }
            catch { }
            timer1.Enabled = true;
        }

        private void cmdControl_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(txtControl.Text)) folderBrowserDialog1.SelectedPath = txtControl.Text;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtControl.Text = folderBrowserDialog1.SelectedPath;
                    Properties.Settings.Default.savedControl = txtControl.Text;
                    Properties.Settings.Default.Save();
                }
            }
            catch { }
        }

        private void txtRef_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdPlace_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(txtPlace.Text)) folderBrowserDialog1.SelectedPath = txtPlace.Text;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtPlace.Text = folderBrowserDialog1.SelectedPath;
                    Properties.Settings.Default.savedPlace = txtPlace.Text;
                    Properties.Settings.Default.Save();
                }
            }
            catch { }
        }

        private void lstDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdS1_Click(object sender, EventArgs e)
        {
            string strTime = DateTime.Now.ToString("HH:mm:ss");
            lstTime.Items.Add(strTime);
            lstQty.Items.Add(lstDetails.Items.Count);
            lstRef.Items.Add(strMessage);
            lstSofas.Items.Add("1");
            lstDetails.Items.Clear();
            lstBook.Items.Add(txtRef.Text);
            txtRef.Text = "";
            txtRef.Focus();
            groupBox1.Enabled = false;
            updateList();
        }

        private void cmdS2_Click(object sender, EventArgs e)
        {
            string strTime = DateTime.Now.ToString("HH:mm:ss");
            lstTime.Items.Add(strTime); lstQty.Items.Add(lstDetails.Items.Count);
            lstRef.Items.Add(strMessage);
            lstSofas.Items.Add("2");
            lstDetails.Items.Clear();
            lstBook.Items.Add(txtRef.Text);
            txtRef.Text = "";
            txtRef.Focus();
            groupBox1.Enabled = false;
            updateList();
        }

        private void cmdS3_Click(object sender, EventArgs e)
        {
            string strTime = DateTime.Now.ToString("HH:mm:ss");
            lstTime.Items.Add(strTime); lstQty.Items.Add(lstDetails.Items.Count);
            lstRef.Items.Add(strMessage);
            lstSofas.Items.Add("3");
            lstDetails.Items.Clear();
            lstBook.Items.Add(txtRef.Text);
            txtRef.Text = "";
            txtRef.Focus();
            groupBox1.Enabled = false;
            updateList();
        }

        private void cmdS4_Click(object sender, EventArgs e)
        {
            string strTime = DateTime.Now.ToString("HH:mm:ss");
            lstTime.Items.Add(strTime); lstQty.Items.Add(lstDetails.Items.Count);
            lstRef.Items.Add(strMessage);
            lstSofas.Items.Add("4");
            lstDetails.Items.Clear();
            lstBook.Items.Add(txtRef.Text);
            txtRef.Text = "";
            txtRef.Focus();
            groupBox1.Enabled = false;
            updateList();
        }

        private void cmdS5_Click(object sender, EventArgs e)
        {
            string strTime = DateTime.Now.ToString("HH:mm:ss");
            lstTime.Items.Add(strTime); lstQty.Items.Add(lstDetails.Items.Count);
            lstRef.Items.Add(strMessage);
            lstSofas.Items.Add("5");
            lstDetails.Items.Clear();
            lstBook.Items.Add(txtRef.Text);
            txtRef.Text = "";
            txtRef.Focus();
            groupBox1.Enabled = false;
            updateList();
        }

        private void cmdS6_Click(object sender, EventArgs e)
        {
            string strTime = DateTime.Now.ToString("HH:mm:ss");
            lstTime.Items.Add(strTime); lstQty.Items.Add(lstDetails.Items.Count);
            lstRef.Items.Add(strMessage);
            lstSofas.Items.Add("6");
            lstDetails.Items.Clear();
            lstBook.Items.Add(txtRef.Text);
            txtRef.Text = "";
            txtRef.Focus();
            groupBox1.Enabled = false;
            updateList();
        }

        private void cmdS7_Click(object sender, EventArgs e)
        {
            string strTime = DateTime.Now.ToString("HH:mm:ss");
            lstTime.Items.Add(strTime); lstQty.Items.Add(lstDetails.Items.Count);
            lstRef.Items.Add(strMessage);
            lstSofas.Items.Add("7");
            lstDetails.Items.Clear();
            lstBook.Items.Add(txtRef.Text);
            txtRef.Text = "";
            txtRef.Focus();
            groupBox1.Enabled = false;
            updateList();
        }

        private void cmdS8_Click(object sender, EventArgs e)
        {
            string strTime = DateTime.Now.ToString("HH:mm:ss");
            lstTime.Items.Add(strTime); lstQty.Items.Add(lstDetails.Items.Count);
            lstRef.Items.Add(strMessage);
            lstSofas.Items.Add("8");
            lstDetails.Items.Clear();
            lstBook.Items.Add(txtRef.Text);
            txtRef.Text = "";
            txtRef.Focus();
            groupBox1.Enabled = false;
            updateList();
        }

        private void cmdS9_Click(object sender, EventArgs e)
        {
            string strTime = DateTime.Now.ToString("HH:mm:ss");
            lstTime.Items.Add(strTime); lstQty.Items.Add(lstDetails.Items.Count);
            lstRef.Items.Add(strMessage);
            lstSofas.Items.Add("9");
            lstDetails.Items.Clear();
            lstBook.Items.Add(txtRef.Text);
            txtRef.Text = "";
            txtRef.Focus();
            groupBox1.Enabled = false;
            updateList();
        }

        private void cmdS10_Click(object sender, EventArgs e)
        {
            string strTime = DateTime.Now.ToString("HH:mm:ss");
            lstTime.Items.Add(strTime); lstQty.Items.Add(lstDetails.Items.Count);
            lstRef.Items.Add(strMessage);
            lstSofas.Items.Add("10");
            lstDetails.Items.Clear();
            lstBook.Items.Add(txtRef.Text);
            txtRef.Text = "";
            txtRef.Focus();
            groupBox1.Enabled = false;
            updateList();
        }

        private void cmdS11_Click(object sender, EventArgs e)
        {
            string strTime = DateTime.Now.ToString("HH:mm:ss");
            lstTime.Items.Add(strTime); lstQty.Items.Add(lstDetails.Items.Count);
            lstRef.Items.Add(strMessage);
            lstSofas.Items.Add("11");
            lstDetails.Items.Clear();
            lstBook.Items.Add(txtRef.Text);
            txtRef.Text = "";
            txtRef.Focus();
            groupBox1.Enabled = false;
            updateList();
        }

        private void cmdS12_Click(object sender, EventArgs e)
        {
            string strTime = DateTime.Now.ToString("HH:mm:ss");
            lstTime.Items.Add(strTime); lstQty.Items.Add(lstDetails.Items.Count);
            lstRef.Items.Add(strMessage);
            lstSofas.Items.Add("12");
            lstDetails.Items.Clear();
            lstBook.Items.Add(txtRef.Text);
            txtRef.Text = "";
            txtRef.Focus();
            groupBox1.Enabled = false;
            updateList();
        }

        private void cmdS13_Click(object sender, EventArgs e)
        {
            string strTime = DateTime.Now.ToString("HH:mm:ss");
            lstTime.Items.Add(strTime); lstQty.Items.Add(lstDetails.Items.Count);
            lstRef.Items.Add(strMessage);
            lstSofas.Items.Add("13");
            lstDetails.Items.Clear();
            lstBook.Items.Add(txtRef.Text);
            txtRef.Text = "";
            txtRef.Focus();
            groupBox1.Enabled = false;
            updateList();
        }

        private void cmdS14_Click(object sender, EventArgs e)
        {
            string strTime = DateTime.Now.ToString("HH:mm:ss");
            lstTime.Items.Add(strTime); lstQty.Items.Add(lstDetails.Items.Count);
            lstRef.Items.Add(strMessage);
            lstSofas.Items.Add("14");
            lstDetails.Items.Clear();
            lstBook.Items.Add(txtRef.Text);
            txtRef.Text = "";
            txtRef.Focus();
            groupBox1.Enabled = false;
            updateList();
        }

        private void cmdS15_Click(object sender, EventArgs e)
        {
            string strTime = DateTime.Now.ToString("HH:mm:ss");
            lstTime.Items.Add(strTime); lstQty.Items.Add(lstDetails.Items.Count);
            lstRef.Items.Add(strMessage);
            lstSofas.Items.Add("15");
            lstDetails.Items.Clear();
            lstBook.Items.Add(txtRef.Text);
            txtRef.Text = "";
            txtRef.Focus();
            groupBox1.Enabled = false;
            updateList();
        }

        private void cmdS16_Click(object sender, EventArgs e)
        {
            string strTime = DateTime.Now.ToString("HH:mm:ss");
            lstTime.Items.Add(strTime); lstQty.Items.Add(lstDetails.Items.Count);
            lstRef.Items.Add(strMessage);
            lstSofas.Items.Add("16");
            lstDetails.Items.Clear();
            lstBook.Items.Add(txtRef.Text);
            txtRef.Text = "";
            txtRef.Focus();
            groupBox1.Enabled = false;
            updateList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            try
            {
                Properties.Settings.Default.savedInterval = Int32.Parse(txtInterval.Text);
                Properties.Settings.Default.Save();
                timer1.Interval = Properties.Settings.Default.savedInterval;
            }
            catch
            {
                MessageBox.Show("Please ensure the interval is a valid integer");
            }
            timer1.Enabled = true;
        }

        private void cmdFind_Click(object sender, EventArgs e)
        {
            findName();
        }

        private void chkSofa_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.savedSofas=chkSofa.Checked;
            Properties.Settings.Default.Save();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void sortLists()
        {
            var sortSofa = new List<string>();
            var sortBook = new List<string>();
            var sortQty = new List<string>();
            var sortRef = new List<string>();
            var sortTime = new List<string>();
            i = 0;
            while (i<lstSofas.Items.Count)
            {
                sortSofa.Add(lstSofas.Items[i].ToString());
                sortBook.Add(lstBook.Items[i].ToString()); 
                sortQty.Add(lstQty.Items[i].ToString());   
                sortRef.Add(lstRef.Items[i].ToString());    
                sortTime.Add(lstTime.Items[i].ToString());
                i = i + 1;
            }
            string strT1, strT2, strT3, strT4, strT5;
            i = 0;
            while (i<sortSofa.Count-1)
            {
                if (Int32.Parse(sortSofa[i]) > Int32.Parse(sortSofa[i+1]))
                {
                    strT1 = sortSofa[i].ToString();
                    strT2 = sortBook[i].ToString();
                    strT3 = sortQty[i].ToString();
                    strT4 = sortRef[i].ToString();
                    strT5 = sortTime[i].ToString();
                    sortSofa[i] = sortSofa[i + 1];
                    sortBook[i] = sortBook[i + 1];
                    sortQty[i] = sortQty[i + 1];
                    sortRef[i] = sortRef[i + 1];
                    sortTime[i] = sortTime[i + 1];
                    sortSofa[i + 1] = strT1.ToString();
                    sortBook[i+1] = strT2.ToString();
                    sortQty[i + 1] = strT3.ToString();
                    sortRef[i + 1] = strT4.ToString();
                    sortTime[i + 1] = strT5.ToString();
                    i = 0;
                }
                else
                {
                    i = i + 1;
                }
            }
            i = 0;
            lstSofas.Items.Clear();
            lstRef.Items.Clear();
            lstBook.Items.Clear();
            lstTime.Items.Clear();
            lstQty.Items.Clear();
            while (i<sortSofa.Count)
            {
                lstSofas.Items.Add(sortSofa[i].ToString());
                lstRef.Items.Add(sortRef[i].ToString());
                lstBook.Items.Add(sortBook[i].ToString());
                lstTime.Items.Add(sortTime[i].ToString());
                lstQty.Items.Add(sortQty[i].ToString());
                i = i + 1;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var list = new List<string>();
            string strread = "";

            string str_path = Properties.Settings.Default.savedControl.ToString();
            string str_grotto = "CheckIn.txt";
            string str_address = System.IO.Path.Combine(str_path, str_grotto);

            //check for when the family has been called
            try
            {
                strread = str_address;
                //MessageBox.Show(strread.ToString());
                var fileStream = new FileStream(strread, FileMode.Open, System.IO.FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
                fileStream.Close();

                lstBook.Items.Clear();
                lstQty.Items.Clear();
                lstRef.Items.Clear();
                lstTime.Items.Clear();
                lstSofas.Items.Clear();
                lstWait.Items.Clear();

                i = 0;
                while (i < list.Count)
                {
                    string[] strBits = list[i].ToString().Split(',');
                    try { lstBook.Items.Add(strBits[0].ToString()); } catch { }
                    try { lstSofas.Items.Add(strBits[1].ToString()); } catch { }
                    try { lstRef.Items.Add(strBits[2].ToString()); } catch { }
                    try { lstQty.Items.Add(strBits[3].ToString()); } catch { }
                    try { lstTime.Items.Add(strBits[4].ToString()); } catch { }
                    try { lstWait.Items.Add("00:00"); } catch { }
                    i = i + 1;
                }
            }
            catch
            {

            }
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (lstTime.Items.Count > -1)
            {
                string startTime;
                string endTime;
                int y = 0;
                while (y < lstTime.Items.Count)
                {
                    try
                    {
                        startTime = lstTime.Items[y].ToString();
                        endTime = DateTime.Now.ToString("HH:mm:ss");
                        TimeSpan duration = DateTime.Parse(endTime).Subtract(DateTime.Parse(startTime));

                        lstWait.Items[y] = duration.ToString();
                    }
                    catch
                    { }
                    y = y + 1;
                }
            }
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            if (lplace > -1)
            {
                string strmessage = "Are you sure you want to remove " + lstBook.Items[lplace].ToString() + "?";
                DialogResult dg = MessageBox.Show(strmessage, "Remove family", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    lstSofas.Items.RemoveAt(lplace);
                    lstQty.Items.RemoveAt(lplace);
                    lstWait.Items.RemoveAt(lplace);
                    lstTime.Items.RemoveAt(lplace);
                    lstRef.Items.RemoveAt(lplace);
                    lstBook.Items.Remove(lplace);
                }
            }
        }

        private void lstSofas_Click(object sender, EventArgs e)
        {
            lplace = lstSofas.SelectedIndex;
            updateLists();
        }

        private void updateLists()
        {
            if (lplace >-1)
            {
                lstSofas.SelectedIndex = lplace;
                lstRef.SelectedIndex = lplace;
                lstQty.SelectedIndex = lplace;
                lstBook.SelectedIndex = lplace;
                lstTime.SelectedIndex = lplace;
                lstWait.SelectedIndex = lplace;
            }
        }

        private void lstBook_Click(object sender, EventArgs e)
        {
            lplace = lstBook.SelectedIndex;
            updateLists();
        }

        private void lstQty_Click(object sender, EventArgs e)
        {
            lplace = lstQty.SelectedIndex;
            updateLists();
        }

        private void lstRef_SelectedIndexChanged(object sender, EventArgs e)
        {
            lplace = lstDetails.SelectedIndex;
            updateLists();
        }

        private void lstTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            lplace = lstTime.SelectedIndex;
            updateLists();
        }

        private void lstWait_SelectedIndexChanged(object sender, EventArgs e)
        {
            lplace = lstWait.SelectedIndex;
            updateLists();
        }
    }
}
