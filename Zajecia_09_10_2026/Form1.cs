using System.Reflection;

namespace Zajecia_09_10_2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] liczby = Sortowanie.Konwertuj(tbLiczby.Text);

            //Sortowanie.Babelkowe(liczby);
            var metoda = (MethodInfo)cbMetodaSortowania.SelectedItem;
            metoda.Invoke(null, new object[] { liczby });

            tbWynik.Text = String.Join(" ", liczby);
        }

        private void cbMetodaSortowania_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var metody = typeof(Sortowanie).GetMethods().Where(m => m.GetParameters().Length == 1 
                                                               && m.GetParameters().First().ParameterType == typeof(int[]) 
                                                               //&& m.ReturnType == typeof(void)
                                                               && m.IsStatic).ToArray();
            //cbMetodaSortowania.Items.AddRange(metody);
            cbMetodaSortowania.DataSource = metody;
            cbMetodaSortowania.DisplayMember = "Name";
        }
    }
}
