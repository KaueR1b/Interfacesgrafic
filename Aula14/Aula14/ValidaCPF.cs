using System;
using System.Collections.Generic;
using System.Text;

namespace Aula14
{
    class ValidaCPF
    {
        public bool CPF (string cpf)
        {
            int [] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            cpf = cpf.Trim().Replace(".", "").Replace(".", "");

            if (cpf.Length!=11)
            {
                return false;
            }
            else
            {
                for (int i=0; i<9; i++)
                {
                    if (i.ToString().PadLeft(11, char.Parse(i.ToString())) == cpf)
                    {
                        return false;
                    }
                }
                string tempCpf = cpf.Substring(0, 9);
                int soma = 0;
                for(int j=0; j<9; j++)
                {
                    soma += int.Parse(tempCpf[j].ToString()) * multiplicador1[j]);
                }
            int resto = soma % 11;
            if (resto<2)
            }

        }
    }
}
