namespace StudentMgtApp.Dtos
{
    public class UserDto
    {
        
        public int Id { get; set; }
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string Role { get; set; } = default!;

    }
    public class LoginRequest
    {
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
        public LoginRequest(string email,string password)
        {
            Email = email;
            Password = password;
        }
    }
    public class LoginResponse
    {
    
        public int Id{ get; set; }
        public string Email{ get; set; } = default!;
        public string Role{ get; set; } = default!;
    }
}