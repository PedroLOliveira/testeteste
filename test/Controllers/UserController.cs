using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using test.Models;

// For your convenience here are error messages and titles that you should use in your code:
// "User '{userId}' was not found!"
// "Invalid data!"
// "Create a new user."
// "Edit a user."
// "/User/Confirmation"
// "/User/ListOfUsers"

namespace test.Controllers
{
    public class UserViewModel
    {
        public Guid? Id { get; set; }
        public string Login { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string Title { get; set; }
        public string ErrorMessage { get; set; }
        public bool CreationMode { get; set; }
    }

    public class UserController
    {
        private IUserService _service;

        public UserController(IUserService userService)
        {
            _service = userService;
        }
    }
}

// You do not need to uncomment the code below. It is here just for reference.


public interface IUserService
{
    // Creates a new user and returns its identifier.
    // Throws an exception if a user is null.
    // Throws an exception if a login is null or empty.
  Guid Create(User user);
  // Returns a found user or null.
  User Get(Guid id);
    // Returns true if a user was updated (firstname and lastname) or false if it was not possible to find it.
    // Throws an exception if an userToUpdate is null.
  bool Update(User userToUpdate);
}



public class User
{
  public Guid Id { get; set; }
  public string Login { get; set; }
  public string Firstname { get; set; }
  public string Lastname { get; set; }
}
