namespace FarmOOP
{
    public class Horse : IAnimal
    {
        #region Gets
        public string GetName()
        {
            return "horse";
        }

        public string GetSound()
        {
            return "heehaw";
        }

        #endregion

        #region OverrideMethods
        public override bool Equals(object obj)
        {
            Horse newObj = (Horse)obj;
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