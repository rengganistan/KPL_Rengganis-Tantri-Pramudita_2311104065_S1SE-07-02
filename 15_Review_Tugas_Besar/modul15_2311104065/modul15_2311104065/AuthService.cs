using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;

public class AuthService
{
    private const string FilePath = "users.json";
    private List<User> users;

    public AuthService()
    {
        users = LoadUsers();
    }

    public bool Register(string username, string password)
    {
        if (!IsValidUsername(username))
        {
            Console.WriteLine("Username harus 8-20 karakter ASCII.");
            return false;
        }

        if (!IsValidPassword(password, username))
        {
            Console.WriteLine("Password tidak valid. Harus 8-20 karakter, mengandung angka, simbol, dan tidak boleh mengandung username.");
            return false;
        }

        string passwordHash = HashPassword(password);
        users.Add(new User { Username = username, PasswordHash = passwordHash });
        SaveUsers();
        return true;
    }

    public bool Login(string username, string password)
    {
        string passwordHash = HashPassword(password);
        return users.Any(u => u.Username == username && u.PasswordHash == passwordHash);
    }

    private List<User> LoadUsers()
    {
        if (!File.Exists(FilePath)) return new List<User>();
        string json = File.ReadAllText(FilePath);
        return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
    }

    private void SaveUsers()
    {
        string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(FilePath, json);
    }

    private bool IsValidUsername(string username)
    {
        return username.Length >= 8 && username.Length <= 20 &&
               username.All(c => c <= 127); // ASCII
    }

    private bool IsValidPassword(string password, string username)
    {
        if (password.Length < 8 || password.Length > 20) return false;
        if (password.ToLower().Contains(username.ToLower())) return false;
        if (!Regex.IsMatch(password, @"[0-9]")) return false;
        if (!Regex.IsMatch(password, @"[!@#$%^&*]")) return false;
        return true;
    }

    private string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] input = Encoding.UTF8.GetBytes(password);
            byte[] hash = sha256.ComputeHash(input);
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }
    }
}
