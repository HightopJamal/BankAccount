using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielLibrary
{
    public class Name
    {
        private string first;
        private char initial;
        private string last;

        public Name(String a, String l)
        {
            first = a;
            last = l;

        }


        public Name(String f, char i, String l)
            : this(f, l)
        {

            initial = i;

        }

        public override String ToString()
        {

            if (initial == '\u0000')

                return first + " " + last;

            else

                return first + " " + initial + " " + last;

        }

    }




    public class Address
    {

        private String street;

        private String city;

        private String state;

        private String zip;

        public Address(String st, String cy, String se, String zp)
        {

            street = st;

            city = cy;

            state = se;

            zip = zp;

        }

        public override String ToString()
        {

            return street + "\n" + city + ", "

            + state + " " + zip; // Note 6

        }
    }

    public class Person
    {

        private String id;

        private Name name;

        private Address address;

        public Person(String i, Name n, Address a)
        {

            id = i;

            name = n;

            address = a;

        }

        public String GetId()
        {

            return id;

        }

        public override String ToString()
        {

            return name + "\n" + address;

        }

    }


    abstract class Account
    {

        private double balance;

        private Person holder;

        public Account(Person p)
            : this(0, p)
        {

        }

        public Account(double initialAmount, Person p)
        {

            balance = initialAmount;

            holder = p;

        }

        public String GetId()
        {

            return holder.GetId();

        }

        public void Deposit(double amount)
        {

            balance += amount;

        }

        public virtual double Withdraw(double amount)
        {

            if (balance >= amount)
            {

                balance -= amount;

                return amount;

            }

            else

                return -1.0;

        }

        public double GetBalance()
        {

            return balance;


        }
    }


    class Checking : Account
    {

        private double minBalance;

        private double charge;

        public Checking(Person p, double minAmount, double charge)

            : base(p)
        {

            minBalance = minAmount;

            this.charge = charge;

        }

        public double ProcessCheck(double amount)
        {

            if (GetBalance() >= minBalance)

                return base.Withdraw(amount);

            else

                return base.Withdraw(amount + charge);

        }

        public override double Withdraw(double amount)
        {

            return ProcessCheck(amount);

        }

    }

    class Savings : Account
    {

        private double interestRate;

        public Savings(double amount, Person p, double rate)

            : base(amount, p)
        {

            interestRate = rate;

        }

        public void PostInterest()
        {

            double balance = GetBalance();

            double interest = interestRate / 100 * balance;

            Deposit(balance + interest);

        }
    }
}

        

