namespace MeetingApp.Models {
    
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            
            _users.Add(new UserInfo() { Id=1, Name = "Paul", Email="paul@gmail.com", Phone = "5453563336", AttendanceStatus = true} );
            _users.Add(new UserInfo() { Id=2, Name = "John", Email="john@gmail.com", Phone = "5453563261", AttendanceStatus = true} );
            _users.Add(new UserInfo() { Id=3, Name = "Ali", Email="ali@gmail.com", Phone = "5453563564", AttendanceStatus = false} );
        }

        public static List<UserInfo> Users 
        {
            get
            {
                return _users;
            }   
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count() + 1; 
            _users.Add(user);
        } 

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }

    }

}