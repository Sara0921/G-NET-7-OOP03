namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            #region Question01
            //a)Association>>Composition
            //b)Association
            //c)Inheritance
            //d)Association>>Aggregation
            //e)Dependency
            #endregion
            #region Question02
            //a)Yes. protected means accessible within the class itself and in any derived class
            //>>No. Even within the child class, you can't access a protected member through an arbitrary instance of the parent type as it will behave like private access modifier.

            //b)With inheritance
            //protected internal >>Accessible from any subclass  + any code in the same assembly
            //private protected >>Accessible only from subclasses that are also in the same assembly
            //Without inheritance
            //protected internal >>Members are accesible in same assembly
            //private protected >>Members with the same class

            //c)Class>>A sealed class is a class that cannot be inherited. It stops the inheritance chain completely.
            //Method>>A method can be sealed inside a derived class to prevent further overriding down the chain.

            //d) Yes! Sealed prevents inheritance, not instantiation. You can still create objects.
            #endregion
            #endregion
        }
    }
}
