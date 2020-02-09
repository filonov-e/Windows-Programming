using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class FirstClassPassenger : EconomyPassenger
    {
        public float Bonus { get; private set; }
        public string MealMenu { get; private set; }

        override public Ticket this[int index]
        {
            set
            {
                Tickets.Insert(index, value);
                this.Bonus += value.GetPrice() * Constants.bonusRate;
            }

            get
            {
                return Tickets[index];
            }
        }

        public FirstClassPassenger(
            string mealMenu,
            float luggageWeight,
            string id,
            string firstName,
            string lastName,
            string phoneNumber
        ) : base(
            luggageWeight,
            id,
            firstName,
            lastName,
            phoneNumber
        )
        {
            this.Bonus = 0.0f;
            this.MealMenu = mealMenu;
        }

        override public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Bonus " + this.Bonus);
            sb.AppendLine("Meal menu " + this.MealMenu);
            sb.AppendLine(base.GetInfo());

            return sb.ToString();
        }
    }
}
