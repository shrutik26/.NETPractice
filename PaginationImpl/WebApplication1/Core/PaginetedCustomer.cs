using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Core
{
    public class PaginetedCustomer
    {
        public PaginetedCustomer(IEnumerable<Customer> items, int count, int pageNumber, int postsPerPage)
        {
            Metadata = new Metadata
            {
                CurrentPage = pageNumber,
                PostsPerPage = postsPerPage,
                TotalPages = (int)Math.Ceiling(count / (double)postsPerPage),
                TotalPosts = count
            };
            this.customers = items;
        }

        public Metadata Metadata { get; set; }

        public IEnumerable<Customer> customers { get; set; }

        public static PaginetedCustomer ToPaginatedPost(IQueryable<Customer> posts, int pageNumber, int postsPerPage)
        {
            var count = posts.Count();
            var chunk = posts.Skip((pageNumber - 1) * postsPerPage).Take(postsPerPage);
            return new PaginetedCustomer(chunk, count, pageNumber, postsPerPage);
        }
    }

    public class Metadata
    {
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public int PostsPerPage { get; set; }
        public int TotalPosts { get; set; }
    }
}

