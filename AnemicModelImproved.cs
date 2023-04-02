namespace CleanArchitecture
{
    sealed class AnemicModelImproved
    {
        public int ID { get; private set; }
        public string? Name { get; private set; }
        public string? Email { get; private set; }

        public AnemicModelImproved(int id, string name, string email)
        {
            DataIsValid(name, email);
            ID = id;
            Name = name;
            Email = email;
        }

        private void DataIsValid(string name, string email)
        {
            if (name is null || name == "")
                throw new Exception("Name is invalid!");

            if (!Util.EmailIsValid(email))
                throw new Exception("Email is invalid!");
        }

    }
}
