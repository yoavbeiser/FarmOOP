namespace FarmOOP
{
    public class Dog : IAnimal
    {
        #region Gets
        public string GetName()
        {
            return "Dog";
        }

        public string GetSound()
        {
            return "woof";
        }
        #endregion

        #region OverrideMethods
        public override bool Equals(object obj)
        {
            Dog newObj = (Dog)obj;
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