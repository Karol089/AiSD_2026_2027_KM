namespace Zajecia_13_11_2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

            rtbDisplay.Text = myRoot.ToString() + "\nLeft child: " + myRoot.getLeftChild().getValue() + "\nRight child: " + myRoot.getRightChild().getValue() + 
                "\nElements in tree: " + myTree.getNumElem();
        }
    }
}
