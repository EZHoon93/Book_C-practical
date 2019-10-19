//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Section04 {
//    class Program {
//        static void Main(string[] args) {
//            SampleCode test = new SampleCode();
//            test.ToUpper();
//        }
//    }

//    class SampleCode  {
//        public void Trim1() {
//            var target = "   non-whitespace characters   ";
//            var replaced = target.Trim();
//            Console.WriteLine("[{0}]", replaced);
//        }

//        public void Trim2() {
//            var target = "   non-whitespace characters   ";
//            var replaced1 = target.TrimStart();
//            var replaced2 = target.TrimEnd();
//            Console.WriteLine("[{0}]\n[{1}]", replaced1, replaced2);
//        }

//        public void Remove() {
//            var target = "01234ABC567";
//            var result = target.Remove(5, 3);
//            Console.WriteLine(result);
//        }


//        public void Insert() {
//            var target = "01234";
//            var result = target.Insert(2, "abc");
//            Console.WriteLine(result);
//        }

//        public void Replace() {
//            var target = "I hope you could come with us.";
//            var replaced = target.Replace("hope", "wish");
//            Console.WriteLine(replaced);
//        }


//        public void ToUpper() {
//            var target = "C# The quick brown fox jumps over the lazy dog.";
//            var replaced = target.ToLower();
//            Console.WriteLine(replaced);
//        }



//    }
//}
