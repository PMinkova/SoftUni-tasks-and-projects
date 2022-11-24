namespace ValidationAttributes.Utilities
{
    using System.Linq;
    using System.Reflection;

    using Attributes;

    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            var properties = obj
                .GetType()
                .GetProperties()
                .Where(x => x.GetCustomAttributes(typeof(MyValidationAttribute)).Any())
                .ToArray();

            foreach (var property in properties)
            {
                var value = property.GetValue(obj);
                var attribute = property.GetCustomAttribute<MyValidationAttribute>();

                var isValid = attribute.IsValid(value);

                if (!isValid)
                {
                    return false;
                }
            }

            return true;
        }
    }
}