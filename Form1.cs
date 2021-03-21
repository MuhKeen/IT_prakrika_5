using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_prakrika_5
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int index = listBox1.SelectedIndex;
      string str = (string)listBox1.Items[index];
      int len = str.Length; 
      int i = 0;
      label1.Text = "";
      while (i < len)
      {
        if (str[i] == ' ')
        {
          label1.Text += "";
        }
        else label1.Text += str[i]; 
        i++;
      }
    }
  }
}
