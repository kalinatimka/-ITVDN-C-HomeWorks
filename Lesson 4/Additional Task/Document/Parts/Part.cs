using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    abstract class Part
    {
        protected string content;
        public abstract string Content { set; protected get; }
        public abstract void Show();
    }
}
