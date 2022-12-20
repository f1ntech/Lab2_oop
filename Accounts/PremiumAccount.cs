using System;
namespace lab2oop
{
    public class PremiumAccount : Account
    {
        public PremiumAccount(string UserName) : base(UserName) {

        }
        public override double GetKoef
        {
            get { return 1.5; }
        }
    }
}


