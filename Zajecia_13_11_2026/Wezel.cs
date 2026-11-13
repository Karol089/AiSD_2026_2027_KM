using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_13_11_2026
{
    internal class Wezel
    {
        private int value;
        private Wezel leftChild;
        private Wezel rightChild;
        private Wezel parent;

        public Wezel(int value)
        {
            this.value = value;
        }

        public int getValue()
        {
            return this.value;
        }

        public Wezel getLeftChild()
        {
            return this.leftChild;
        }

        public Wezel getRightChild()
        {
            return this.rightChild;
        }

        public Wezel getParent()
        {
            return this.parent;
        }

        public void setLeftChild(Wezel wezel)
        {
            this.leftChild = wezel;
        }

        public void setRightChild(Wezel wezel)
        {
            this.rightChild = wezel;
        }

        public void setParent(Wezel wezel)
        {
            this.parent = wezel;
        }

        public override string ToString()
        {
            return "Value = " + this.value;
        }
    }
}
