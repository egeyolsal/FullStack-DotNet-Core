namespace basics.Models {
    
    public class Repository {
        private static readonly List<Course> _courses = new List<Course>();
        static Repository() {

            _courses = new List<Course> {
                new Course() { 
                    Id = 1, Title = "C# Basics", 
                    description = "Learn the basics of C# programming.", 
                    Image="1.png", 
                    isActive = true, 
                    isHome = true, 
                    Tags = new string[] { "C#", "Programming", "Basics" } 
                },
                new Course() { 
                    Id = 2, 
                    Title = "ASP.NET Core", 
                    description = "Build web applications using ASP.NET Core.", 
                    Image="2.png", 
                    isActive = true, 
                    isHome = true, 
                    Tags = new string[] { "ASP.NET", "Web", "Development" } 
                },
                new Course() { 
                    Id = 3, 
                    Title = "Entity Framework Core", 
                    description = "Learn how to use Entity Framework Core for data access.", 
                    Image="3.png", 
                    isActive = true, 
                    isHome = false, 
                    Tags = new string[] { "Entity Framework", "Database", "Data Access" } 
                }
            };
        }

        public static List<Course> Courses {
            get {
                return _courses;
            }
        }

        public static Course? GetCourseById(int? id) {
            return _courses.FirstOrDefault(c => c.Id == id);
        } 
    }

}