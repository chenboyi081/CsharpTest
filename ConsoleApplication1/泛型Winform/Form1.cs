using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 泛型.泛型的类型参数约束;
using 泛型.泛型方法.泛型方法的应用;
using 泛型;

namespace 泛型Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntList intlist = new IntList();
            intlist.Add(1);
            intlist.Add(2);
            intlist.Add(3);

            MessageBox.Show(intlist[0].ToString());

            泛型.StringList slist = new StringList();
            slist.Add("100");


            MyList<int> glist = new MyList<int>();
            glist.Add(200);
            MessageBox.Show(glist.ToString());

            MyList<string> glist1 = new MyList<string>();
            glist1.Add("200");
            MessageBox.Show(glist1.ToString());

            //缓存泛型方法的调用演示
            Pig pig = CacheMgr.GetData<Pig>("pigkey");
        }
    }
}
