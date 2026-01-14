namespace BurgerGo.Domain
{
    public class Promotion : BaseDomainModel
    {
        public string Title { get; set; } = string.Empty;

        public int DiscountPercentage { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
