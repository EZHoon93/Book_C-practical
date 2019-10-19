// List 2-22

using System;
using System.Collections.Generic;
using System.IO;

namespace SalesCalculator {
    // 매출 계산 클래스
    public class SalesCounter
    {
        //세일 클래스를 리스트 생성, 
        //private List<Sale> _sales;
        private IEnumerable<Sale> _sales;


        //생성자
        public SalesCounter(string filePath)
        {
            _sales = ReadSales(filePath);
        }

        //점포별 매출을 구한다
        //public Dictionary<string, int> GetPerStoreSales()
        public IDictionary<string,int> GetPerStoreSales()
        {
            //Dictionary<string, int> dict = new Dictionary<string, int>();
            //Var로 바꾼다.
            var dict = new Dictionary<string, int>();

            foreach (var sale in _sales)
            {
                //딕셔너리에 이미있으면 더한다
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                //없으면 초기값을 설정해준다
                else
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }

        //매출 데이터를 읽어들인다, Sale 오브젝트의 리스트를 반환, 생성자에서 호출한다
        //private static List<Sale> ReadSales(string filePath)
        private static IEnumerable<Sale> ReadSales(string filePath)

        {
            var sales = new List<Sale>();
            //걍로에있는 파일을 전부읽어온다
            var lines = File.ReadAllLines(filePath);
            //모든줄을 한줄씩 읽는다
            foreach(var line in lines)
            {
                //토큰 ,로 나눈다
                var items = line.Split(',');
                //객체 이니셜라이즈 사용. 
                /* Sale sale = new Sale()
                 * sale.ShopName = items[0]; 
                 * 이렇게 사용X , 가독성을 떨어트린다.
                 * */
                var sale = new Sale
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                
                sales.Add(sale);
            }

            return sales;
        }
    }
}
