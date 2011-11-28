using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CommonUtils.SpecificValidations
{
    /// <summary>
    /// Validação de email
    /// </summary>
    public class EmailString : IValidator
    {
        static Regex re = new Regex(@"^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$", RegexOptions.IgnoreCase);

        public List<String> Errors { get; set; }

        public bool IsValid(object t)
        {
            Errors = new List<string>();
            if (!(t is string))
                Errors.Add(String.Format("'null' não é um e-mail válido."));
            else if (!re.IsMatch(t.ToString()))
                Errors.Add(String.Format("{0} não é um e-mail válido.", t));

            return Errors.Count == 0;
        }

        public bool IsValid(object t, out string[] errors)
        {
            IsValid(t);
            errors = Errors.ToArray();
            return Errors.Count == 0;
        }
    }
}
