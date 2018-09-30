using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS
{
    class Customer
    {
        private string nic, name, address, contact, email, occupation;
        private int cid;
        private DateTime dob;
        private byte[] photo, signature;


        public Customer(int CID, string NIC, string Name, string Address, string Contact, string Email, string Occupation, DateTime DOB, byte[] Photo, byte[] Signature)
        {
            cid = CID;
            nic = NIC;
            name = Name;
            address = Address;
            contact = Contact;
            email = Email;
            occupation = Occupation;
            dob = DOB;
            photo = Photo;
            signature = Signature;
        }

        public Customer(string NIC, string Name, string Address, string Contact, string Email, string Occupation, DateTime DOB, byte[] Photo, byte[] Signature)
        {
            nic = NIC;
            name = Name;
            address = Address;
            contact = Contact;
            email = Email;
            occupation = Occupation;
            dob = DOB;
            photo = Photo;
            signature = Signature;
        }

        public int CID
        {
            get { return cid; }
            set { cid = value; }
        }
        public string NIC
        {
            get { return nic; }
            set { nic = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }
        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }
        public byte[] Photo
        {
            get { return photo; }
            set { photo = value; }
        }
        public byte[] Signature
        {
            get { return signature; }
            set { signature = value; }
        }
    }
}

