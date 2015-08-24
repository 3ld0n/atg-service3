using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ATG
{
    [ServiceContract]
    public interface IService3
    {
        [OperationContract]
        Message RESTService3(String text);
    }

    [DataContract]
    public class Message
    {
        [DataMember]
        public String[] words { get; set; }
        [DataMember]
        public int longest { get; set; }
        [DataMember]
        public int shortest { get; set; }
        [DataMember]
        public String first { get; set; }
        [DataMember]
        public String last { get; set; }

        public Message(String text)
        {
            words = text.Split(new char[] { ' ' });
            first = words[0];
            last = words.Last();
            shortest = text.Length;
            longest = 0;
            for (int x = 0; x < words.Length; x++)
            {
                if (words[x].Length > longest) longest = words[x].Length;
                if (words[x].Length < shortest) shortest = words[x].Length;
            }
        }
    }
}

