using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace IIdPasswordService
{
    public class Service1 : IIdPasswordService
    {
        public Results passwordCreate( string firstName, string lastName, int age)
        {
            
            Results res = new Results();
            string fn = "", ln = "";
            int id = 0;
            ln = lastName.Substring(0, 2);
            fn = firstName.Substring(firstName.Length - 2);
            id = age % 5;

 
            res.fn = fn;
            res.ln = ln;
            res.id = id;
            return res;
        }

        public int loginId(int age)
        {

            return (age * new Random().Next(100, 200));
        }


    }
}
