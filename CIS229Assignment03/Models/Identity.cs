using System.Runtime.Serialization;

namespace CIS229Assignment03.Models;

[Serializable]
public class Identity
{
    [DataMember]
    public int UserId { get; set; }
    public bool Active { get; set; }
    public string Term { get; set; }
    public Group[] Groups { get; set; }
    public Role Role { get; set; }

    public Identity(int userId, bool active, string term, Group[] groups, Role role)
    {
        UserId = userId;
        Active = active;
        Term = term;
        Groups = groups;
        Role = role;
    }
}

[Serializable]
public class Group
{
    [DataMember]
    public int Id { get; set; }
    public string Name { get; set; }

    public Group(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

[Serializable]
public class Role
{
    [DataMember]
    public int Id { get; set; }
    public string Name { get; set; }

    public Role(int id, string name)
    {
        Id = id;
        Name = name;
    }
}