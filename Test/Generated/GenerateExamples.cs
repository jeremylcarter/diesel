﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.Diesel.Generated {
    using System;
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerDisplayAttribute("{Value}")]
    public partial struct EmployeeNumber : System.IEquatable<EmployeeNumber> {
        
        private int _value;
        
        public EmployeeNumber(int value) {
            this._value = value;
        }
        
        public int Value {
            get {
                return this._value;
            }
        }
        
        public static bool operator ==(EmployeeNumber left, EmployeeNumber right) {
            return left.Equals(right);
        }
        
        public static bool operator !=(EmployeeNumber left, EmployeeNumber right) {
            return (false == left.Equals(right));
        }
        
        public override int GetHashCode() {
            return (0 + this.Value.GetHashCode());
        }
        
        public bool Equals(EmployeeNumber other) {
            return (true 
                        && (this.Value == other.Value));
        }
        
        public override bool Equals(object obj) {
            if (object.ReferenceEquals(null, obj)) {
                return false;
            }
            return (typeof(EmployeeNumber).IsAssignableFrom(obj.GetType()) && this.Equals(((EmployeeNumber)(obj))));
        }
        
        public override string ToString() {
            return string.Format("{0}", this.Value);
        }
    }
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerDisplayAttribute("{Value}")]
    public partial struct EmailAddress : System.IEquatable<EmailAddress> {
        
        private string _value;
        
        public EmailAddress(string value) {
            this._value = value;
        }
        
        public string Value {
            get {
                return this._value;
            }
        }
        
        public static bool operator ==(EmailAddress left, EmailAddress right) {
            return left.Equals(right);
        }
        
        public static bool operator !=(EmailAddress left, EmailAddress right) {
            return (false == left.Equals(right));
        }
        
        public override int GetHashCode() {
            return 0;
        }
        
        public bool Equals(EmailAddress other) {
            return (true 
                        && (this.Value == other.Value));
        }
        
        public override bool Equals(object obj) {
            if (object.ReferenceEquals(null, obj)) {
                return false;
            }
            return (typeof(EmailAddress).IsAssignableFrom(obj.GetType()) && this.Equals(((EmailAddress)(obj))));
        }
        
        public override string ToString() {
            return string.Format("{0}", this.Value);
        }
    }
    
    [System.SerializableAttribute()]
    public partial struct EmployeeName : System.IEquatable<EmployeeName> {
        
        private string _firstName;
        
        private string _lastName;
        
        public EmployeeName(string firstName, string lastName) {
            this._firstName = firstName;
            this._lastName = lastName;
        }
        
        public string FirstName {
            get {
                return this._firstName;
            }
        }
        
        public string LastName {
            get {
                return this._lastName;
            }
        }
        
        public static bool operator ==(EmployeeName left, EmployeeName right) {
            return left.Equals(right);
        }
        
        public static bool operator !=(EmployeeName left, EmployeeName right) {
            return (false == left.Equals(right));
        }
        
        public override int GetHashCode() {
            return 0;
        }
        
        public bool Equals(EmployeeName other) {
            return ((true 
                        && (this.FirstName == other.FirstName)) 
                        && (this.LastName == other.LastName));
        }
        
        public override bool Equals(object obj) {
            if (object.ReferenceEquals(null, obj)) {
                return false;
            }
            return (typeof(EmployeeName).IsAssignableFrom(obj.GetType()) && this.Equals(((EmployeeName)(obj))));
        }
        
        public override string ToString() {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
    
    [System.SerializableAttribute()]
    public partial struct EmployeeMetadata : System.IEquatable<EmployeeMetadata> {
        
        private string _source;
        
        private System.Nullable<int> _sourceId;
        
        public EmployeeMetadata(string source, System.Nullable<int> sourceId) {
            this._source = source;
            this._sourceId = sourceId;
        }
        
        public string Source {
            get {
                return this._source;
            }
        }
        
        public System.Nullable<int> SourceId {
            get {
                return this._sourceId;
            }
        }
        
        public static bool operator ==(EmployeeMetadata left, EmployeeMetadata right) {
            return left.Equals(right);
        }
        
        public static bool operator !=(EmployeeMetadata left, EmployeeMetadata right) {
            return (false == left.Equals(right));
        }
        
        public override int GetHashCode() {
            return (0 + this.SourceId.GetHashCode());
        }
        
        public bool Equals(EmployeeMetadata other) {
            return ((true 
                        && (this.Source == other.Source)) 
                        && (this.SourceId == other.SourceId));
        }
        
        public override bool Equals(object obj) {
            if (object.ReferenceEquals(null, obj)) {
                return false;
            }
            return (typeof(EmployeeMetadata).IsAssignableFrom(obj.GetType()) && this.Equals(((EmployeeMetadata)(obj))));
        }
        
        public override string ToString() {
            return string.Format("{0} {1}", this.Source, this.SourceId);
        }
    }
    
    [System.SerializableAttribute()]
    public partial struct EmployeeRatings : System.IEquatable<EmployeeRatings> {
        
        private int _employeeNumber;
        
        private int[] _ratings;
        
        public EmployeeRatings(int employeeNumber, int[] ratings) {
            this._employeeNumber = employeeNumber;
            this._ratings = ratings;
        }
        
        public int EmployeeNumber {
            get {
                return this._employeeNumber;
            }
        }
        
        public int[] Ratings {
            get {
                return this._ratings;
            }
        }
        
        public static bool operator ==(EmployeeRatings left, EmployeeRatings right) {
            return left.Equals(right);
        }
        
        public static bool operator !=(EmployeeRatings left, EmployeeRatings right) {
            return (false == left.Equals(right));
        }
        
        public override int GetHashCode() {
            return (0 + this.EmployeeNumber.GetHashCode());
        }
        
        public bool Equals(EmployeeRatings other) {
            return ((true 
                        && (this.EmployeeNumber == other.EmployeeNumber)) 
                        && ((object.ReferenceEquals(null, this.Ratings) && object.ReferenceEquals(null, other.Ratings)) 
                        || (((false == object.ReferenceEquals(null, this.Ratings)) 
                        && (false == object.ReferenceEquals(null, other.Ratings))) 
                        && ((this.Ratings.Length == other.Ratings.Length) 
                        && System.Linq.Enumerable.All(System.Linq.Enumerable.Zip(this.Ratings, other.Ratings, (a, b) => Object.Equals(a,b)), areEqual => areEqual)))));
        }
        
        public override bool Equals(object obj) {
            if (object.ReferenceEquals(null, obj)) {
                return false;
            }
            return (typeof(EmployeeRatings).IsAssignableFrom(obj.GetType()) && this.Equals(((EmployeeRatings)(obj))));
        }
        
        public override string ToString() {
            return string.Format("{0} {1}", this.EmployeeNumber, this.Ratings);
        }
    }
    
    [System.SerializableAttribute()]
    public partial struct EmployeeRoles : System.IEquatable<EmployeeRoles> {
        
        private int _employeeNumber;
        
        private string[] _roles;
        
        public EmployeeRoles(int employeeNumber, string[] roles) {
            this._employeeNumber = employeeNumber;
            this._roles = roles;
        }
        
        public int EmployeeNumber {
            get {
                return this._employeeNumber;
            }
        }
        
        public string[] Roles {
            get {
                return this._roles;
            }
        }
        
        public static bool operator ==(EmployeeRoles left, EmployeeRoles right) {
            return left.Equals(right);
        }
        
        public static bool operator !=(EmployeeRoles left, EmployeeRoles right) {
            return (false == left.Equals(right));
        }
        
        public override int GetHashCode() {
            return (0 + this.EmployeeNumber.GetHashCode());
        }
        
        public bool Equals(EmployeeRoles other) {
            return ((true 
                        && (this.EmployeeNumber == other.EmployeeNumber)) 
                        && ((object.ReferenceEquals(null, this.Roles) && object.ReferenceEquals(null, other.Roles)) 
                        || (((false == object.ReferenceEquals(null, this.Roles)) 
                        && (false == object.ReferenceEquals(null, other.Roles))) 
                        && ((this.Roles.Length == other.Roles.Length) 
                        && System.Linq.Enumerable.All(System.Linq.Enumerable.Zip(this.Roles, other.Roles, (a, b) => Object.Equals(a,b)), areEqual => areEqual)))));
        }
        
        public override bool Equals(object obj) {
            if (object.ReferenceEquals(null, obj)) {
                return false;
            }
            return (typeof(EmployeeRoles).IsAssignableFrom(obj.GetType()) && this.Equals(((EmployeeRoles)(obj))));
        }
        
        public override string ToString() {
            return string.Format("{0} {1}", this.EmployeeNumber, this.Roles);
        }
    }
    
    [System.SerializableAttribute()]
    public partial struct EmployeeInfo : System.IEquatable<EmployeeInfo> {
        
        private EmployeeNumber _number;
        
        private EmployeeName _name;
        
        private EmailAddress _email;
        
        public EmployeeInfo(EmployeeNumber number, EmployeeName name, EmailAddress email) {
            this._number = number;
            this._name = name;
            this._email = email;
        }
        
        public EmployeeNumber Number {
            get {
                return this._number;
            }
        }
        
        public EmployeeName Name {
            get {
                return this._name;
            }
        }
        
        public EmailAddress Email {
            get {
                return this._email;
            }
        }
        
        public static bool operator ==(EmployeeInfo left, EmployeeInfo right) {
            return left.Equals(right);
        }
        
        public static bool operator !=(EmployeeInfo left, EmployeeInfo right) {
            return (false == left.Equals(right));
        }
        
        public override int GetHashCode() {
            return (((0 + this.Number.GetHashCode()) 
                        + this.Name.GetHashCode()) 
                        + this.Email.GetHashCode());
        }
        
        public bool Equals(EmployeeInfo other) {
            return (((true && object.Equals(this.Number, other.Number)) 
                        && object.Equals(this.Name, other.Name)) 
                        && object.Equals(this.Email, other.Email));
        }
        
        public override bool Equals(object obj) {
            if (object.ReferenceEquals(null, obj)) {
                return false;
            }
            return (typeof(EmployeeInfo).IsAssignableFrom(obj.GetType()) && this.Equals(((EmployeeInfo)(obj))));
        }
        
        public override string ToString() {
            return string.Format("{0} {1} {2}", this.Number, this.Name, this.Email);
        }
    }
    
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeImported")]
    [System.SerializableAttribute()]
    public sealed partial class EmployeeImported : Test.Diesel.IDomainEvent, System.IEquatable<EmployeeImported> {
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="Id", Order=1)]
        private System.Guid _id;
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="EmployeeNumber", Order=2)]
        private int _employeeNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="FirstName", Order=3)]
        private string _firstName;
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="LastName", Order=4)]
        private string _lastName;
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="SourceId", Order=5)]
        private System.Nullable<int> _sourceId;
        
        public EmployeeImported(System.Guid id, int employeeNumber, string firstName, string lastName, System.Nullable<int> sourceId) {
            this._id = id;
            this._employeeNumber = employeeNumber;
            this._firstName = firstName;
            this._lastName = lastName;
            this._sourceId = sourceId;
        }
        
        public System.Guid Id {
            get {
                return this._id;
            }
        }
        
        public int EmployeeNumber {
            get {
                return this._employeeNumber;
            }
        }
        
        public string FirstName {
            get {
                return this._firstName;
            }
        }
        
        public string LastName {
            get {
                return this._lastName;
            }
        }
        
        public System.Nullable<int> SourceId {
            get {
                return this._sourceId;
            }
        }
        
        public static bool operator ==(EmployeeImported left, EmployeeImported right) {
            if (object.ReferenceEquals(null, left)) {
                return object.ReferenceEquals(null, right);
            }
            return left.Equals(right);
        }
        
        public static bool operator !=(EmployeeImported left, EmployeeImported right) {
            if (object.ReferenceEquals(null, left)) {
                return (false == object.ReferenceEquals(null, right));
            }
            return (false == left.Equals(right));
        }
        
        public override int GetHashCode() {
            return (((0 + this.Id.GetHashCode()) 
                        + this.EmployeeNumber.GetHashCode()) 
                        + this.SourceId.GetHashCode());
        }
        
        public bool Equals(EmployeeImported other) {
            return ((((((false == object.ReferenceEquals(null, other)) 
                        && object.Equals(this.Id, other.Id)) 
                        && (this.EmployeeNumber == other.EmployeeNumber)) 
                        && (this.FirstName == other.FirstName)) 
                        && (this.LastName == other.LastName)) 
                        && (this.SourceId == other.SourceId));
        }
        
        public override bool Equals(object obj) {
            if (object.ReferenceEquals(null, obj)) {
                return false;
            }
            return (typeof(EmployeeImported).IsAssignableFrom(obj.GetType()) && this.Equals(((EmployeeImported)(obj))));
        }
    }
    
    [System.Runtime.Serialization.DataContractAttribute(Name="Name")]
    [System.SerializableAttribute()]
    public sealed partial class Name : System.IEquatable<Name> {
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="First", Order=1)]
        private string _first;
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="Last", Order=2)]
        private string _last;
        
        public Name(string first, string last) {
            this._first = first;
            this._last = last;
        }
        
        public string First {
            get {
                return this._first;
            }
        }
        
        public string Last {
            get {
                return this._last;
            }
        }
        
        public static bool operator ==(Name left, Name right) {
            if (object.ReferenceEquals(null, left)) {
                return object.ReferenceEquals(null, right);
            }
            return left.Equals(right);
        }
        
        public static bool operator !=(Name left, Name right) {
            if (object.ReferenceEquals(null, left)) {
                return (false == object.ReferenceEquals(null, right));
            }
            return (false == left.Equals(right));
        }
        
        public override int GetHashCode() {
            return 0;
        }
        
        public bool Equals(Name other) {
            return (((false == object.ReferenceEquals(null, other)) 
                        && (this.First == other.First)) 
                        && (this.Last == other.Last));
        }
        
        public override bool Equals(object obj) {
            if (object.ReferenceEquals(null, obj)) {
                return false;
            }
            return (typeof(Name).IsAssignableFrom(obj.GetType()) && this.Equals(((Name)(obj))));
        }
    }
    
    [System.Runtime.Serialization.DataContractAttribute(Name="Gender")]
    public enum Gender {
        
        [System.Runtime.Serialization.EnumMemberAttribute(Value="Female")]
        Female,
        
        [System.Runtime.Serialization.EnumMemberAttribute(Value="Male")]
        Male,
    }
    
    public partial interface IImportService {
        
        void Execute(ImportEmployee command);
        
        void Execute(ImportConsultant command);
    }
    
    [System.Runtime.Serialization.DataContractAttribute(Name="ImportEmployee")]
    [System.SerializableAttribute()]
    public partial class ImportEmployee : Test.Diesel.ICommand, System.IEquatable<ImportEmployee> {
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="CommandId", Order=1)]
        private System.Guid _commandId;
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="EmployeeNumber", Order=2)]
        private int _employeeNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="FirstName", Order=3)]
        private string _firstName;
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="LastName", Order=4)]
        private string _lastName;
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="SourceId", Order=5)]
        private System.Nullable<int> _sourceId;
        
        public ImportEmployee(System.Guid commandId, int employeeNumber, string firstName, string lastName, System.Nullable<int> sourceId) {
            this._commandId = commandId;
            this._employeeNumber = employeeNumber;
            this._firstName = firstName;
            this._lastName = lastName;
            this._sourceId = sourceId;
        }
        
        public System.Guid CommandId {
            get {
                return this._commandId;
            }
        }
        
        public int EmployeeNumber {
            get {
                return this._employeeNumber;
            }
        }
        
        public string FirstName {
            get {
                return this._firstName;
            }
        }
        
        public string LastName {
            get {
                return this._lastName;
            }
        }
        
        public System.Nullable<int> SourceId {
            get {
                return this._sourceId;
            }
        }
        
        public static bool operator ==(ImportEmployee left, ImportEmployee right) {
            if (object.ReferenceEquals(null, left)) {
                return object.ReferenceEquals(null, right);
            }
            return left.Equals(right);
        }
        
        public static bool operator !=(ImportEmployee left, ImportEmployee right) {
            if (object.ReferenceEquals(null, left)) {
                return (false == object.ReferenceEquals(null, right));
            }
            return (false == left.Equals(right));
        }
        
        public override int GetHashCode() {
            return (((0 + this.CommandId.GetHashCode()) 
                        + this.EmployeeNumber.GetHashCode()) 
                        + this.SourceId.GetHashCode());
        }
        
        public bool Equals(ImportEmployee other) {
            return ((((((false == object.ReferenceEquals(null, other)) 
                        && object.Equals(this.CommandId, other.CommandId)) 
                        && (this.EmployeeNumber == other.EmployeeNumber)) 
                        && (this.FirstName == other.FirstName)) 
                        && (this.LastName == other.LastName)) 
                        && (this.SourceId == other.SourceId));
        }
        
        public override bool Equals(object obj) {
            if (object.ReferenceEquals(null, obj)) {
                return false;
            }
            return (typeof(ImportEmployee).IsAssignableFrom(obj.GetType()) && this.Equals(((ImportEmployee)(obj))));
        }
    }
    
    [System.Runtime.Serialization.DataContractAttribute(Name="ImportConsultant")]
    [System.SerializableAttribute()]
    public partial class ImportConsultant : Test.Diesel.ICommand, System.IEquatable<ImportConsultant> {
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="FirstName", Order=1)]
        private string _firstName;
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="LastName", Order=2)]
        private string _lastName;
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="Company", Order=3)]
        private string _company;
        
        public ImportConsultant(string firstName, string lastName, string company) {
            this._firstName = firstName;
            this._lastName = lastName;
            this._company = company;
        }
        
        public string FirstName {
            get {
                return this._firstName;
            }
        }
        
        public string LastName {
            get {
                return this._lastName;
            }
        }
        
        public string Company {
            get {
                return this._company;
            }
        }
        
        public static bool operator ==(ImportConsultant left, ImportConsultant right) {
            if (object.ReferenceEquals(null, left)) {
                return object.ReferenceEquals(null, right);
            }
            return left.Equals(right);
        }
        
        public static bool operator !=(ImportConsultant left, ImportConsultant right) {
            if (object.ReferenceEquals(null, left)) {
                return (false == object.ReferenceEquals(null, right));
            }
            return (false == left.Equals(right));
        }
        
        public override int GetHashCode() {
            return 0;
        }
        
        public bool Equals(ImportConsultant other) {
            return ((((false == object.ReferenceEquals(null, other)) 
                        && (this.FirstName == other.FirstName)) 
                        && (this.LastName == other.LastName)) 
                        && (this.Company == other.Company));
        }
        
        public override bool Equals(object obj) {
            if (object.ReferenceEquals(null, obj)) {
                return false;
            }
            return (typeof(ImportConsultant).IsAssignableFrom(obj.GetType()) && this.Equals(((ImportConsultant)(obj))));
        }
    }
    
    [System.Runtime.Serialization.DataContractAttribute(Name="ImportEmployeeNestedTypes")]
    [System.SerializableAttribute()]
    public partial class ImportEmployeeNestedTypes : Test.Diesel.ICommand, System.IEquatable<ImportEmployeeNestedTypes> {
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="CommandId", Order=1)]
        private System.Guid _commandId;
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="EmployeeNumber", Order=2)]
        private int _employeeNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="Name", Order=3)]
        private Name _name;
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="Gender", Order=4)]
        private Gender _gender;
        
        public ImportEmployeeNestedTypes(System.Guid commandId, int employeeNumber, Name name, Gender gender) {
            this._commandId = commandId;
            this._employeeNumber = employeeNumber;
            this._name = name;
            this._gender = gender;
        }
        
        public System.Guid CommandId {
            get {
                return this._commandId;
            }
        }
        
        public int EmployeeNumber {
            get {
                return this._employeeNumber;
            }
        }
        
        public Name Name {
            get {
                return this._name;
            }
        }
        
        public Gender Gender {
            get {
                return this._gender;
            }
        }
        
        public static bool operator ==(ImportEmployeeNestedTypes left, ImportEmployeeNestedTypes right) {
            if (object.ReferenceEquals(null, left)) {
                return object.ReferenceEquals(null, right);
            }
            return left.Equals(right);
        }
        
        public static bool operator !=(ImportEmployeeNestedTypes left, ImportEmployeeNestedTypes right) {
            if (object.ReferenceEquals(null, left)) {
                return (false == object.ReferenceEquals(null, right));
            }
            return (false == left.Equals(right));
        }
        
        public override int GetHashCode() {
            return (((0 + this.CommandId.GetHashCode()) 
                        + this.EmployeeNumber.GetHashCode()) 
                        + this.Gender.GetHashCode());
        }
        
        public bool Equals(ImportEmployeeNestedTypes other) {
            return (((((false == object.ReferenceEquals(null, other)) 
                        && object.Equals(this.CommandId, other.CommandId)) 
                        && (this.EmployeeNumber == other.EmployeeNumber)) 
                        && object.Equals(this.Name, other.Name)) 
                        && object.Equals(this.Gender, other.Gender));
        }
        
        public override bool Equals(object obj) {
            if (object.ReferenceEquals(null, obj)) {
                return false;
            }
            return (typeof(ImportEmployeeNestedTypes).IsAssignableFrom(obj.GetType()) && this.Equals(((ImportEmployeeNestedTypes)(obj))));
        }
    }
    
    [System.Runtime.Serialization.DataContractAttribute(Name="Foo")]
    [System.SerializableAttribute()]
    public partial class Foo : Test.Diesel.ICommand, System.IEquatable<Foo> {
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="When", Order=1)]
        private System.Nullable<System.DateTime> _when;
        
        public Foo(System.Nullable<System.DateTime> when) {
            this._when = when;
        }
        
        public System.Nullable<System.DateTime> When {
            get {
                return this._when;
            }
        }
        
        public static bool operator ==(Foo left, Foo right) {
            if (object.ReferenceEquals(null, left)) {
                return object.ReferenceEquals(null, right);
            }
            return left.Equals(right);
        }
        
        public static bool operator !=(Foo left, Foo right) {
            if (object.ReferenceEquals(null, left)) {
                return (false == object.ReferenceEquals(null, right));
            }
            return (false == left.Equals(right));
        }
        
        public override int GetHashCode() {
            return (0 + this.When.GetHashCode());
        }
        
        public bool Equals(Foo other) {
            return ((false == object.ReferenceEquals(null, other)) 
                        && (this.When == other.When));
        }
        
        public override bool Equals(object obj) {
            if (object.ReferenceEquals(null, obj)) {
                return false;
            }
            return (typeof(Foo).IsAssignableFrom(obj.GetType()) && this.Equals(((Foo)(obj))));
        }
    }
    
    [System.Runtime.Serialization.DataContractAttribute(Name="DepartmentImported")]
    [System.SerializableAttribute()]
    public sealed partial class DepartmentImported : Test.Diesel.IDomainEvent, System.IEquatable<DepartmentImported> {
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="Id", Order=1)]
        private System.Guid _id;
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="Employees", Order=2)]
        private Name[] _employees;
        
        public DepartmentImported(System.Guid id, Name[] employees) {
            this._id = id;
            this._employees = employees;
        }
        
        public System.Guid Id {
            get {
                return this._id;
            }
        }
        
        public Name[] Employees {
            get {
                return this._employees;
            }
        }
        
        public static bool operator ==(DepartmentImported left, DepartmentImported right) {
            if (object.ReferenceEquals(null, left)) {
                return object.ReferenceEquals(null, right);
            }
            return left.Equals(right);
        }
        
        public static bool operator !=(DepartmentImported left, DepartmentImported right) {
            if (object.ReferenceEquals(null, left)) {
                return (false == object.ReferenceEquals(null, right));
            }
            return (false == left.Equals(right));
        }
        
        public override int GetHashCode() {
            return (0 + this.Id.GetHashCode());
        }
        
        public bool Equals(DepartmentImported other) {
            return (((false == object.ReferenceEquals(null, other)) 
                        && object.Equals(this.Id, other.Id)) 
                        && ((object.ReferenceEquals(null, this.Employees) && object.ReferenceEquals(null, other.Employees)) 
                        || (((false == object.ReferenceEquals(null, this.Employees)) 
                        && (false == object.ReferenceEquals(null, other.Employees))) 
                        && ((this.Employees.Length == other.Employees.Length) 
                        && System.Linq.Enumerable.All(System.Linq.Enumerable.Zip(this.Employees, other.Employees, (a, b) => Object.Equals(a,b)), areEqual => areEqual)))));
        }
        
        public override bool Equals(object obj) {
            if (object.ReferenceEquals(null, obj)) {
                return false;
            }
            return (typeof(DepartmentImported).IsAssignableFrom(obj.GetType()) && this.Equals(((DepartmentImported)(obj))));
        }
    }
}
