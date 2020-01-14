namespace B2B.SharedKernel
{
    public interface IEntitySubMultiLang : IEntity
    {
        int BaseId { get; set; }
        string Lang { get; set; }
    }
}