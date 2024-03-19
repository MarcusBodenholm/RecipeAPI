﻿using RecipeAPI.Repository.Context;
using RecipeAPI.Repository.Entities;
using RecipeAPI.Repository.Interfaces;

namespace RecipeAPI.Repository.Repos
{
    public class UserRepo : IUserRepo
    {
        private readonly RecipeDBContext _dbContext;
        public UserRepo(RecipeDBContext dBContext)
        {
            _dbContext = dBContext;    
        }
        public void CreateUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }
        public User? GetUser(int id)
        {
            User user = _dbContext.Users.SingleOrDefault(u => u.Id == id);
            return user;
        }
        public List<User> GetAllUsers()
        {
            List<User> users = _dbContext.Users.ToList();
            return users;
        }
        public void DeleteUser(User toDelete)
        {
            _dbContext.Users.Remove(toDelete);
            _dbContext.SaveChanges();
        }
        public void UpdateUser()
        {
            _dbContext.SaveChanges();
        }
    }
}