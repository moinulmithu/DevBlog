using DevsCraft.Core;
using DevsCraft.Core.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevsCraft.Web.ViewModels
{
    public class ListViewModel
    {
        public ListViewModel(IBlogRepository _blogRepository, int p)
        {
            Posts = _blogRepository.Posts(p - 1, 10);
            TotalPosts = _blogRepository.TotalPosts();
        }
        public IList<Post> Posts { get; private set; }
        public int TotalPosts { get; private set; }
    }
}