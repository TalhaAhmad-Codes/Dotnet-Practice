namespace ProblemsSolution.Problem_5
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool CheckPassword(string input)
            => Password == input;
    }
}
