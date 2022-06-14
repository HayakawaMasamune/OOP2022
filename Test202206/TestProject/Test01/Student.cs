namespace Test01 {
    class Student {

        public string Name { get; set; }
        public string Subject { get; set; }
        public int Score { get; set; }

        public Student(string Name,string Subject,int Score)
        {
            this.Name = Name;
            this.Subject = Subject;
            this.Score = Score;

        }

    }
}
