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
using Ivi.Visa.Interop;
using System.Globalization;

namespace E5071C_Tool
{
    public partial class Form1 : Form
    {
        string E5071C;
        bool init;
        string[] ReadResults;
        double num;


        private ResourceManager RM = new ResourceManager();
        private FormattedIO488 INST = new FormattedIO488();

        
        public void initmk()
        {
            try
            {
                var session = (Ivi.Visa.IMessageBasedSession)
                Ivi.Visa.GlobalResourceManager.Open(E5071C);

                for(int i = 1; i < 7; i++)
                {
                    string loop = i.ToString();

                    session.FormattedIO.WriteLine(":CALC1" + ":MARK" + loop + "?");
                    string readString = session.FormattedIO.ReadLine();
                    readString = readString.TrimEnd('\n');

                    if (readString == "1")
                    {
                        session.FormattedIO.WriteLine(":CALC1"+":MARK"+loop+":X?");
                        double num = double.Parse(session.FormattedIO.ReadLine(), NumberStyles.Float);
                        num = num / 1000000;

                        switch (i){

                            case 1:
                                textBox_MK1.Text = num.ToString();
                                checkBox1.Checked = true;
                                break;

                            case 2:
                                textBox_MK2.Text = num.ToString();
                                checkBox2.Checked = true;
                                break;

                            case 3:
                                textBox_MK3.Text = num.ToString();
                                checkBox3.Checked = true;
                                break;

                            case 4:
                                textBox_MK4.Text = num.ToString();
                                checkBox4.Checked = true;
                                break;

                            case 5:
                                textBox_MK5.Text = num.ToString();
                                checkBox5.Checked = true;
                                break;

                            case 6:
                                textBox_MK6.Text = num.ToString();
                                checkBox6.Checked = true;
                                break;


                        }
                        

                    }

                    
                }
                init = true;
                session.Dispose();
                session = null;

            }
            catch
            {

            }


        }

        public void initfreq()
        {
            string STAR = ":SENS1:FREQ:STAR?";
            string STOP = ":SENS1:FREQ:STOP?";
            string CENT = ":SENS1:FREQ:CENT?";
            string SPAN = ":SENS1:FREQ:SPAN?";

            try
            {
                double num;
                INST.IO = (IMessage)RM.Open(E5071C, AccessMode.NO_LOCK, 2000, "");
                INST.IO.Timeout = 5000;
                INST.IO.Clear();
                
                INST.WriteString(STAR, true);
                num = double.Parse(INST.ReadString(), NumberStyles.Float);
                num = num / 1000000;
                textBox_start.Text = num.ToString();

                INST.WriteString(STOP, true);
                num = double.Parse(INST.ReadString(), NumberStyles.Float);
                num = num / 1000000;
                textBox_stop.Text = num.ToString();

                INST.WriteString(CENT, true);
                num = double.Parse(INST.ReadString(), NumberStyles.Float);
                num = num / 1000000;
                textBox_center.Text = num.ToString();

                INST.WriteString(SPAN, true);
                num = double.Parse(INST.ReadString(), NumberStyles.Float);
                num = num / 1000000;
                textBox_span.Text = num.ToString();
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                if (INST.IO != null)
                {
                    INST.IO.Close();
                }
            }
        }
        public Form1()
        {
            InitializeComponent();

            E5071C = textBox_VISA.Text;

            initmk();
            initfreq();
        }


