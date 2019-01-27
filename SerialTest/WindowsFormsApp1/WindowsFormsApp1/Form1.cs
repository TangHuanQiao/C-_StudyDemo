using System;
using System.IO.Ports;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] portList = System.IO.Ports.SerialPort.GetPortNames();//获取系统可用串口
            for (int i = 0; i < portList.Length; ++i)
            {
                string name = portList[i];
                PortNameComboBox.Items.Add(name);
            }
            PortNameComboBox.Text = portList[0];
            BaudRateComboBox.Text = "9600";

            serialPort1.DataReceived+=new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived);


        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        { 

            
            if (!RecHexRadioButton.Checked)
            {
                string str = serialPort1.ReadExisting();
                textBox1.AppendText(str);

            }else
            {
                byte[] readBuffer = new byte[serialPort1.ReadBufferSize + 1];
                int count = serialPort1.Read(readBuffer, 0, serialPort1.ReadBufferSize);
                if(count != 0)
                {
                    if(readBuffer[0]==0xab)
                    Console.WriteLine(" ---- readBuffer[0]==(byte)0xab --");

                    String SerialIn = null;

                    for (int i = 0; i < count; i++)
                       {
                        SerialIn += "0x" + readBuffer[i].ToString("X2") + " ";//字符串ASCIIstr2 为对应的ASCII（16进制）字符串
                       }

                    textBox1.AppendText(SerialIn);

                }



            }



        }




        private void OpenBtn_Click(object sender, EventArgs e)//打开
        {
            try
            {
                serialPort1.PortName = PortNameComboBox.Text;
                serialPort1.BaudRate = Convert.ToInt32(BaudRateComboBox.Text, 10);
                serialPort1.Open();
                OpenBtn.Enabled = false;
                CloseBtn.Enabled = true;


            }
            catch
            {
                MessageBox.Show("打开端口失败", "提示：");

            }
        }
         
        private void CloseBtn_Click(object sender, EventArgs e)//关闭
        {
            try
            {
                serialPort1.Close();
                OpenBtn.Enabled = true;
                CloseBtn.Enabled = false;
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)//发送
        {
           
            if(serialPort1.IsOpen&&textBox2.Text!="")
            {
                if (!SendHexRadioButton.Checked)
                {
                    try
                    {
                        serialPort1.Write(textBox2.Text);
                    }catch
                    {
                        MessageBox.Show("写入失败", "提示：");
                        serialPort1.Close();
                        OpenBtn.Enabled = true;
                        CloseBtn.Enabled = false;
                
                    }

                    

                }else
                {
                    string str = textBox2.Text.ToString();
                    str = str.Replace(" ", "");

                    if(IsHexadecimal(str)!=true)
                    {
                        MessageBox.Show("请输入hex格式", "提示：");
                        

                    }else
                    {

                        byte[] Data = strToHexByte(str);

                        try
                        {
                            serialPort1.Write(Data, 0, Data.Length);
                        }
                        catch
                        {
                            MessageBox.Show("写入失败", "提示：");
                            serialPort1.Close();
                            OpenBtn.Enabled = true;
                            CloseBtn.Enabled = false;

                        }

                    }
                       
                }

            }
     

        }

        private static byte[] strToHexByte(string hexString)
        {
            if ((hexString.Length % 2) != 0)
                hexString=hexString.Insert(hexString.Length-1,"0");

            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
            {
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }
              
            return returnBytes;
        }

        private static bool IsHexadecimal(string str)
        {
            const string PATTERN = "^[0-9A-Fa-f]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(str, PATTERN);
        }

    }
}
