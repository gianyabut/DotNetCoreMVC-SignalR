using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample_DotNetCoreMVC_SignalR
{
    public interface IPostRepository
    {
        List<Post> GetAll();
        Post GetPost(int id);
        void AddPost(Post post);
    }
}
