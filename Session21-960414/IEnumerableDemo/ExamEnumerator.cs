using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    class ExamEnumerator : IEnumerator
    {
        private Question[] questions;
        private int currentIndex;
        public ExamEnumerator(Question[] _questions)
        {
            this.questions = _questions;
            this.currentIndex = -1;
        }

        public object Current
        {
            get
            {
                return questions[currentIndex];
            }
        }

        public bool MoveNext()
        {
            var length = questions.Length - 1;
            if (currentIndex < length)
            {
                currentIndex += 2;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
