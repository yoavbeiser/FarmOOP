using System;

namespace FarmOOP
{
    public class Cow : IAnimal
    {
        #region Gets
        public string GetName()
        {
            return "cow";
        }

        public string GetSound()
        {
            return "moo";
        }
        #endregion

        #region OverrideMethods
        public override bool Equals(object obj)
        {
            Cow newObj = (Cow)obj;
            return newObj != null
                   && newObj.GetName() == this.GetName()
                   && newObj.GetSound() == this.GetSound();
        }

        public override string ToString()
        {
            return $"{GetName()}: {GetSound()}";
        }
        #endregion
    }
}