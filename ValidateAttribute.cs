using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonUtils.SpecificValidations;

namespace CommonUtils
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = true)]
    public sealed class ValidateAttribute : Attribute
    {
        public Type ValidatorType { get; private set; }
        public IValidator Validator { get; private set; }

        public ValidateAttribute(Type t)
        {
            if (t.BaseType == typeof(IValidator) || t.GetInterface("IValidator") is Type)
                Validator = (IValidator)t.GetConstructor(Type.EmptyTypes).Invoke(null);
            else
                throw new Exception(String.Format("The type {0} doesn't implements IValidator", t.FullName));
        }
    }
}
