namespace Lab3_14.Models.Base
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        DateTime DateCreated { get; set; }
        DateTime? DateModified { get; set; }
    }
}
