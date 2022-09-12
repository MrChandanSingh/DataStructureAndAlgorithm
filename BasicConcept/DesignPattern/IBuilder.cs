using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.DesignPattern
{
    public interface IBuilder
    {
        void Reset();
        void SetRecipient(string recipient);
        void SetHeader(string header);
        void SetBody(string body);
        //MessagingService GetMessagingService();
    }


    public class SMSServiceBuilder : IBuilder
    {
        //public MessagingService GetMessagingService()
        //{
        //    throw new NotImplementedException();
        //}

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void SetBody(string body)
        {
            throw new NotImplementedException();
        }

        public void SetHeader(string header)
        {
            throw new NotImplementedException();
        }

        public void SetRecipient(string recipient)
        {
            throw new NotImplementedException();
        }
    }
}
