using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonUtils.SpecificValidations
{
    /// <summary>
    /// Validação de CPF
    /// </summary>
    public class CpfString : IValidator
    {
        public List<String> Errors { get; set; }

        /// <summary>
        /// Valida o cpf
        /// </summary>
        /// <param name="cpf">CPF. Ex: 12345678912</param>
        /// <returns>true / false</returns>
        public bool IsValid(object obj)
        {
            string cpf = obj.ToString();

            Errors = new List<string>();

            if (!(cpf is string))
                Errors.Add("CPF_E_NULO");
            else if (cpf.Length < 11)
                Errors.Add("CPF_COMPRIMENTO_INCORRETO");
            else if (cpf.Any(c => !Char.IsDigit(c)))
                Errors.Add("CPF_COM_LETRAS");
            else
            {
                string digitos = cpf.Substring(9);

                string numeros = cpf.Substring(0, 9);
                if (VerificarDigitoValido(digitos[0], numeros))
                {
                    numeros = cpf.Substring(0, 10);
                    if (!VerificarDigitoValido(digitos[1], numeros))
                        Errors.Add("CPF_INVALIDO");
                }
                else
                    Errors.Add("CPF_INVALIDO");
            }

            return Errors.Count == 0;
        }

        /// <summary>
        /// Valida o cpf
        /// </summary>
        /// <param name="cpf">CPF</param>
        /// <param name="errors">Erros gerados na validação</param>
        /// <returns>true / false</returns>
        public bool IsValid(object cpf, out string[] errors)
        {
            bool r = IsValid(cpf);
            errors = Errors.ToArray();
            return r;
        }

        /// <summary>
        /// Verifica se o dígito é válido.
        /// </summary>
        /// <param name="d">O digito esperado</param>
        /// <param name="numeros">Os demais números do cpf</param>
        /// <returns>true: válido / false: inválido</returns>
        private bool VerificarDigitoValido(char d, string numeros)
        {
            int soma = 0;
            int resultante = 0;
            int maiorMultiplicador = numeros.Length + 1;

            for (int i = maiorMultiplicador; i >= 2; i--)
                soma += i * numeros[maiorMultiplicador - i].ToString().AsInt(-1);

            resultante = soma % 11 < 2 ? 0 : 11 - soma % 11;
            return d.Equals(resultante.ToString()[0]);
        }
    }
}
