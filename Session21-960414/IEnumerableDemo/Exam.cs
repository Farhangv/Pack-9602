using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    class Exam:IEnumerable
    {
        public Question[] Questions { get; set; }

        public IEnumerator GetEnumerator()
        {
            //return Questions.GetEnumerator();
            return new ExamEnumerator(this.Questions);
        }
    }
}
