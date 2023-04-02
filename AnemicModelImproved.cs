namespace CleanArchitecture
{
    sealed class AnemicModelImproved
    {
        public int ID { get; private set; }
        public string? Name { get; private set; }
        public string? Email { get; private set; }

        public AnemicModelImproved(string name, string email)
        {
            DataIsValid(name, email);
            Name = name;
            Email = email;
        }
        public void Update(string name, string email)
        {
            DataIsValid(name, email);
            Name = name;
            Email = email;
        }

        private void DataIsValid(string name, string email)
        {
            if (name is null || name == "")
                throw new ArgumentException("Name is invalid!");

            if (!Util.EmailIsValid(email))
                throw new ArgumentException("Email is invalid!");
        }

    }
}
