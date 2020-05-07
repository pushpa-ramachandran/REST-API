using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace IIdPasswordService
{
    [ServiceContract]
    public interface IIdPasswordService
    {

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/passwordCreate?firstName={firstName}&lastName={lastName}&age={age}")]             // define input format
        Results passwordCreate(string firstName, string lastName, int age);


        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/loginId?age={age}")]             // define input format
        int loginId(int age);

    }
        [DataContract]
        public class Results
        {
            [DataMember]
            public string fn { get; set; }
            [DataMember]
            public string ln { get; set; }

            [DataMember]
            public int id { get; set; }
        }
    }

   

