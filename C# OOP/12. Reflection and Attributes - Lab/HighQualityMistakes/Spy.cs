namespace Stealer
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class Spy
    {
        public string StealFieldInfo(string investigatedClass, params string[] fieldsToInvestigate)
        {
            var classType = Type.GetType(investigatedClass);
            var fields = classType.GetFields((BindingFlags)60);

            var classInstance = Activator.CreateInstance(classType);

            var sb = new StringBuilder();

            sb.AppendLine($"Class under investigation: {this.GetType().Name}");

            foreach (var field in fields)
            {
                if (fieldsToInvestigate.Contains(field.Name))
                {
                    sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public string AnalyzeAccessModifiers(string className)
        {
            var classType = Type.GetType(className);

            var classFields = classType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            var publicMethods = classType.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            var nonPublicMethods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            var sb = new StringBuilder();

            foreach (var field in classFields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }

            foreach (var method in nonPublicMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }

            foreach (var method in publicMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
