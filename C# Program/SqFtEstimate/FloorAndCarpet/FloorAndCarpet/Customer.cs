using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloorAndCarpet
{
    class Customer
    {
        public Customer() { }

        public Customer(string fullname, string address, string city, string state, string zipCode)
        {
            Fullname = fullname;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public Customer(string fullname, string address, string addressLine2,
            string city, string state, string zipCode)
        {
            Fullname = fullname;
            Address = address;
            AddressLine2 = addressLine2;
            City = city;
            State = state;
            ZipCode = zipCode;
        }


        public string Fullname { get; set; }
        public string Address { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public override string ToString()
        {
            return Fullname + " " + Address + " " + AddressLine2 + " " + 
                City + " " + State + " " + ZipCode;
        }
        public string ToStringFormatted()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Fullname + Environment.NewLine);
            sb.Append(Address + Environment.NewLine);
            sb.Append(AddressLine2 + Environment.NewLine);
            sb.Append(City + " " + State + " " + ZipCode);
            return sb.ToString();
        }
    }
}
