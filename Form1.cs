using SerialPortHelper.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.IO;

namespace SerialPortHelper
{
    public partial class Form1 : Form
    {
        List<string> historyDataLists = new List<string>() { };
        int Rx_Length = 0;
        int Tx_Length = 0;

        public Form1()
        {
            InitializeComponent();

            comboBox_BaudRate.SelectedIndex = 0;
        }

        /* 打开链接 */
        private void toolStripStatusLabel_Link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.z10.xin");
        }


        /* 打开串口按钮 */
        private void toolStripButton_SerialOpen_Click(object sender, EventArgs e)
        {
            /* 判断按钮是否为 Checked 状态 */
            if (toolStripButton_SerialOpen.CheckState == CheckState.Checked)
            {
                toolStripStatusLabel_SerialPortStatus.Text = "串口已打开";
                toolStripStatusLabel_SerialPortStatus.ForeColor = Color.Black;
                toolStripButton_SerialOpen.Image = Resources.icons8_link_32px;
                toolStripButton_SerialOpen.ToolTipText = "串口: ON";

                try
                {
                    // 串口名
                    serialPort1.PortName = comboBox_Port.Text;
                    // 波特率
                    serialPort1.BaudRate = int.Parse(comboBox_BaudRate.Text);
                    // 数据位
                    serialPort1.DataBits = int.Parse(comboBox_DataBit.Text);
                    /* 设置停止位 */
                    if (comboBox_StopBit.Text == "1")
                    {
                        serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    }else if (comboBox_StopBit.Text == "1.5")
                    {
                        serialPort1.StopBits = System.IO.Ports.StopBits.OnePointFive;
                    }
                    else if (comboBox_StopBit.Text == "2")
                    {
                        serialPort1.StopBits = System.IO.Ports.StopBits.Two;
                    }
                    /* 设置奇偶校验 */
                    if (comboBox_Parity.Text == "None")
                    {
                        serialPort1.Parity = System.IO.Ports.Parity.None;
                    }
                    else if (comboBox_Parity.Text == "Odd")
                    {
                        serialPort1.Parity = System.IO.Ports.Parity.Odd;
                    }
                    else if (comboBox_Parity.Text == "Even")
                    {
                        serialPort1.Parity = System.IO.Ports.Parity.Even;
                    }
                    else if (comboBox_Parity.Text == "Mark")
                    {
                        serialPort1.Parity = System.IO.Ports.Parity.Mark;
                    }
                    else if (comboBox_Parity.Text == "Space")
                    {
                        serialPort1.Parity = System.IO.Ports.Parity.Space;
                    }
                    /* 控制流 */
                    if(comboBox_ControlFlow.Text == "None")
                    {
                        serialPort1.RtsEnable = false;
                        
                    }
                    else if(comboBox_ControlFlow.Text == "RTS/CTS")
                    {
                        serialPort1.RtsEnable = true;
                    }
                    else if (comboBox_ControlFlow.Text == "XON/XOFF")
                    {
                        
                    }
                        serialPort1.Open(); // 打开串口
                    button_Send.Enabled = true;
                }
                catch(Exception err)
                {
                    MessageBox.Show("打开失败" + err.ToString(), "提示!");
                }
            }
            else
            {
                toolStripStatusLabel_SerialPortStatus.Text = "串口已关闭";
                toolStripStatusLabel_SerialPortStatus.ForeColor = Color.Red;
                toolStripButton_SerialOpen.Image = Resources.icons8_broken_32px;
                toolStripButton_SerialOpen.ToolTipText = "串口: OFF";

                
                try
                {
                    serialPort1.Close();
                    button_Send.Enabled = false;
                    checkBox_AutoSend.Checked = false;
                }
                catch(Exception)
                {
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox_BaudRate.Text = ConfigurationManager.AppSettings["BaudRate"].ToString();
            comboBox_DataBit.Text = ConfigurationManager.AppSettings["DataBit"].ToString();
            comboBox_Parity.Text = ConfigurationManager.AppSettings["Parity"].ToString();
            comboBox_StopBit.Text = ConfigurationManager.AppSettings["StopBit"].ToString();
            comboBox_ControlFlow.Text = ConfigurationManager.AppSettings["ControlFlow"].ToString();
            checkBox_AutoEnter.Checked = bool.Parse(ConfigurationManager.AppSettings["AutoEnter"].ToString());
            checkBox_ShowSend.Checked = bool.Parse(ConfigurationManager.AppSettings["ShowSend"].ToString());
            checkBox_ShowTime.Checked = bool.Parse(ConfigurationManager.AppSettings["ShowTime"].ToString());
            numericUpDown_AutoSendTime.Value = decimal.Parse(ConfigurationManager.AppSettings["AutoSendTime"].ToString());
            button_Send.Enabled = false;
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            comboBox_Port.Items.AddRange(ports);
            comboBox_Port.SelectedIndex = comboBox_Port.Items.Count > 0 ? 0 : -1;
            serialPort1.ReadTimeout = 1000;
            if (richTextBox_Receive.Text == "")
            {
                toolStripButton_Clean.Enabled = false;
            }
            else
            {
                toolStripButton_Clean.Enabled = true;
            }
        }

        // 接收文本框文本变化
        private void richTextBox_Receive_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox_Receive.Text == "")
            {
                toolStripButton_Clean.Enabled = false;
            }
            else
            {
                toolStripButton_Clean.Enabled = true;
            }
        }

