using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace LabelSee
{
    public partial class Form1 : Form
    {
        public string folderpath = "";
        public string xmlpath = "";
        public Pic[] pics = new Pic[0];
        public int picindex = 0;
        public int nowindex = 0;
        public string h;
        public string w;
        public string l;
        public string t;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttoncxml_Click(object sender, EventArgs e)
        {
            //选择xml文件
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "xml文件(*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                xmlpath = openFileDialog.FileName;
                string xmlname = Path.GetFileName(xmlpath);
                folderpath = xmlpath.Replace(xmlname, "");
            }
            output("已选择文件：" + Path.GetFileName(xmlpath));
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            //载入xml文件，显示第一张
            if (xmlpath != "")
            {
                XmlTextReader xr = new XmlTextReader(xmlpath);
                while (xr.Read())
                {
                    XmlNodeType nt = xr.NodeType;
                    xr.WhitespaceHandling = WhitespaceHandling.None;
                    if (nt == XmlNodeType.Element)
                    {
                        if (xr.Name == "image")
                        {
                            picindex++;
                            Array.Resize(ref pics, picindex);
                            pics[picindex - 1] = new Pic(Path.Combine(folderpath, xr.GetAttribute("file")));
                        }
                        if (xr.Name == "box")
                        {
                            h = xr.GetAttribute("height");
                            w = xr.GetAttribute("width");
                            l = xr.GetAttribute("left");
                            t = xr.GetAttribute("top");
                            Box b = new Box(h, w, t, l);
                            pics[picindex - 1].AddRect(b.GetRect());
                        }
                    }
                }
                MessageBox.Show("读取成功！");
                output("已读取" + pics.Length + "张图片。");
                See(nowindex);
            }
            else
            {
                MessageBox.Show("请选择xml文件地址。");
            }
        }

        private void buttonlast_Click(object sender, EventArgs e)
        {
            //显示前一张
            if (xmlpath != "")
            {
                nowindex--;
                See(nowindex);
                if (nowindex < 0)
                {
                    nowindex++;
                }
            }
            else
            {
                MessageBox.Show("请选择xml文件地址。");
            }
        }

        private void buttonnext_Click(object sender, EventArgs e)
        {
            //显示后一张
            if (xmlpath != "")
            {
                nowindex++;
                See(nowindex);
                if (nowindex >= picindex)
                {
                    nowindex--;
                }
            }
            else
            {
                MessageBox.Show("请选择xml文件地址。");
            }
        }

        public void See(int index)
        {
            //显示选中编号的图片，并绘制方框
            if (index < 0)
            {
                MessageBox.Show("没有上一张图片！");
            }
            else if (index >= picindex)
            {
                MessageBox.Show("没有下一张图片！");
            }
            else
            {
                Image img = Image.FromFile(pics[index].filepath);
                Graphics gps = Graphics.FromImage(img);
                for (int i = 0; i < pics[index].boxes.Length; i++)
                {
                    gps.DrawRectangle(new Pen(Color.Red, 1), pics[index].boxes[i]);
                }
                pictureBox.Image = img;
                output("已读取第" + index + "张图片。");
            }
        }

        public void output(string str)
        {
            //输出信息
            textBoxinfo.AppendText(str + "\r\n");
        }

        public class Pic
        {
            //用于保存图片信息的类
            public string filepath;
            public Rectangle[] boxes = new Rectangle[0];
            private int index = 0;

            public Pic(string filepath)
            {
                //用图片地址初始化
                this.filepath = filepath;
            }

            public void AddRect(Rectangle r)
            {
                //可以添加任意个标注
                index++;
                Array.Resize(ref boxes, index);
                boxes[index - 1] = r;
            }
        }

        public class Box
        {
            //用于生成方框的类
            public int height;
            public int width;
            public int top;
            public int left;

            public Box(string height, string width, string top, string left)
            {
                //用字符串初始化
                this.height = Convert.ToInt32(height);
                this.width = Convert.ToInt32(width);
                this.top = Convert.ToInt32(top);
                this.left = Convert.ToInt32(left);
            }

            public Rectangle GetRect()
            {
                //生成方框
                return new Rectangle(left, top, width, height);
            }
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否退出？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
                Process.GetCurrentProcess().Kill();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
