using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraProj.Services
{
    public class Calculadora
    {
        private List<string> _historico;
        private string _data;
        public Calculadora(string data)
        {
            _historico = new List<string>();
            _data = data;
        }

        public int? Somar(int num1, int num2)
        {
            int resultado = num1 + num2;

            _historico.Insert(0, $"{num1} + {num2} = {resultado} : {_data}");

            return resultado;
        }
        public int? Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;

            _historico.Insert(0, $"{num1} - {num2} = {resultado} : {_data}");

            return resultado;
        }
        public int? Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;

            _historico.Insert(0, $"{num1} x {num2} = {resultado} : {_data}");
            
            return resultado;
        }
        public int? Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;

            _historico.Insert(0, $"{num1} / {num2} = {resultado} : {_data}");
            
            return resultado;
        }
        public List<string> RetornarHistorico()
        {
            _historico.RemoveRange(3, _historico.Count - 3); //Só deixa os 3 primeiros itens
            return _historico;
        }
    }
}