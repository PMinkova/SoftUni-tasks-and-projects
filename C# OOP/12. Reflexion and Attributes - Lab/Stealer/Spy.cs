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
    }
}
