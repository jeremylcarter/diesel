﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Generated
{
    using System;


    public partial class ImportEmployeeCommand : System.IEquatable<ImportEmployeeCommand>
    {

        private int _employeeNumber;

        private string _firstName;

        private string _lastName;

        public ImportEmployeeCommand(int employeeNumber, string firstName, string lastName)
        {
            this._employeeNumber = employeeNumber;
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public int EmployeeNumber
        {
            get
            {
                return this._employeeNumber;
            }
        }

        public string FirstName
        {
            get
            {
                return this._firstName;
            }
        }

        public string LastName
        {
            get
            {
                return this._lastName;
            }
        }

        public static bool operator ==(ImportEmployeeCommand left, ImportEmployeeCommand right)
        {
            if (object.ReferenceEquals(null, left))
            {
                return object.ReferenceEquals(null, right);
            }
            return left.Equals(right);
        }

        public static bool operator !=(ImportEmployeeCommand left, ImportEmployeeCommand right)
        {
            if (object.ReferenceEquals(null, left))
            {
                return (false == object.ReferenceEquals(null, right));
            }
            return (false == left.Equals(right));
        }

        public bool Equals(ImportEmployeeCommand other)
        {
            return ((((false == object.ReferenceEquals(null, other))
                        && (this.EmployeeNumber == other.EmployeeNumber))
                        && (this.FirstName == other.FirstName))
                        && (this.LastName == other.LastName));
        }

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(null, obj))
            {
                return false;
            }
            return (typeof(ImportEmployeeCommand).IsAssignableFrom(obj.GetType()) && this.Equals(((ImportEmployeeCommand)(obj))));
        }

        public override int GetHashCode()
        {
            return (0 + this.EmployeeNumber.GetHashCode());
        }
    }
}


