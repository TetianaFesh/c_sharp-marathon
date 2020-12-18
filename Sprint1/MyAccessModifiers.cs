using System;

namespace Sprint1
{
    public class MyAccessModifiers{
        private int birthYear;
        protected string personalInfo;
        private protected string IdNumber;

        public MyAccessModifiers(int _birthYear, string _idNumber, string _personalInfo)
        {
            birthYear = _birthYear;
            personalInfo = _personalInfo;
            IdNumber = _idNumber;
        }

       public int Age
       {
            get { return DateTime.Now.Year - birthYear; }
       }

        private static readonly byte averageMiddleAge = 50;
        internal string Name {get; set; }
        public string NickName { get; internal set; }

        internal protected void HasLivedHalfOfLife()
        {

        }

        public static bool operator == (MyAccessModifiers obj1, MyAccessModifiers obj2)
        {
            return obj1.Name == obj2.Name && obj1.Age == obj2.Age && obj1.personalInfo == obj2.personalInfo;
        }
        public static bool operator !=(MyAccessModifiers obj1, MyAccessModifiers obj2)
        {
            return obj1.Name != obj2.Name || obj1.Age != obj2.Age || obj1.personalInfo != obj2.personalInfo;
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                MyAccessModifiers obj1 = (MyAccessModifiers)obj;
                return this.Name == obj1.Name && this.Age == obj1.Age && this.personalInfo == obj1.personalInfo;
            }

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}