namespace P01_GenericBoxOfString
{
    public class Box<T>
    {
        public Box(T input)
        {
            this.Value = input;
        }

        public T Value { get; set; }

        public override string ToString()
        {
            return $"System.String: {this.Value}";
        }
    }
}
