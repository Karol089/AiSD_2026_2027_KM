using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_13_11_2026
{
    internal class Drzewo
    {
        private Wezel root;
        private int numElem = 0;
        private static int currElem = 0;

        public Drzewo(Wezel root)
        {
            this.root = root;
            this.numElem += 1;
        }

        public Drzewo()
        {
        }

        public Wezel getRoot()
        {
            return this.root;
        }

        public int getNumElem()
        {
            return this.numElem;
        }

        public void addBST(Wezel wezel)
        {
            if(this.root == null)
            {
                this.root = wezel;
                this.numElem += 1;
                return;
            }

            Wezel temp = root;
            while (true)
            {
                if(wezel.getValue() < temp.getValue())
                {
                    if(temp.getLeftChild() == null)
                    {
                        temp.setLeftChild(wezel);
                        wezel.setParent(temp);
                        break;
                    }
                    temp = temp.getLeftChild();
                } else
                {
                    if(temp.getRightChild() == null)
                    {
                        temp.setRightChild(wezel);
                        wezel.setParent(temp);
                        break;
                    }
                    temp = temp.getRightChild();
                }
            }
            this.numElem += 1;
        }

        public void addBST(int value)
        {
            addBST(new Wezel(value));
        }

        public int[] toTab() // Do zrobienia: inOrder, postOrder
        {
            if (this.numElem < 1)
            {
                return new int[0];
            }
            int[] newTab = new int[this.numElem];
            preOrder(this.root, newTab);
            currElem = 0;
            return newTab;
        }

        public void preOrder(Wezel myElem, int[] target)
        {
            target[currElem] = myElem.getValue();
            currElem++;
            if(myElem.getLeftChild() != null)
            {
                preOrder(myElem.getLeftChild(), target);
            }
            if (myElem.getRightChild() != null)
            {
                preOrder(myElem.getRightChild(), target);
            }

        }

        public String giveInfo()
        {
            String output = "Root value = ";
            if (this.root != null)
            {
                output += this.root.getValue();
            } else
            {
                output += "Not set";
            }
            return output + "\nNumber of elements: " + numElem + "\nElements:\n" + this.ToString();
        }

        public override string ToString()
        {
            return String.Join(" ", this.toTab());
        }

    }
}
