using System;

namespace AccessModifier
{
    public class Person
    {
        private DateTime _birthdate;
        //private does information hiding

        public void SetBirthdate(DateTime birthdate) //DateTime part of c# na pwede maglagay ng Date at time
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
}