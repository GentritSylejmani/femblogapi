using System.Collections.Generic;
using femblogAPI.Models;

namespace femblogAPI.Data
{
    public interface IFemblogRepo
    {
        bool SaveChanges();
        IEnumerable<Post> GetAllPosts();
        Post GetPostById(int id);
        void CreatePost(Post post);
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);

    }
}