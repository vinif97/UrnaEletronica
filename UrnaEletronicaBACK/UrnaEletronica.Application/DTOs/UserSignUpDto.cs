namespace UrnaEletronica.Application.DTOs
{
    public class UserSignUpDto
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public CitizenDto? Citizen { get; set; }
        public AddressDto? Address { get; set; }
    }
}
