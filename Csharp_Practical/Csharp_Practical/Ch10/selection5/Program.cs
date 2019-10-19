using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//Backreference
namespace Section05 {
    class Program {
        static void Main(string[] args) {
            var test = new SampleCode();
            test.LazyMatchingWithQuantifier01();
        }
    }
    class SampleCode  {
        public void Quantifier01() {
            var text = "a123456 b123 Z12345 AX98765";
            var pattern = @"\b[a-zA-Z][0-9]{5,}\b";
            var matches = Regex.Matches(text, pattern);
            foreach (Match m in matches)
                Console.WriteLine("'{0}'", m.Value);
        }

        public void Quantifier02() {
            var text = "シーズン、ゴールド、シーソー、ゴールデンなどと一致します。スウェーデンやノートなどとは一致しません。";
            var pattern = @"(\b|[^\p{IsKatakana}])(\p{IsKatakana}ー\p{IsKatakana}{2,3})(\b|[^\p{IsKatakana}])";
            var matches = Regex.Matches(text, pattern);
            foreach (Match m in matches)
                Console.WriteLine("'{0}'", m.Groups[2]);
        }

        public void GreedyMatching() {
            var text = "<person><name>김삿갓</name><age>22</age></aperson>";
            var pattern = @"<.+>";
            var matches = Regex.Matches(text, pattern);
            foreach (Match m in matches)
                Console.WriteLine("'{0}'", m.Value);
        }

        public void LazyMatching() {
            var text = "<person><name>김삿갓</name><age>22</age></person>";
            var pattern = @"<(\w[^>]+)>";
            var matches = Regex.Matches(text, pattern);
            foreach (Match m in matches)
                Console.WriteLine("'{0}'", m.Groups[1].Value);
        }


        public void LazyMatchingWithQuantifier01() {
            var text = "<person><name>김삿갓</name><age>22</age></erson>";
            var pattern = @"<(\w+?)>";
            var matches = Regex.Matches(text, pattern);
            foreach (Match m in matches)
                Console.WriteLine("'{0}'", m.Groups[1].Value);
        }

        public void LazyMatchingWithQuantifier02() {
            var text = "<p>가나다라마</p><p>바사아자차</p>";
            var pattern = @"<p>(.*?)</p>";
            var matches = Regex.Matches(text, pattern);
            foreach (Match m in matches)
                Console.WriteLine("'{0}'", m.Groups[1].Value);
        }

        public void Backreference01() {
            var text = "도로를 지나가는 차들이 뛰뛰하고 경적을 울리면 반대쪽 차들이 빵빵하고 울렸다.";
            var pattern = @"(\w)\1";
            var matches = Regex.Matches(text, pattern);
            foreach (Match m in matches)
                Console.WriteLine("'{0}'", m.Value);
        }
        public void Backreference02() {
            var text = "기러기 펠리컨 청둥오리 오리너구리 토마토 pops push pop";
            var pattern = @"\b(\w)\w\1\b";
            var matches = Regex.Matches(text, pattern);
            foreach (Match m in matches)
                Console.WriteLine("'{0}'", m.Value);
        }

    }
}
