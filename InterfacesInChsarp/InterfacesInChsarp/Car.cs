using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesInChsarp
{
    public class Car : IEquatable<Car>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        // Implementation of IEquatable<T> interface
        public bool Equals(Car car)
        {
            return (this.Make, this.Model, this.Year) == (car.Make, car.Model, car.Year);
        }

        public override string ToString()
        {
            return "My car from overrided ToString() method!";
        }
    }
}
