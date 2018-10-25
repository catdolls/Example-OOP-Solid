using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class BaseClass
    {
        public virtual string Color {
            get
            {
                return "green";
            }
        }
        public virtual string Character
        {
            get
            {
                return "P";
            }
        }

        public override string ToString()
        {
            return this.Color + " : " + this.Character;
        }
    }

    public class SubClassA : BaseClass
    {
        public override string Color
        {
            get
            {
                return "orange";
            }
        }
        public override string Character
        {
            get
            {
                return "A";
            }
        }
    }

    public class SubClassB : SubClassA
    {
        public string Style
        {
            get
            {
                return "italic";
            }
        }
        public override string Character
        {
            get
            {
                return "B";
            }
        }

        public override string ToString()
        {
            return this.Color + " : " + this.Character + " : " + this.Style;
        }
    }

}
