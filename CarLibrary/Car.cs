using System.Diagnostics;

namespace CarLibrary
{
    abstract class Car
    {
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract
        // The Car class should have all the common properties: make, model, color, age, and price.
        // Temporary

        /*
         * Use the abstract modifier in a method or property declaration to 
         * indicate that the method or property does not contain implementation.
         * Abstract methods have the following features:
         * An abstract method is implicitly a virtual method.
         * Abstract method declarations are only permitted in abstract classes.
         * 
         * Because an abstract method declaration provides no actual implementation, there is no method body.
         * Abstract properties behave like abstract methods, except for the differences 
         * in declaration and invocation syntax.
         * It is an error to use the abstract modifier on a static property. 
         * An abstract inherited property can be overridden in a derived class by 
         * including a property declaration that uses the override modifier.
         */

        protected abstract int id { get; set; }
        protected abstract int userId { get; set; }
        protected abstract string make { get; set; }
        protected abstract string model {get; set;}
        protected abstract string color {get; set; }
        protected abstract float age { get; set;}
        protected abstract decimal price { get; set;}
        protected abstract float miles { get; set; }

        /*
         * In addition, the subclasses should have one or more other-features as properties.
         * For example: Engine for BMW, Mileage for Toyota, etc. to highlight that
         * company's best feature(s)
         * 
         * Use the features and filter them
         * 
         * Have unique properties in subclasses
         * Have a huge collection of cars, handle to string
         * base.ToString(+ inserted string)
         * 
         */

        protected abstract string[] features { get; set;}
    }
}