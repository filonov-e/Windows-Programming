using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class EconomyPassenger : Passenger
    {
        public float LuggageWeight { get; private set; }

        public EconomyPassenger(
            float luggageWeight,
            string id,
            string firstName,
            string lastName,
            string phoneNumber
        ) : base(id, firstName, lastName, phoneNumber)
        {
            if (luggageWeight > Constants.MaxLuggageWeight)
            {
                throw new Exception(
                    "Attribute \"LuggageWeight\" cannot be assigned a value higher than " + Constants.MaxLuggageWeight
                );
            }
            LuggageWeight = luggageWeight;
        }

        public void SetLuggageWeight(float luggageWeight)
        {
            LuggageWeight = luggageWeight;
        }

        public override string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("luggage weight " + LuggageWeight);
            sb.AppendLine(base.GetInfo());
            
            return sb.ToString();
        }
    }
}
