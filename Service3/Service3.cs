using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.Diagnostics;

namespace ATG
{
    public class Service3 : IService3
    {
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "/{text}")]
        public Message RESTService3(String text)
        {
            Debug.WriteLine("here " + text);
            return new Message(text);
        }
    }
}
