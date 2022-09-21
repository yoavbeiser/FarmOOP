using System;

namespace FarmOOP
{
    public class Chick : IAnimal
    {
        #region Gets
        public string GetName()
        {
            return "chick";
        }

        public string GetSound()
        {
            return "cluck";
        }
        #endregion

        #region OverrideMethods
        public override bool Equals(object obj)
        {
            Chick newObj = (Chick)obj;
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