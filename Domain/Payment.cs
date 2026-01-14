namespace BurgerGo.Domain
{
    public class Payment : BaseDomainModel
    {
        public string CardHolder { get; set; } = string.Empty;

        public string CardNumber { get; set; } = string.Empty;

        public string CVC { get; set; } = string.Empty;
    }
}