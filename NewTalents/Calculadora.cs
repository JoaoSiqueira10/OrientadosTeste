using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> ListaHistorico;
        private string Data;

        public Calculadora(string Data)
        {
            ListaHistorico = new List<string>();
            this.Data = Data;
        }

        public int Somar(int Num1, int Num2)
        {
            int res = Num1 + Num2;
            ListaHistorico.Insert(0,"Res: " + res + " - data: " + Data);
            return res;
        }
        public int Subtrair(int Num1, int Num2)
        {
            int res = Num1 - Num2;
            ListaHistorico.Insert(0, "Res: " + res + " - data: " + Data);
            return res;
        }
        public int Multiplicar(int Num1, int Num2)
        {
            int res = Num1 * Num2;
            ListaHistorico.Insert(0, "Res: " + res + " - data: " + Data);
            return res;
        }
        public int Dividir(int Num1, int Num2)
        {
            int res = Num1 / Num2;
            ListaHistorico.Insert(0, "Res: " + res + " - data: " + Data);
            return res;
        }

        public List<string> Historico()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            return ListaHistorico;
        }
    }
}
