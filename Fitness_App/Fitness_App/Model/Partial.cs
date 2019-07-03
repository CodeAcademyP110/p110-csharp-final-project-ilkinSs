using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_App.Model
{
    public partial class Position
    {
        public override string ToString()
        {
            return Name;
        }
    }

    public partial class Employee
    {
        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }

    public partial class Time
    {
        public override string ToString()
        {
            return Name + " " + Hours;
        }
    }

    public partial class Service
    {
        public override string ToString()
        {
            return Name;
        }
    }

    public partial class Package
    {
        public override string ToString()
        {
            return Name;
        }
    }
}
