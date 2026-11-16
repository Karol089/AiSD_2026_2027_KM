using System.Text.RegularExpressions;

namespace Zajecia_13_11_2026
{
    public partial class Form1 : Form
    {
        private static readonly Regex illegalName = new Regex(@"\s+");
        private static Dictionary<String, Drzewo> MyTrees = new Dictionary<String, Drzewo>();

        public static String TrimName(String name)
        {
            return illegalName.Replace(name, "");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbChooseTree.DataSource = MyTrees.Keys; // Nie działa, do dokończenia
        }

        private void btAddTree_Click(object sender, EventArgs e)
        {
            String name = TrimName(tbAddTree.Text);
            if (!(name.Equals("")))
            {
                MyTrees.Add(name, new Drzewo());
                rtbDisplay.Text = "Utworzono nowe drzewo o nazwie " + name;
            }
            else
            {
                rtbDisplay.Text = "Nie można utowrzyć drzewa o pustej nazwie.";
            }

        }

        private void btDispTrees_Click(object sender, EventArgs e)
        {
            String text = "";
            foreach(String name in MyTrees.Keys)
            {
                text += name + "\n" + MyTrees[name].giveInfo() + "\n";
            }
            rtbDisplay.Text = text;
        }



        // Prosty test
        private void btRun_Click(object sender, EventArgs e)
        {
            Wezel myRoot = new Wezel(8);
            Wezel element1 = new Wezel(3);

            Drzewo myTree = new Drzewo(myRoot);
            myTree.addBST(element1);
            myTree.addBST(10);
            myTree.addBST(7);
            myTree.addBST(2);
            myTree.addBST(12);

            /*rtbDisplay.Text = myRoot.ToString() + "\nLeft child: " + myRoot.getLeftChild().getValue() + "\nRight child: " + myRoot.getRightChild().getValue() + 
                "\nElements in tree: " + myTree.getNumElem();*/
            rtbDisplay.Text = myTree.giveInfo();
        }     
    }
}
