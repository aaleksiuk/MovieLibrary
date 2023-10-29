using MovieLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary;

public class Actor : Person, IEquatable<Actor>
{
    public bool Equals(Actor? other)
    {
        return other != null && FirstName.Equals(other.FirstName) &&
                    LastName.Equals(other.LastName);
    }
}