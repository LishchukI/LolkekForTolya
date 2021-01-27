using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1_2_Polimorfism
{
    [Serializable]
    public class AgeOfAnimalException : ApplicationException
    {
        public DateTime ErrorTime { get; set; }
        public string CauseOfError { get; set; }

        public AgeOfAnimalException() { }
        public AgeOfAnimalException(string message, string cause, DateTime time)
            : base(message)
        {
            CauseOfError = cause;
            ErrorTime = time;
        }
        protected AgeOfAnimalException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
