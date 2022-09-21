using System;

namespace FarmOOP
{
    public class Pig : IAnimal
    {
        #region Gets
        public string GetName()
        {
            return "Pig";
        }

        public string GetSound()
        {
            return "oink";
        }
        #endregion

        #region OverrideMethods
        public override bool Equals(object obj)
        {
            Pig newObj = (Pig)obj;
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