        private void button_start_Click(object sender, EventArgs e)
        {

            int f1 = int.Parse(textBox_start.Text);
            int f2 = int.Parse(textBox_stop.Text);

            if(f1 > f2)
            {
                MessageBox.Show("START > STOP");
                initfreq();
                return;
            }

            string STAR = ":SENS1:FREQ:STAR " + textBox_start.Text + "E6";
            try
            {
                INST.IO = (IMessage)RM.Open(E5071C, AccessMode.NO_LOCK, 2000, "");
                INST.IO.Timeout = 5000;

                INST.IO.Clear();
                INST.WriteString(STAR, true);

                

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                if (INST.IO != null)
                {
                    INST.IO.Close();
                }

            }

            initfreq();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            int f1 = int.Parse(textBox_start.Text);
            int f2 = int.Parse(textBox_stop.Text);

            if (f1 > f2)
            {
                MessageBox.Show("START > STOP");
                initfreq();
                return;
            }

            string STOP = ":SENS1:FREQ:STOP " + textBox_stop.Text + "E6";
            try
            {
                INST.IO = (IMessage)RM.Open(E5071C, AccessMode.NO_LOCK, 2000, "");
                INST.IO.Timeout = 5000;

                INST.IO.Clear();
                INST.WriteString(STOP, true);

              

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                if (INST.IO != null)
                {
                    INST.IO.Close();
                }
            }

            initfreq();
        }

        private void button_center_Click(object sender, EventArgs e)
        {
            string CENT = ":SENS1:FREQ:CENT " + textBox_center.Text + "E6";
            try
            {
                INST.IO = (IMessage)RM.Open(E5071C, AccessMode.NO_LOCK, 2000, "");
                INST.IO.Timeout = 5000;

                INST.IO.Clear();
                INST.WriteString(CENT, true);

              

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                if (INST.IO != null)
                {
                    INST.IO.Close();
                }
            }

            initfreq();
        }

        private void button_span_Click(object sender, EventArgs e)
        {
            string SPAN = ":SENS1:FREQ:SPAN " + textBox_span.Text + "E6";
            try
            {
                INST.IO = (IMessage)RM.Open(E5071C, AccessMode.NO_LOCK, 2000, "");
                INST.IO.Timeout = 5000;

                INST.IO.Clear();
                INST.WriteString(SPAN, true);

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                if (INST.IO != null)
                {
                    INST.IO.Close();
                }

            }

            initfreq();

        }

