using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Calculadora
    {

        private readonly List<String> _historico; 
        private readonly int _maxLength;
        private readonly DateTime _date;

        public Calculadora(DateTime date)
        {
            _historico = new List<string>();
            _maxLength = 3;
            _date = date; 
        }

        public int Somar(int x, int y)
        {
            int res = x + y;
            validaMaxLengthListEAddString(_historico,$"{x} + {y} = {res}");
            return res;
        }
       
        public int Subtrair(int x, int y)
        {
            int res = x - y;
            validaMaxLengthListEAddString(_historico, $"{x} - {y} = {res}");
            return res;
        }
        public int Multiplicar(int x, int y)
        {
            int res = x * y;
            validaMaxLengthListEAddString(_historico, $"{x} * {y} = {res}");
            return res;
        }

        public int Dividir(int x, int y)
        {
            int res = x / y;
            validaMaxLengthListEAddString(_historico, $"{x} / {y} = {res}");
            return res;
        }

        public List<String> RetornarHistorico()
        {
            return _historico;
        }

        private void validaMaxLengthListEAddString( List<String> list,string content)
        {
            if(list.Count  > _maxLength -1 )
            {
               list.RemoveAt(0);
            }
            list.Add($"{content} - {_date.ToString("dd/MM/yyyy")}");
        }
    }
}
