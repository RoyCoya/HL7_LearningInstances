using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegexFunction
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(Regex_RegexRule.Text);
            Regex_Result.Clear();

            if (regex.IsMatch(Regex_OriginalText.Text))
            {
                MatchCollection mc = regex.Matches(Regex_OriginalText.Text);

                for (int i = 0; i < mc.Count; i++)
                {
                    Regex_Result.Text += mc[i].Value + "\r\n";
                    GroupCollection gc = mc[i].Groups;

                    for (int j = 0; j < gc.Count; j++)
                    {
                        Regex_Result.Text += "\t\t" + gc[j].Value + "\r\n";
                    }

                }


            }
            else MessageBox.Show("查无结果!");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(Regex_RegexRule.Text);
            Regex_Result.Clear();

            Regex_Result.Text = regex.Replace(Regex_OriginalText.Text, (Match m) => { return m.Value.ToUpper(); });
        }

        private void Regex_MakeCode_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(Regex_RegexRule.Text);
            Regex_AutoCodeResult.Clear();

            if (regex.IsMatch(Regex_OriginalText.Text))
            {
                MatchCollection mc = regex.Matches(Regex_OriginalText.Text);
                string template = @"public class " + Regex_ClassName.Text + @":Segment
    {
";

                string constructor = @"public CE(CompositeData parent, string name) : base(parent, name)
        {";
                for (int i = 0; i < mc.Count; i++)
                {
                    GroupCollection gc = mc[i].Groups;
                    string name = gc[2].Value;
                    Regex upper = new Regex(@"\b\w");
                    name = upper.Replace(name, (Match a) => { return a.Value.ToUpper(); });
                    name = name.Replace(" ", "");

                    template += @"public " + gc[3].Value + " " + name + @"
        {
            get { return data[" + i + @"] as " + gc[3].Value + @"; }
            set { data[" + i + @"] = value; }
        }
";
                    constructor += @"
data[" + i + @"] = new " + gc[3].Value +@"("""+ name + @""");";
                }

                constructor += "\n}";

                template += constructor;
                template += "\n}";

                Regex_AutoCodeResult.Text = template;
            }
            else MessageBox.Show("查无结果!");
        }
    }
}
