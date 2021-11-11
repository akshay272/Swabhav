using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolationApp.Model
{
    class FixedDeposite
    {
        private string _name;
        private double _amount;
        private int _duration;
        private FestivalType _festivalType;
        public FixedDeposite(string name, double amount, int duration, FestivalType festivalType)
        {
            this._name = name;
            this._amount = amount;
            this._duration = duration;
            this._festivalType = festivalType;
        }

        public double SimpleIntest()
        {
            float interest =(float) (_amount * CalculateRate() * _duration / 100);
            return interest;
            
        }
        public double CalculateRate()
        {
            float interestRate = 7f;
            if(_festivalType == FestivalType.DIWALI)
            {
                interestRate = 8f;
                return interestRate;
            }
            else if (_festivalType == FestivalType.EID)
            {
                interestRate = 8.5f;
                return interestRate;
            }
            else if (_festivalType == FestivalType.NEY_YEAR)
            {
                interestRate = 9f;
                return interestRate;
            }
            else
            {
                return interestRate;
            }

        }
    }
}
