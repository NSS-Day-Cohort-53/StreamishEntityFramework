using Streamish.Models;
using System;
using System.Collections.Generic;

namespace Streamish.Repositories
{
    public interface IVideoRepository
    {
        void Add(Video video);
        void Delete(int id);
        List<Video> GetAll();
        public List<Video> GetAllWithComments();
        Video GetById(int id);
        void Update(Video video);
        Video GetByIdWithComments(int id);
        public List<Video> SearchByDate(DateTime dateTime);
        public List<Video> Search(string criterion, bool sortDescending);
    }
}