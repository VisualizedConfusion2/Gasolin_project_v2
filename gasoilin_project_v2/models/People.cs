namespace gasoilin_project_v2


{
    public class People
    {



        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        public People(string name, string description, string imagePath)
        {
            Name = name;
            Description = description;
            ImagePath = imagePath;
        }

    }
}
