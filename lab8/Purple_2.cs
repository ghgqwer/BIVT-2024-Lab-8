using System;
using System.Linq;

namespace Lab_8{
    public class Purple_2 : Purple{
        private string[] _output;

        public string[] Output{
            get{
                if (_output == null){
                    return null;
                }
                string[] copy = new string[_output.Length];
                Array.Copy(_output, copy, _output.Length);
                return copy;
            }
        }

        public Purple_2(string input) : base(input) { 
            _output = new string[0];
        }

        public override void Review()
        {
            string[] lst = new string[0];
            char[] chars = Input.ToCharArray();
            string ans = "";
            //System.Console.WriteLine('q');
            int l = 0, target = 0;
            while (l < chars.Length){//цикл по левой границе
                int count = 0;//счетчик символов
                int r = l;//сначала правая граница это левая граница
                while (count < 50 && r < chars.Length){//двигаем пока граница не упрется в конец либо не станет 50+ символов
                    count++;
                    if (chars[r] == ' ' || r == chars.Length - 1){
                        target = r;//если пробел либо конец строки обозначаем за таргет
                    }
                    if (r+1 < chars.Length && chars[r+1]== ' '){//если следующий индекс существует и равен пробелу обозначаем за таргет его
                        target = r+1;
                    }
                    r++;//двигаем границу дальше
                }//на этом моменте у нас либо 50 символов либо мы делаем последнюю строку
                string tmp = "";
                //System.Console.WriteLine($"{l} - {target}");

                //заполняем строку 
                for (int i = l; i < target; i++){
                    tmp += chars[i];
                }
                //если строка последняя берем последний символ т е точку
                if (target + 1 >= chars.Length-1){
                    tmp += chars[target];
                }

                tmp = SpaceBetween(tmp.Trim());//.Trim убирает пробелы в начале и конце
                
                //если не последняя строчка переносим строку
                if (target+1 < chars.Length-1){
                    tmp += "\n";
                }
                // else{
                //     tmp += chars[target];
                // }
                Array.Resize(ref lst, lst.Length+1);
                lst[lst.Length-1] = tmp;
                ans += tmp; //убираем пробелы по краям
                l = target+1;   
                //System.Console.WriteLine(ans);             
            }
            //System.Console.Write(ans);
            //_output = ans;
            _output = lst;

        }

        private string SpaceBetween(string input){
            int count = 0;
            for (int i = 0; i < input.Length; i++){
                if (input[i] == ' '){
                    count++;
                }
            }
            if (count == 0){
                return input;
            }
            
            int Spaces = 50 - input.Length;
            int deafultSpace = 1 + Spaces / count;
            int extraSpace = Spaces % count; //количество мест в которые будут добавлены "лишние пробелы" которые не делятся поровну

            string result = "";
            int added = 0;
            int Space = deafultSpace;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    if (added < extraSpace)
                    {
                        Space = deafultSpace + 1;
                    }
                    else
                    {
                        Space = deafultSpace;
                    }
                    
                    result += new string(' ', Space);//char n раз
                    added++;
                }
                else
                {
                    result += input[i];
                }
            }
            return result;
        }

        public override string ToString() { 
            string ans = "";
            for (int i = 0; i < _output.Length; i++){
                ans += _output[i].ToString();
            }
            return ans;
        }
    }
}