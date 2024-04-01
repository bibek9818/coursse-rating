namespace AcademicAssistanceProject
{
    public class CourseRating
    {
        public string CourseName { get; set; }
        public double Rating { get; set; }

        public CourseRating(string courseName, double rating)
        {
            CourseName = courseName;
            Rating = rating;
        }
    }
}