        private void button_recall_Click(object sender, EventArgs e)
        {
            
            try
            {
                int num = Convert.ToInt32(textBox_num.Text);
                string RECALL = ":MMEM:LOAD " + "\"D:\\State" + String.Format("{0:00}", num) + ".sta\"";

                INST.IO = (IMessage)RM.Open(E5071C, AccessMode.NO_LOCK, 2000, "");
                INST.IO.Timeout = 5000;

                INST.IO.Clear();
                INST.WriteString(RECALL, true);

            }
            catch
            {
                MessageBox.Show("ERROR");
                return;
            }
            finally
            {
                if (INST.IO != null)
                {
                    INST.IO.Close();
                }
            }

            initmk();
            initfreq();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("上書き保存しますか", "STATE",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if(result == DialogResult.Yes)
            {
                int num = Convert.ToInt32(textBox_num.Text);
                string SAVE = ":MMEM:STOR " + "\"D:\\State" + String.Format("{0:00}",num) + ".sta\"";
                try
                {
                    INST.IO = (IMessage)RM.Open(E5071C, AccessMode.NO_LOCK, 2000, "");
                    INST.IO.Timeout = 5000;

                    INST.IO.Clear();
                    INST.WriteString(SAVE, true);

                }
                catch
                {
                    MessageBox.Show("ERROR");
                }
                finally
                {
                    INST.IO.Close();

                }
            }


        }

        private void button_image_Click(object sender, EventArgs e)
        {
            string readfile = "\"D:\\ena_temp_image_bmp.bmp\"";
            string IMG = ":MMEM:STOR:IMAG " + readfile;
            string TRAN = ":MMEM:TRAN? " + readfile;
            string DELL = ":MMEM:DEL " + readfile;
            Byte[] data;

            try
            {
                INST.IO = (IMessage)RM.Open(E5071C, AccessMode.NO_LOCK, 2000, "");
                INST.IO.Timeout = 5000;

                INST.IO.Clear();
                INST.WriteString(IMG, true);
                INST.WriteString(TRAN, true);

                data = INST.ReadIEEEBlock(Ivi.Visa.Interop.IEEEBinaryType.BinaryType_UI1);

                SaveFileDialog SFD = new SaveFileDialog();
                SFD.Filter = "bmp files (*.bmp)|*.bmp";
                SFD.FilterIndex = 1;
                SFD.RestoreDirectory = true;

                if(SFD.ShowDialog() == DialogResult.OK)
                {
                   FileStream fs = new FileStream(SFD.FileName, FileMode.Create, FileAccess.Write);
                    //バイト型配列の内容をすべて書き込む
                   fs.Write(data, 0, data.Length);
                   //閉じる
                   fs.Close();
                }                

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                if (INST.IO != null)
                {
                    INST.IO.Close();
                }

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (init == true)
                {
                    if (checkBox1.Checked == true)
                    {
                        string MKR = ":CALC1:MARK1:X " + textBox_MK1.Text + "E6";


                        var session = (Ivi.Visa.IMessageBasedSession)
                        Ivi.Visa.GlobalResourceManager.Open(textBox_VISA.Text);
                        session.FormattedIO.WriteLine(":CALC1:MARK1 ON");
                        session.FormattedIO.WriteLine(MKR);
                        session.Dispose();
                        session = null;

                    }
                    else if (checkBox1.Checked == false)
                    {
                        var session = (Ivi.Visa.IMessageBasedSession)
                        Ivi.Visa.GlobalResourceManager.Open(textBox_VISA.Text);
                        session.FormattedIO.WriteLine(":CALC1:MARK1 OFF");
                        session.Dispose();
                        session = null;
                    }
                }
            }
            catch
            {

            }
        }

        private void button_end_Click(object sender, EventArgs e)
        {
            
            System.Runtime.InteropServices.Marshal.ReleaseComObject(INST);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(RM);
            INST = null;
            RM = null;
            Application.Exit();
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            
            string OPEN = ":SENS1:CORR:COLL:OPEN 1";
            try
            {
                INST.IO = (IMessage)RM.Open(E5071C, AccessMode.NO_LOCK, 2000, "");
                INST.IO.Timeout = 5000;

                INST.IO.Clear();
                INST.WriteString(OPEN, true);

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                if (INST.IO != null)
                {
                    INST.IO.Close();
                }

            }
        }

        private void button_short_Click(object sender, EventArgs e)
        {
            string SHOR = ":SENS1:CORR:COLL:SHOR 1";
            try
            {
                INST.IO = (IMessage)RM.Open(E5071C, AccessMode.NO_LOCK, 2000, "");
                INST.IO.Timeout = 5000;

                INST.IO.Clear();
                INST.WriteString(SHOR, true);

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                if (INST.IO != null)
                {
                    INST.IO.Close();
                }
            }
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            string LOAD = ":SENS1:CORR:COLL:LOAD 1";
            try
            {
                INST.IO = (IMessage)RM.Open(E5071C, AccessMode.NO_LOCK, 2000, "");
                INST.IO.Timeout = 5000;

                INST.IO.Clear();
                INST.WriteString(LOAD, true);

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                if (INST.IO != null)
                {
                    INST.IO.Close();
                }

            }
        }

        private void button_done_Click(object sender, EventArgs e)
        {
            string SEL = ":SENS1:CORR:COLL:METH:SOLT1 1";
            string DONE = ":SENS1:CORR:COLL:SAVE";
            try
            {
                INST.IO = (IMessage)RM.Open(E5071C, AccessMode.NO_LOCK, 2000, "");
                INST.IO.Timeout = 5000;

                INST.IO.Clear();
                INST.WriteString(SEL, true);
                INST.WriteString(DONE,true);

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                if (INST.IO != null)
                {
                    INST.IO.Close();
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string readfile = "\"D:\\ena_temp_S1P_RI.s1p\"";
            string SNP = ":MMEM:STOR:SNP:FORM MA";
            string STOR = ":MMEM:STOR:SNP:TYPE:S1P 1";
            string SAVE = ":MMEM:STOR:SNP " + readfile;

            string TRAN = ":MMEM:TRAN? " + readfile;

            string DELL = ":MMEM:DEL " + readfile;
            Byte[] data;

            try
            {
                INST.IO = (IMessage)RM.Open(E5071C, AccessMode.NO_LOCK, 2000, "");
                INST.IO.Timeout = 5000;

                INST.IO.Clear();
                INST.WriteString(SNP);
                INST.WriteString(STOR);
                INST.WriteString(SAVE);
                INST.WriteString(TRAN);

                data = INST.ReadIEEEBlock(Ivi.Visa.Interop.IEEEBinaryType.BinaryType_UI1);

                SaveFileDialog SFD = new SaveFileDialog();
                SFD.Filter = "s1p files (*.s1p)|*.s1p";
                SFD.FilterIndex = 1;
                SFD.RestoreDirectory = true;

                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(SFD.FileName, FileMode.Create, FileAccess.Write);
                    //バイト型配列の内容をすべて書き込む
                    fs.Write(data, 0, data.Length);
                    //閉じる
                    fs.Close();
                }

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                if (INST.IO != null)
                {
                    INST.IO.Close();
                }

            }

        }

        private void button_S1PDB_Click(object sender, EventArgs e)
        {
            string readfile = "\"D:\\ena_temp_S1P_RI.s1p\"";
            string SNP = ":MMEM:STOR:SNP:FORM DB";
            string STOR = ":MMEM:STOR:SNP:TYPE:S1P 1";
            string SAVE = ":MMEM:STOR:SNP " + readfile;

            string TRAN = ":MMEM:TRAN? " + readfile;

            string DELL = ":MMEM:DEL " + readfile;
            Byte[] data;

            try
            {
                INST.IO = (IMessage)RM.Open(E5071C, AccessMode.NO_LOCK, 2000, "");
                INST.IO.Timeout = 5000;

                INST.IO.Clear();
                INST.WriteString(SNP,true);
                INST.WriteString(STOR,true);
                INST.WriteString(SAVE,true);
                INST.WriteString(TRAN,true);

                data = INST.ReadIEEEBlock(Ivi.Visa.Interop.IEEEBinaryType.BinaryType_UI1);

                SaveFileDialog SFD = new SaveFileDialog();
                SFD.Filter = "s1p files (*.s1p)|*.s1p";
                SFD.FilterIndex = 1;
                SFD.RestoreDirectory = true;

                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(SFD.FileName, FileMode.Create, FileAccess.Write);
                    //バイト型配列の内容をすべて書き込む
                    fs.Write(data, 0, data.Length);
                    //閉じる
                    fs.Close();
                }

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                if(INST.IO != null)
                {
                    INST.IO.Close();
                }
               

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (init == true)
                {
                    if (checkBox2.Checked == true)
                    {
                        string MKR = ":CALC1:MARK2:X " + textBox_MK2.Text + "E6";


                        var session = (Ivi.Visa.IMessageBasedSession)
                        Ivi.Visa.GlobalResourceManager.Open(textBox_VISA.Text);
                        session.FormattedIO.WriteLine(":CALC1:MARK2 ON");
                        session.FormattedIO.WriteLine(MKR);
                        session.Dispose();
                        session = null;

                    }
                    else if (checkBox2.Checked == false)
                    {
                        var session = (Ivi.Visa.IMessageBasedSession)
                        Ivi.Visa.GlobalResourceManager.Open(textBox_VISA.Text);
                        session.FormattedIO.WriteLine(":CALC1:MARK2 OFF");
                        session.Dispose();
                        session = null;
                    }
                }
            }
            catch
            {
               
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (init == true)
                {
                    if (checkBox3.Checked == true)
                    {
                        string MKR = ":CALC1:MARK3:X " + textBox_MK3.Text + "E6";


                        var session = (Ivi.Visa.IMessageBasedSession)
                        Ivi.Visa.GlobalResourceManager.Open(textBox_VISA.Text);
                        session.FormattedIO.WriteLine(":CALC1:MARK3 ON");
                        session.FormattedIO.WriteLine(MKR);
                        session.Dispose();
                        session = null;

                    }
                    else if (checkBox3.Checked == false)
                    {
                        var session = (Ivi.Visa.IMessageBasedSession)
                        Ivi.Visa.GlobalResourceManager.Open(textBox_VISA.Text);
                        session.FormattedIO.WriteLine(":CALC1:MARK3 OFF");
                        session.Dispose();
                        session = null;
                    }
                }
            }
            catch
            {

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (init == true)
                {
                    if (checkBox4.Checked == true)
                    {
                        string MKR = ":CALC1:MARK4:X " + textBox_MK4.Text + "E6";


                        var session = (Ivi.Visa.IMessageBasedSession)
                        Ivi.Visa.GlobalResourceManager.Open(textBox_VISA.Text);
                        session.FormattedIO.WriteLine(":CALC1:MARK4 ON");
                        session.FormattedIO.WriteLine(MKR);
                        session.Dispose();
                        session = null;

                    }
                    else if (checkBox4.Checked == false)
                    {
                        var session = (Ivi.Visa.IMessageBasedSession)
                        Ivi.Visa.GlobalResourceManager.Open(textBox_VISA.Text);
                        session.FormattedIO.WriteLine(":CALC1:MARK4 OFF");
                        session.Dispose();
                        session = null;
                    }
                }
            }
            catch
            {

            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (init == true)
                {
                    if (checkBox5.Checked == true)
                    {
                        string MKR = ":CALC1:MARK5:X " + textBox_MK5.Text + "E6";


                        var session = (Ivi.Visa.IMessageBasedSession)
                        Ivi.Visa.GlobalResourceManager.Open(textBox_VISA.Text);
                        session.FormattedIO.WriteLine(":CALC1:MARK5 ON");
                        session.FormattedIO.WriteLine(MKR);
                        session.Dispose();
                        session = null;

                    }
                    else if (checkBox5.Checked == false)
                    {
                        var session = (Ivi.Visa.IMessageBasedSession)
                        Ivi.Visa.GlobalResourceManager.Open(textBox_VISA.Text);
                        session.FormattedIO.WriteLine(":CALC1:MARK5 OFF");
                        session.Dispose();
                        session = null;
                    }
                }
            }
            catch
            {

            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (init == true)
                {
                    if (checkBox6.Checked == true)
                    {
                        string MKR = ":CALC1:MARK6:X " + textBox_MK6.Text + "E6";


                        var session = (Ivi.Visa.IMessageBasedSession)
                        Ivi.Visa.GlobalResourceManager.Open(textBox_VISA.Text);
                        session.FormattedIO.WriteLine(":CALC1:MARK6 ON");
                        session.FormattedIO.WriteLine(MKR);
                        session.Dispose();
                        session = null;

                    }
                    else if (checkBox6.Checked == false)
                    {
                        var session = (Ivi.Visa.IMessageBasedSession)
                        Ivi.Visa.GlobalResourceManager.Open(textBox_VISA.Text);
                        session.FormattedIO.WriteLine(":CALC1:MARK6 OFF");
                        session.Dispose();
                        session = null;
                    }
                }
            }
            catch
            {

            }
        }

        private void button_hold_Click(object sender, EventArgs e)
        {
            string TRIGON = ":INIT1:CONT ON";
            string TRIGOFF =":INIT1:CONT OFF";
            
            bool FLG = false;

            try
            {
                

                if (button_hold.Text == "Contiuous")
                {
                    
                    button_hold.Text = "Hold";
                    textBox_log.ResetText();
                    FLG = true;
                }
                else if (button_hold.Text == "Hold")
                {
                    
                    button_hold.Text = "Contiuous";
                    FLG = false;
                }

                INST.IO = (IMessage)RM.Open(E5071C, AccessMode.NO_LOCK, 2000, "");
                INST.IO.Timeout = 5000;

                INST.IO.Clear();
                if(FLG == true)
                {
                    INST.WriteString(TRIGON, true);
                }
                else
                {
                    INST.WriteString(TRIGOFF, true);
                }

                if(FLG == false)
                {
                    INST.WriteString(":CALC1:MARK1:Y?");
                    string[] ReadResults = INST.ReadString().Split(',');

                    double num = double.Parse(ReadResults[0], NumberStyles.Float);
                    
                    textBox_log.Text = num.ToString();
                }

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                if (INST.IO != null)
                {
                    INST.IO.Close();
                }

            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (init == true)
                {
                    if (checkBox7.Checked == true)
                    {
                        var session = (Ivi.Visa.IMessageBasedSession)
                        Ivi.Visa.GlobalResourceManager.Open(textBox_VISA.Text);
                        session.FormattedIO.WriteLine(":CALC1:MARK7 ON");
                        session.Dispose();
                        session = null;

                    }
                    else if (checkBox7.Checked == false)
                    {
                        var session = (Ivi.Visa.IMessageBasedSession)
                        Ivi.Visa.GlobalResourceManager.Open(textBox_VISA.Text);
                        session.FormattedIO.WriteLine(":CALC1:MARK7 OFF");
                        session.Dispose();
                        session = null;
                    }
                }
            }
            catch
            {

            }
        }

        private void button_store_Click(object sender, EventArgs e)
        {
            string resultMK1 = null;
            string resultMK2 = null;
            string resultMK3 = null;
            string TEXTDATA = null;

            try
            {


                for (int i = 1; i < 4; i++)
                {

                    string loop = i.ToString();

                    INST.IO = (IMessage)RM.Open(E5071C, AccessMode.NO_LOCK, 2000, "");
                    INST.IO.Timeout = 5000;

                    INST.IO.Clear();
                    INST.WriteString(":SENS1: FREQ:SPAN " + "0E6", true);

                    switch (i)
                    {
                        case 1:
                            if (checkBox1.Checked == true)
                            {
                                INST.WriteString(":SENS1: FREQ:CENT " + textBox_MK1.Text + "E6", true);
                                INST.WriteString(":CALC1:MARK1:X " + textBox_MK1.Text + "E6", true);
                                INST.WriteString(":CALC1:MARK1:Y?");
                                ReadResults = INST.ReadString().Split(',');
                                num = double.Parse(ReadResults[0], NumberStyles.Float);
                                resultMK1 = num.ToString();
                            }

                            break;

                        case 2:
                            if (checkBox2.Checked == true)
                            {
                                INST.WriteString(":SENS1: FREQ:CENT " + textBox_MK1.Text + "E6", true);
                                INST.WriteString(":CALC1:MARK1:X " + textBox_MK1.Text + "E6", true);
                                INST.WriteString(":CALC1:MARK1:Y?");
                                ReadResults = INST.ReadString().Split(',');
                                num = double.Parse(ReadResults[0], NumberStyles.Float);
                                resultMK2 = num.ToString();
                            }

                            break;

                        case 3:
                            if (checkBox3.Checked == true)
                            {
                                INST.WriteString(":SENS1: FREQ:CENT " + textBox_MK1.Text + "E6", true);
                                INST.WriteString(":CALC1:MARK1:X " + textBox_MK1.Text + "E6", true);
                                INST.WriteString(":CALC1:MARK1:Y?");
                                ReadResults = INST.ReadString().Split(',');
                                num = double.Parse(ReadResults[0], NumberStyles.Float);
                                resultMK3 = num.ToString();
                            }

                            break;



                    }

                    string[] results = { textBox_MK1.Text, resultMK1, textBox_MK2.Text, resultMK2, textBox_MK3.Text, resultMK3 };

                    StreamWriter prow = new StreamWriter("C:\\pattern.csv", true, Encoding.Default);
                    for (int i = 0; i < results.Length; i++)
                    {
                        if (i == 0)
                        {
                            TEXTDATA = results[i] + ",";
                        }
                        else
                        {
                            TEXTDATA = TEXTDATA + results[i] + ",";
                        }

                    }
                    prow.WriteLine(TEXTDATA);
                    prow.Close();


                }


            }
            catch
            {

            }
        }
    }
    
}
