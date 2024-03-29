﻿
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Section01 {
//    class Program {
//        static void Main(string[] args) {
//            SampleCode test = new SampleCode();
//            test.ReadLinesSelectSample();
//        }
//    }

//    class SampleCode  {
//        // 서식 전체를 쓰면 @"C:\Example\Greeting.txt"; 이지만
//        // 간단히 실행할 수 있도록 @"Greeting.txt" 로 썼습니다.

//        public void ReadLineSample() {
//            var filePath = @"Greeting.txt";
//            if (File.Exists(filePath)) {
//                using (var reader = new StreamReader(filePath, Encoding.UTF8)) {
//                    while (!reader.EndOfStream) {
//                        var line = reader.ReadLine();
//                        Console.WriteLine(line);
//                    }
//                }
//            }
//        }

//        public void ReadLineSample2() {
//            var filePath = @"Greeting.txt";
//            if (File.Exists(filePath)) {
//                using (var reader = new StreamReader(filePath, Encoding.UTF8)) {
//                    string line = null;
//                    while ((line = reader.ReadLine()) != null) {
//                        Console.WriteLine(line);
//                    }
//                }
//            }
//        }

//        public void ReadLineSample3() {
//            string filePath = @"Greeting.txt";
//            StreamReader reader = new StreamReader(filePath, Encoding.UTF8);
//            try {
//                while (!reader.EndOfStream) {
//                    var line = reader.ReadLine();
//                    Console.WriteLine(line);
//                }
//            } finally {
//                reader.Dispose();
//            }
//        }


//        public void ReadAllLinesSample() {
//            var filePath = @"Greeting.txt";
//            var lines = File.ReadAllLines(filePath, Encoding.UTF8);
//            foreach (var line in lines) {
//                Console.WriteLine(line);
//            }
//        }

//        public void ReadLinesSample() {
//            var filePath = @"sample.txt";
//            var lines = File.ReadLines(filePath, Encoding.UTF8);
//            foreach (var line in lines) {
//                Console.WriteLine(line);
//            }
//        }

//        public void ReadLinesTakeSample() {
//            var filePath = @"sample.txt";
//            var lines = File.ReadLines(filePath, Encoding.UTF8)
//                            .Take(10)
//                            .ToArray();
//            foreach (var line in lines) {
//                Console.WriteLine(line);
//            }
//        }

//        public void ReadLinesCountSample() {
//            var filePath = @"sample.txt";
//            var count = File.ReadLines(filePath, Encoding.UTF8)
//                            .Count(s => s.Contains("C#"));
//            Console.WriteLine(count);
//        }


//        public void ReadLinesWhereSample() {
//            var filePath = @"sample.txt";
//            var lines = File.ReadLines(filePath, Encoding.UTF8)
//                            .Where(s => !String.IsNullOrWhiteSpace(s))
//                            .ToArray();
//            foreach (var line in lines) {
//                Console.WriteLine(line);
//            }
//        }

//        public void ReadLinesAnySample() {
//            var filePath = @"sample.txt";
//            var exists = File.ReadLines(filePath, Encoding.UTF8)
//                             .Where(s => !String.IsNullOrEmpty(s))
//                             .Any(s => s.All(c => Char.IsDigit(c)));

//            Console.WriteLine(exists);
//        }

//        public void ReadLinesDistinctSample() {
//            var filePath = @"sample2.txt";
//            var lines = File.ReadLines(filePath, Encoding.UTF8)
//                            .Distinct()
//                            .OrderBy(s => s.Length)
//                            .ToArray();
//            foreach (var line in lines) {
//                Console.WriteLine(line);
//            }
//        }

//        public void ReadLinesSelectSample() {
//            var filePath = @"sample.txt";
//            var lines = File.ReadLines(filePath)
//                            .Select((s, ix) => String.Format("{1,3}: {1}", ix + 1, s))
//                            .ToArray();
//            foreach (var line in lines) {
//                Console.WriteLine(line);
//            }
//        }


//    }
//}
