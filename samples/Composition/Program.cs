using Composition.Models;

User user = new User() {
  Email = "email@gmail.com",
  Password = "password123",
  Address = new Address() {
    Street = "Rua X",
    City = "Cidade Y",
    Number = "123a",
    Country = "Brasil"
  },
  Posts = new List<Post>() {
    new Post() {
      Content = "Treta renato cariani",
      NumberOfLikes = 10,
      NumberOfDeslikes = 2
    },
    new Post() {
      Content = "BBB 2024",
      NumberOfLikes = 5,
      NumberOfDeslikes = 1
    }
  }
};