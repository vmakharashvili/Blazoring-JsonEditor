using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace Blazoring.JsonEditor
{
    //public class RequiredIfAttribute : ValidationAttribute
    //{
    //    RequiredAttribute _innerAttribute = new RequiredAttribute();
    //    public string _dependentProperty { get; set; }
    //    public Func<bool> _condition { get; set; }

    //    public RequiredIfAttribute(string dependentProperty, Func<bool> condition)
    //    {
    //        this._dependentProperty = dependentProperty;
    //        this._condition = condition;
    //    }
    //    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    //    {
    //        var field = validationContext.ObjectType.GetProperty(_dependentProperty);
    //        if (field != null)
    //        {
    //            var dependentValue = field.GetValue(validationContext.ObjectInstance, null);
    //            if ((dependentValue == null && _targetValue == null) || (dependentValue != null && dependentValue.Equals(_targetValue)))
    //            {
    //                if (!_innerAttribute.IsValid(value))
    //                {
    //                    string name = validationContext.DisplayName;
    //                    return new ValidationResult(ErrorMessage = name + " Is required.");
    //                }
    //            }
    //            return ValidationResult.Success;
    //        }
    //        else
    //        {
    //            return new ValidationResult(FormatErrorMessage(_dependentProperty));
    //        }
    //    }
    //}

    public class RequiredIfAttribute : ValidationAttribute
    {
        RequiredAttribute _innerAttribute = new RequiredAttribute();
        public string _dependentProperty { get; set; }
        public List<object> _targetValues { get; set; }


        public RequiredIfAttribute(string propertyName, params object[] dependents)
        {
            _dependentProperty = propertyName;
            _targetValues = dependents.ToList();
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var field = validationContext.ObjectType.GetProperty(_dependentProperty);
            if (field != null)
            {
                var dependentValue = field.GetValue(validationContext.ObjectInstance, null);
                if (_targetValues?.Any(x => x.Equals(dependentValue)) == true)
                {
                    _innerAttribute.ErrorMessage = "Required!";
                    return _innerAttribute.GetValidationResult(value, validationContext);
                }
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(FormatErrorMessage(_dependentProperty));
            }
        }
    }
}
