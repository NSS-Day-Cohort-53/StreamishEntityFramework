using System;
using System.Collections.Generic;
using System.Linq;
using Streamish.Models;
using Streamish.Repositories;

namespace Streamish.Tests.Mocks
{
    internal class InMemoryUserProfileRepository : IUserProfileRepository
    {
        private readonly List<UserProfile> _data;

        public List<UserProfile> InternalData
        {
            get { return _data; }
        }
        public InMemoryUserProfileRepository(List<UserProfile> startingData)
        {
            _data = startingData;
        }

        public void Add(UserProfile userProfile)
        {
            var lastUserProfile = _data.Last();
            userProfile.Id = lastUserProfile.Id + 1;
            _data.Add(userProfile);
        }
        public void Delete(int id)
        {
            var userProfileToDelete = _data.FirstOrDefault(x => x.Id == id);
            if (userProfileToDelete == null)
            {
                return;
            }
            _data.Remove(userProfileToDelete);
        }
        public List<UserProfile> GetAll()
        {
            return _data;
        }
        public UserProfile GetUserById(int id)
        {
            return _data.FirstOrDefault(x => x.Id == id);
        }
        public void Update(UserProfile userProfile)
        {
            var currentUserProfile = _data.FirstOrDefault(x => x.Id == userProfile.Id);
            if (currentUserProfile == null)
            {
                return;
            }
            currentUserProfile.Name = userProfile.Name;
            currentUserProfile.Email = userProfile.Email;
            currentUserProfile.ImageUrl = userProfile.ImageUrl;
            currentUserProfile.DateCreated = userProfile.DateCreated;
        }
        public UserProfile GetUserByIdWithVideos(int id)
        {
            throw new NotImplementedException();
        }
    }
}