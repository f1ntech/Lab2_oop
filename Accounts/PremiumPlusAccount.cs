using System;
namespace lab2oop
{
    public class PremiumPlusAccount : Account
    {
        public PremiumPlusAccount(string UserName) : base(UserName) {

        }
        public override double GetKoef
        {
            get { return 2; }
        }
    }
}

