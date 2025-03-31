namespace CIS229Assignment03.Models;

public class Identity
{
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

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Group(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

public class Role
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Role(int id, string name)
    {
        Id = id;
        Name = name;
    }
}