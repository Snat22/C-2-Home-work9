using Domain;

namespace Infrastructure;

public class PostService
{
    List<Post> posts = new List<Post>();

    public List<Post> GetPosts()
    {
        return posts;
    }

    public void AddPost(Post post)
    {
        posts.Add(post);
    }

    public void UpdatePost(Post post)
    {
        foreach (var it in posts)
        {
            if (it.Id==post.Id)
            {
                it.Title = post.Title;
                it.Description = post.Description;
                it.VoteAmount = post.VoteAmount;
            }break;
        }
    }

    public void Delete(int id)
    {
        foreach (var it in posts)
        {
            if (it.Id == id)
            {
                posts.Remove(it);
            }break;
        }
    }
}
