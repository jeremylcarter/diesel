﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
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
                        && ((this.Ratings.Length == other.Ratings.Length) 
                        && System.Linq.Enumerable.All(System.Linq.Enumerable.Zip(this.Ratings, other.Ratings, (a, b) => Object.Equals(a,b)), areEqual => areEqual)));
        }
        
        public override bool Equals(object obj) {
            if (object.ReferenceEquals(null, obj)) {
                return false;
            }
            return (typeof(EmployeeRatings).IsAssignableFrom(obj.GetType()) && this.Equals(((EmployeeRatings)(obj))));
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
                        && ((this.Roles.Length == other.Roles.Length) 
                        && System.Linq.Enumerable.All(System.Linq.Enumerable.Zip(this.Roles, other.Roles, (a, b) => Object.Equals(a,b)), areEqual => areEqual)));
        }
        
        public override bool Equals(object obj) {
            if (object.ReferenceEquals(null, obj)) {
                return false;
            }
            return (typeof(EmployeeRoles).IsAssignableFrom(obj.GetType()) && this.Equals(((EmployeeRoles)(obj))));
        }
    }
    
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeImported")]
    [System.SerializableAttribute()]
    public sealed partial class EmployeeImported : System.IEquatable<EmployeeImported>, Test.Diesel.IDomainEvent {
        
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
    
    public partial interface IImportService {
        
        void Execute(ImportEmployee command);
        
        void Execute(ImportConsultant command);
    }
    
    [System.Runtime.Serialization.DataContractAttribute(Name="ImportEmployee")]
    [System.SerializableAttribute()]
    public partial class ImportEmployee : System.IEquatable<ImportEmployee> {
        
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
    public partial class ImportConsultant : System.IEquatable<ImportConsultant> {
        
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
}
