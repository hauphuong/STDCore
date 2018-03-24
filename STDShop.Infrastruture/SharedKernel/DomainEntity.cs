namespace STDShop.Infrastruture.SharedKernel
{
    public abstract class DomainEntity<T>
    {
        public T Id { get; set; }

        /// <summary>
        /// True if enity initial and have not set value for Id
        /// </summary>
        /// <returns></returns>
        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }
    }
}