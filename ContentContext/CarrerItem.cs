namespace POO.ContentContext
{
    public class CarrerItem
    {
        public CarrerItem(int ordem, string title, string description, Course course)
        {

            Ordem = ordem;
            Title = title;
            Description = description;
            Course = course ?? throw new Exception(("O curso não pode ser nulo"));
        }

        public int Ordem { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}