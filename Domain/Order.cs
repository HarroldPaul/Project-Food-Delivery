namespace BurgerGo.Domain
{
    public class Order : BaseDomainModel
    {
        public string? UserId { get; set; }

        public decimal TotalPrice { get; set; }

        public string Status { get; set; } = string.Empty;
    }
}
