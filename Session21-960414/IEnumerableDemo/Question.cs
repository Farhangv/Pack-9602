﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    class Question
    {
        public int Number { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return $"{this.Number}.{this.Text}";
        }
    }
}
