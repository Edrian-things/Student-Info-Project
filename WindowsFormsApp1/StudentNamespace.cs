namespace StudentNamespace
{
    public class StudentInfo
    {
        private string studenID;
        private string lastName;
        private string firstName;

        public StudentInfo() { }
        public StudentInfo(string studenID, string lastName, string firstName)
        {
            this.studenID = studenID;
            this.lastName = lastName;
            this.firstName = firstName;
        }
        public string StudenID
        {
            get { return studenID; }
            set { studenID = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
    }
}
    
