using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysTools
{
    public partial class GongShiJiSuanQi : Form
    {
        public GongShiJiSuanQi()
        {
            InitializeComponent();
        }

        private void cbKinds_KeyDown(object sender, KeyEventArgs e){}

        private void GongShiJiSuanQi_Load(object sender, EventArgs e)
        {
            pMianJi.Hide(); txtA.Hide();txtB.Hide();txtC.Hide();txtD.Hide();labelA.Text = "";labelB.Text = "";labelC.Text = "";labelD.Text = "";
            pTiJi.Hide();
        }

        private void cbKinds_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cbKinds.SelectedItem)
                {
                    case "体积类":
                        pMianJi.Hide();
                        pTiJi.Show();
                        break;
                    case "单位类":
                        break;
                    case "数学类":
                        break;
                    case "面积类":
                        pTiJi.Hide();
                        pMianJi.Show();
                        break;
                    default:
                        break;
                }
            }
            catch { }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cbXingZhuang.SelectedItem)
                {
                    case "长方形":
                        labelA.Text = "长（w）";
                        labelB.Text = "宽（h）";
                        labelC.Text = "";
                        txtA.Show();
                        txtB.Show();
                        txtC.Hide();
                        txtD.Hide();
                        labelD.Text = "";
                        pictureBox1.Image = SysTools.Properties.Resources.长方形;
                        break;
                    case "正方形":
                        labelA.Text = "边长（a）";
                        labelB.Text = "";
                        txtA.Show();
                        txtB.Hide();
                        labelC.Text = "";
                        txtC.Hide();
                        labelD.Text = "";
                        txtD.Hide();
                        pictureBox1.Image = SysTools.Properties.Resources.长方形;
                        break;
                    case "平行四边形":
                        labelA.Text = "边长(b)";
                        labelB.Text = "高(h)";
                        txtA.Show();
                        txtB.Show();
                        txtC.Hide();
                        txtD.Hide();
                        labelC.Text = "";
                        labelD.Text = "";
                        pictureBox1.Image = SysTools.Properties.Resources.平行四边形;
                        break;
                    case "圆形":
                        labelA.Text = "半径（r）";
                        labelB.Text = "π取值";
                        labelC.Text = "";
                        labelD.Text = "";
                        txtB.Text = "3.14";
                        txtA.Show();
                        txtB.Show();
                        txtC.Hide();
                        txtD.Hide();
                        pictureBox1.Image = SysTools.Properties.Resources.圆;
                        break;
                    case "椭圆形":
                        labelA.Text = "长轴半径（b）";
                        labelB.Text = "短轴半径（a）";
                        labelC.Text = "π取值";
                        labelD.Text = "";
                        txtA.Show();
                        txtB.Show();
                        txtC.Show();
                        txtD.Hide();
                        txtC.Text = "3.14";
                        pictureBox1.Image = SysTools.Properties.Resources.椭圆形;
                        break;
                    case "梯形":
                        labelA.Text = "上底（a）";
                        labelB.Text = "下底（b）";
                        labelC.Text = "高（h）";
                        labelD.Text = "";
                        txtA.Show();
                        txtB.Show();
                        txtC.Show();
                        txtD.Hide();
                        pictureBox1.Image = SysTools.Properties.Resources.梯形;
                        break;
                    case "圆环":
                        labelA.Text = "内径（r）";
                        labelB.Text = "外径（R）";
                        labelC.Text = "π取值";
                        labelD.Text = "";
                        txtA.Show();
                        txtB.Show();
                        txtC.Show();
                        txtD.Hide();
                        txtC.Text = "3.14";
                        pictureBox1.Image = SysTools.Properties.Resources.圆环;
                        break;
                    case "三角形":
                        labelA.Text = "底边（b）";
                        labelB.Text = "高（h）";
                        labelC.Text = "";
                        labelD.Text = "";
                        txtA.Show();
                        txtB.Show();
                        txtC.Hide();
                        txtD.Hide();
                        pictureBox1.Image = SysTools.Properties.Resources.三角形;
                        break;
                    default:
                        break;
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbXingZhuang.SelectedItem)
                {
                    case "长方形":
                        string[] Changresult =
                            {
                        "计算公式：",
                        "S=a*b",
                        " ="+txtA.Text+"*"+txtB.Text,
                        " ="+Convert.ToDouble(txtA.Text)*Convert.ToDouble(txtB.Text)
                    };
                        for (int i = 0; i < Changresult.Length; i++)
                        {
                            txtResult.AppendText(Changresult[i] + "\r\n");
                        }
                        break;
                    case "正方形":
                        string[] Zhengresult =
                            {
                        "计算公式：",
                        "S=a^2",
                        " ="+txtA.Text+"^2",
                        " ="+Convert.ToDouble(txtA.Text)*Convert.ToDouble(txtA.Text)
                    };
                        for (int i = 0; i < Zhengresult.Length; i++)
                        {
                            txtResult.AppendText(Zhengresult[i] + "\r\n");
                        }
                        break;
                    case "平行四边形":
                        string[] Pingresult =
                   {
                        "计算公式：",
                        "S=b*h",
                        " ="+txtA.Text+"*"+txtB.Text,
                        " ="+Convert.ToDouble(txtA.Text)*Convert.ToDouble(txtB.Text)
                    };
                        for (int i = 0; i < Pingresult.Length; i++)
                        {
                            txtResult.AppendText(Pingresult[i] + "\r\n");
                        }
                        break;
                    case "圆形":
                        string[] Yuanresult =
                   {
                        "计算公式：",
                        "S=π*r^2",
                        " ="+txtB.Text+"*"+txtA.Text+"^2",
                        " ="+Math.Pow(Convert.ToDouble(txtA.Text),2)*Convert.ToDouble(txtB.Text)
                    };
                        for (int i = 0; i < Yuanresult.Length; i++)
                        {
                            txtResult.AppendText(Yuanresult[i] + "\r\n");
                        }
                        break;
                    case "椭圆形":
                        string[] TuoYuanresult =
                   {
                        "计算公式：",
                        "S=π*a*b",
                        " ="+txtC.Text+"*"+txtA.Text+"*"+txtB.Text,
                        " ="+Convert.ToDouble(txtC.Text)*Convert.ToDouble(txtA.Text)*Convert.ToDouble(txtB.Text)
                    };
                        for (int i = 0; i < TuoYuanresult.Length; i++)
                        {
                            txtResult.AppendText(TuoYuanresult[i] + "\r\n");
                        }
                        break;
                    case "梯形":
                        string[] Tiresult =
                   {
                        "计算公式：",
                        "S=(a+b)*h*0.5",
                        " ="+"("+txtA.Text+"+"+txtB.Text+")"+"*"+txtC.Text+"*0.5",
                        " ="+(Convert.ToDouble(txtA.Text)+Convert.ToDouble(txtB.Text))*Convert.ToDouble(txtC.Text)*0.5
                    };
                        for (int i = 0; i < Tiresult.Length; i++)
                        {
                            txtResult.AppendText(Tiresult[i] + "\r\n");
                        }
                        break;
                    case "圆环":
                        string[] Huanresult =
                   {
                        "计算公式：",
                        "S=(R^2-r^2)*π",
                        " ="+"("+txtB.Text+"^2"+txtA.Text+"^2"+")"+"*π",
                        " ="+(Math.Pow(Convert.ToDouble(txtB.Text),2)-Math.Pow(Convert.ToDouble(txtA.Text),2))*Convert.ToDouble(txtC.Text)
                    };
                        for (int i = 0; i < Huanresult.Length; i++)
                        {
                            txtResult.AppendText(Huanresult[i] + "\r\n");
                        }
                        break;
                    case "三角形":
                        string[] Sanresult =
                   {
                        "计算公式：",
                        "S=b*h*0.5",
                        " ="+txtA.Text+"*"+txtB.Text+"*0.5",
                        " ="+Convert.ToDouble(txtA.Text)*Convert.ToDouble(txtB.Text)*0.5
                    };
                        for (int i = 0; i < Sanresult.Length; i++)
                        {
                            txtResult.AppendText(Sanresult[i] + "\r\n");
                        }
                        break;
                    default:
                        break;
                }
            }
            catch { }
        }
    }
}
