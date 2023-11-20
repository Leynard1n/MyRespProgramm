using System.Collections.Generic;
using System.Text.Json;

class UserBD
{
    Dictionary<string, User> users = new();

     public UserBD()
     {
         if (File.Exists("FileONE.json"))
             users = JsonSerializer.Deserialize<Dictionary<string, User>>(File.ReadAllText("FileONE.json"));//load file (json)
     }
    
    internal List<User> Search(string text)
    {
        List<User> result = new();
        foreach (var user in users.Values)
        {
            if (user.FirstName.Contains(text) ||
                    user.LastName.Contains(text))
                result.Add(user);
        }
        return result;
    }

    public bool Update(User user)
    {
        if (!users.ContainsKey(user.UID))
            return false;
        users[user.UID] = user;
        Save();
        return true;
    }

    public User Create()
    {
        User newUser = new User { UID = Guid.NewGuid().ToString() };
        users.Add(newUser.UID, newUser);
        return newUser;
    }

    public bool Delete(User user)
    {
        if (!users.ContainsKey(user.UID))
            return false;
        users.Remove(user.UID);
        Save();
        return true;
    }

    void Save()
    {
        File.WriteAllText("FileONE.json", JsonSerializer.Serialize(users));
        // save file (json)
    }
}
