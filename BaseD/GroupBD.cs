using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text.Json;

class GroupBD
{
    Dictionary<string, Group> groups = new();

    public GroupBD()
    {
        if (File.Exists("TWOFile.json"))
            groups = JsonSerializer.Deserialize<Dictionary<string, Group>>(File.ReadAllText("TWOFile.json"));//load file (json)
        else File.Create("TWOFile.json");
    }

    internal List<Group> SearchGroup(string text)
    {
        List<Group> result = new();
        foreach (var group in groups.Values)
        {
            if (group.Operator.Contains(text))
                result.Add(group);
        }
        return result;
    }

    public bool UpdateGroup(Group group)
    {
        if (!groups.ContainsKey(group.Operator))
            return false;
        groups[group.Operator] = group;
        Save();
        return true;
    }
    public bool AddGroup(Group group)
    {
        if (!groups.ContainsKey(group.User))
            return false;
        groups[group.User] = group;
        Save();
        return true;
    }

    public Group CreateGroup()
    {
        Group newGroup = new Group { UID = Guid.NewGuid().ToString() };
        groups.Add(newGroup.UID, newGroup);
        return newGroup;
    }

    public bool DeleteGroup(Group group)
    {
        if (!groups.ContainsKey(group.UID))
            return false;
        groups.Remove(group.UID);
        Save();
        return true;
    }

    void Save()
    {
        File.WriteAllText("TWO.json", JsonSerializer.Serialize(groups));
        //save file(json)
    }
}