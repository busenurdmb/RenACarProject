using NArchitecture.Core.Persistence.Repositories;


namespace Domain.Entities;
public class Brand:Entity<Guid>
{
    public string Name { get; set; }

    public virtual ICollection<Model> Models { get; set; }
}
//entity niye base entity den inherit ederiz?
//içerisinde 4 tane field mevcut
