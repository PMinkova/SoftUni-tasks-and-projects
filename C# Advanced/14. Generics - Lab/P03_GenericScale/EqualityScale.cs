namespace GenericScale
{
    public class EqualityScale<T>
    {
        private T right;
        private T left;
        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public bool AreEqual()
        {
            return this.left.Equals(this.right);
        }
    }
}
