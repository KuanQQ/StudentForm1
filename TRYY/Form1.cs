using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TRYY
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string name = textBox1.Text;
			int english, chinese, mathscore;
			if (!int.TryParse(textBox2.Text, out english))
			{
				MessageBox.Show("請輸入英文成績", "你完蛋了", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!int.TryParse(textBox3.Text, out chinese))
			{
				MessageBox.Show("請輸入國文成績", "你完蛋了", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!int.TryParse(textBox4.Text, out mathscore))
			{
				MessageBox.Show("請輸入數學成績", "你完蛋了", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				var student = new Student(name,english,chinese,mathscore);
				textBox5.Text = student.Score();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
	}
}
