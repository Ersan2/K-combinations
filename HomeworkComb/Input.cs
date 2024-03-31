using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkComb
{
    internal class Input
    {
    
        public  int N { get; set; }
      
        public int K { get; set; }

        public void InputData(TextBox textBox)
        {

            int n, k;

            int a;
            char b;

            char[] inputData;
      
        Random randomNumber = new Random();

           

            n = N;
            k = K;
           
            inputData = new char[n];

          
            for (int i = 0; i < n; i++)
            {  
                a = randomNumber.Next(0x0061, 0x007A);
             
                b = char.ConvertFromUtf32(a)[0];

                
                while (inputData.Contains(b))
                {

                    a = randomNumber.Next(0x0061, 0x007A);
                    b = char.ConvertFromUtf32(a)[0];
                }
                inputData[i] = b;



            }
            
            List<char> set = inputData.ToList();
            
           var combinations = GetKCombinations(set, k);

            
            textBox.AppendText(Environment.NewLine);
        
            foreach (var combination in combinations)
            {
                textBox.AppendText(string.Join(", ", combination));
                textBox.AppendText(Environment.NewLine);
            }
          


        }
        IEnumerable<IEnumerable<T>> GetKCombinations<T>(IEnumerable<T> list, int length)
        {
           
            if (length == 1) return list.Select(t => new T[] { t });

            
            return list.SelectMany((item, index) =>
     
            GetKCombinations(list.Skip(index + 1), length - 1)
           
            .Select(combination => (new[] { item}).Concat(combination)));
        }
    }

      

}
