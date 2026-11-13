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

        public int[] toTab(Drzewo myTree)
        {
            if (this.numElem < 1)
            {
                return new int[0];
            }
            int[] newTab = new int[this.numElem];
            preOrder(myTree.root, newTab, 0);
            return newTab;
        }

        public void preOrder(Wezel myElem, int[] target, int currElem) // Do dokończenia
        {
            target[currElem] = myElem.getValue();
            if(myElem.getLeftChild != null)
            {
                preOrder(myElem.getLeftChild(), target, currElem + 1);
            }
            if (myElem.getRightChild != null)
            {
                preOrder(myElem.getRightChild(), target, currElem + 1);
            }

        }

        public override string ToString()
        {
            return "Root value = " + this.root.getValue() + "\nNumber of elements: " + numElem;
        }

    }
}