        // 清空接收区文本
        private void toolStripButton_Clean_Click(object sender, EventArgs e)
        {
            richTextBox_Receive.Text = "";
        }

        // 显示/隐藏侧边栏
        private void toolStripButton_LeftSwitch_Click(object sender, EventArgs e)
        {
            if(panel_Left.Visible == true)
            {
                panel_Left.Visible = false;
            }
            else
            {
                panel_Left.Visible = true;
            }
        }

        // 文件(F) 》 退出
        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save_config();
            this.Close();
            Application.Exit();
        }

        private void comboBox_BaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(comboBox_BaudRate.SelectedIndex);
        }

        /*
         * 串口接收函数
         * 
         */
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int len = serialPort1.BytesToRead; // 获取可以读取的字节数
            Console.WriteLine(len);
            byte[] buff = new byte[len]; // 创建缓存数据数组
            serialPort1.Read(buff, 0, len); // 把数据读取到buff数组
            string str = "";
            Rx_Length += len;
            toolStripStatusLabel_Rx.Text = "Rx: " + Rx_Length.ToString() + "Bytes";

            if (checkBox_AutoEnter.Checked)
            {
                str = Encoding.Default.GetString(buff) + System.Environment.NewLine; // Byte值根据ASCII码表转为 String
            }
            else
            {
                str = Encoding.Default.GetString(buff); // Byte值根据ASCII码表转为 String
            }
            
            Invoke((new Action(() =>
            {
                if (radioButton_ReceiveAscii.Checked)
                {
                    richTextBox_Receive.AppendText(str);
                }
                if (radioButton_ReceiveHex.Checked)
                {
                    if (checkBox_AutoEnter.Checked)
                    {
                        richTextBox_Receive.AppendText(byteToHexStr(buff) + System.Environment.NewLine);
                    }
                    else
                    {
                        richTextBox_Receive.AppendText(byteToHexStr(buff));
                    }
                    
                }
                // 自动滚动到底部
                richTextBox_Receive.SelectionStart = richTextBox_Receive.Text.Length;
                richTextBox_Receive.ScrollToCaret();
                richTextBox_Receive.Refresh();


            })));
        }

        // <字节数组转16进制字符串>
        public static string byteToHexStr(byte[] bytes)
        {
            string returnStr = "";
            try
            {
                if(bytes != null)
                {
                    for(int i=0; i < bytes.Length; i++)
                    {
                        returnStr += bytes[i].ToString("x2");
                        returnStr += " ";
                    }
                }
                return returnStr;
            }
            catch (Exception)
            {
                return returnStr;
            }
        }

        // 发送数据按钮
        private void button_Send_Click(object sender, EventArgs e)
        {
            sendData(textBox_Send);
        }

        // 用户发送历史 comboBox_History
        private void comboBox_History_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Send.Text = comboBox_History.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sendData(textBox_Send);
        }

        // 是否自动发送
        private void checkBox_AutoSend_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AutoSend.Checked)
            {
                if (serialPort1.IsOpen)
                {
                    Console.WriteLine("打开自动发送");
                    timer1.Enabled = true;
                    timer1.Interval = int.Parse(numericUpDown_AutoSendTime.Value.ToString());
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("串口未打开，请先打开串口...");
                }
                
            }
            else
            {
                Console.WriteLine("关闭自动发送");
                timer1.Stop();
            }
        }

        //发送函数
        private void sendData(TextBox textbox_send)
        {
            string sendStr = textbox_send.Text;

            try
            {
                if (sendStr.Length > 0)
                {
                    Tx_Length += sendStr.Length;
                    toolStripStatusLabel_Tx.Text = "Tx: " + Tx_Length.ToString() + " Bytes";
                    Console.WriteLine(comboBox_BaudRate.Text);
                    if (!comboBox_History.Items.Contains(sendStr))
                    {
                        comboBox_History.Items.Add(sendStr);
                        comboBox_History.Text = sendStr;
                    }

                    //判断是否显示发送数据
                    if(checkBox_ShowTime.Checked && checkBox_ShowSend.Checked)
                    {
                        richTextBox_Receive.AppendText("[发送数据: " + sendStr + " 数据长度: " + sendStr.Length.ToString() + " 时间: " + DateTime.Now.ToString() + "]" + System.Environment.NewLine);
                    } 
                    else if (checkBox_ShowSend.Checked)
                    {
                        richTextBox_Receive.AppendText("[发送数据: " + sendStr + " 数据长度: " + sendStr.Length.ToString() + "]" + System.Environment.NewLine);
                    } 
                    else if(checkBox_ShowTime.Checked)
                    {
                        richTextBox_Receive.AppendText("[时间: " + DateTime.Now.ToString() + "]" + System.Environment.NewLine);
                    }
                    serialPort1.Write(sendStr);
                }
            }
            catch (Exception)
            {

            }
        }

        // 帮助(H) > 关于
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm = new about();
            aboutForm.ShowDialog();
        }

        // 保持参数函数
        private void save_config()
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["BaudRate"].Value = comboBox_BaudRate.Text;
                config.AppSettings.Settings["DataBit"].Value = comboBox_DataBit.Text;
                config.AppSettings.Settings["Parity"].Value = comboBox_Parity.Text;
                config.AppSettings.Settings["StopBit"].Value = comboBox_StopBit.Text;
                config.AppSettings.Settings["ControlFlow"].Value = comboBox_ControlFlow.Text;
                config.AppSettings.Settings["AutoEnter"].Value = checkBox_AutoEnter.Checked.ToString();
                config.AppSettings.Settings["ShowSend"].Value = checkBox_ShowSend.Checked.ToString();
                config.AppSettings.Settings["ShowTime"].Value = checkBox_ShowTime.Checked.ToString();
                config.AppSettings.Settings["AutoSendTime"].Value = numericUpDown_AutoSendTime.Value.ToString();
                //分配权限
                //MessageBox.Show(config.FilePath.Replace(@"\Tools.App.exe.Config", ""));
                addpathPower(config.FilePath.Replace(@"\Tools.App.exe.Config", ""), "Everyone", "FullControl");
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception)
            {
                MessageBox.Show("读写配置文件出错，请检查安装目录是否有读写权限。");
            }
            
        }
        /// <summary>
        /// 为创建的临时文件分配权限
        /// </summary>
        /// <param name="pathname"></param>
        /// <param name="username"></param>
        /// <param name="power"></param>
        /// <remarks>SKY 2007-8-6</remarks>
        public void addpathPower(string pathname, string username, string power)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(pathname);

            if ((dirinfo.Attributes & FileAttributes.ReadOnly) != 0)
            {
                dirinfo.Attributes = FileAttributes.Normal;
            }

            //取得访问控制列表
            DirectorySecurity dirsecurity = dirinfo.GetAccessControl();

            switch (power)
            {
                case "FullControl":
                    dirsecurity.AddAccessRule(new FileSystemAccessRule(username, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit, PropagationFlags.InheritOnly, AccessControlType.Allow));
                    break;
                case "ReadOnly":
                    dirsecurity.AddAccessRule(new FileSystemAccessRule(username, FileSystemRights.Read, AccessControlType.Allow));
                    break;
                case "Write":
                    dirsecurity.AddAccessRule(new FileSystemAccessRule(username, FileSystemRights.Write, AccessControlType.Allow));
                    break;
                case "Modify":
                    dirsecurity.AddAccessRule(new FileSystemAccessRule(username, FileSystemRights.Modify, AccessControlType.Allow));
                    break;
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            save_config();
        }

    }
}
