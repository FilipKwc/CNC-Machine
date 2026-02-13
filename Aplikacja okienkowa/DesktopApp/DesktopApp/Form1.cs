using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ServoKontroler
{
    public partial class Form1 : Form
    {
        string dataout;
        string L = "L";
        string S = "S";
        //     public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        //      {
        //         using (var ms = new MemoryStream())
        //         {
        //             imageIn.Save(ms, imageIn.RawFormat);
        //             return ms.ToArray();
        //        }
        //     }
        public Form1()
        {
            InitializeComponent();
            string inputPath = @"C:\test\smok1.bmp";
            string outputTxt = @"C:\test\output.txt";
            string outputBin = @"C:\test\output.bin";

            using (Bitmap bitmap = new Bitmap(inputPath))
            using (StreamWriter writerTxt = new StreamWriter(outputTxt))
            using (BinaryWriter writer = new BinaryWriter(File.Open(outputBin, FileMode.Create)))
            {
                writerTxt.WriteLine("0x02"); 

                for (int y = 0; y < bitmap.Height; y++)
                {
                    writerTxt.Write("0x01 ");    // Początek wiersza
                                                


                    for (int x = 0; x < bitmap.Width; x++)
                    {
                        Color pixel = bitmap.GetPixel(x, y);
                        byte grayValue = (byte)((pixel.R + pixel.G + pixel.B) / 3); // Konwersja na 8-bit

                        writerTxt.Write(grayValue + " ");
                        writer.Write(grayValue); // Zapis wartości piksela jako bajt
                    }

                    writerTxt.WriteLine("/n"); // Koniec wiersza
                    writer.Write((byte)0x0A); 
                }

                writerTxt.WriteLine("0x03"); // Koniec bitmapy
                writer.Write((byte)0x03); 
            }
            byte[] imageData = File.ReadAllBytes(@"C:\test\output.txt");
            byte[] imageBin = File.ReadAllBytes(@"C:\test\output.bin");

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            CboxCport.Items.AddRange(ports);
        }





        private void COM_PORT_Click(object sender, EventArgs e)
        {

        }

        private void OPEN_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = CboxCport.Text;
                serialPort1.BaudRate = Convert.ToInt32(CboxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(CboxDatabits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CboxStopbits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), CboxParitybits.Text);
                serialPort1.Open();
                progressBar1.Value = 100;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "error", MessageBoxButtons.OK);
            }
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
        }





         private async void button1_Click(object sender, EventArgs e)
          {

   

        if (serialPort1.IsOpen)
        {
            byte[] imageBin = File.ReadAllBytes(@"C:\test\output.bin");
         
               for (int i = 0; i < imageBin.Length; i++)
               {
                   byte b = imageBin[i];
                   serialPort1.Write(new byte[] { imageBin[i] }, 0, 1);
                    await Task.Delay(1);


               }

          }

        }


        

        // USTAW swoją szerokość linii w bajtach!
        /*       private async void button1_Click(object sender, EventArgs e)
               {
                   if (serialPort1.IsOpen)
                   {
                       byte[] imageBin = File.ReadAllBytes(@"C:\test\output.bin");
                       int bytesinraw = 52;
                       int alllinesinbitmap = imageBin.Length / bytesinraw;

                       for (int line = 0; line < alllinesinbitmap; line++)
                       {

                           int startByte = line * bytesinraw;
                           int endByte = startByte + bytesinraw;

                           for (int i = startByte; i < endByte; i++)
                           {
                               serialPort1.Write(new byte[] { imageBin[i] }, 0, 1);
                               await Task.Delay(2000); 
                           }

                           while (true)
                           {
                               if (serialPort1.BytesToRead > 0)
                               {
                                    int ack = serialPort1.ReadByte();

                                   if (ack == 'p')
                                   {
                                       break; 
                                   }
                               }
                               await Task.Delay(10);
                           }
                       }

                   }
               }*/
        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                serialPort1.Write("1");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                serialPort1.Write("7");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                serialPort1.Write("3");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                serialPort1.Write("6");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                serialPort1.Write("2");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                serialPort1.Write("4");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                serialPort1.Write("5");
            }
        }
    }
}
