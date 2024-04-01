using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;

namespace AcademicAssistanceProject
{
    public partial class CourseRatingsPage : UserControl
    {
        private List<CourseRating> _courseRatings;

        public CourseRatingsPage()
        {
            InitializeComponent();
            LoadCourseRatings();
        }

        private void LoadCourseRatings()
        {
            // Example data
            _courseRatings = new List<CourseRating>
            {
                  
            
                new CourseRating("High Quality Programming ", 4.5),
                new CourseRating("Software Testing tools", 4.8),
                new CourseRating("Software Analysis and Design", 4.7),
                new CourseRating("Software Testing Methodologies", 4.7),
                new CourseRating("Software Engineering Principles", 4.7)
            };

            CourseListBox.ItemsSource = _courseRatings;
        }
    }
}
