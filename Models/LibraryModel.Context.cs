﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace A4_Task1MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LibraryModelContext : DbContext
    {
        public LibraryModelContext()
            : base("name=LibraryModelContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Book> Books { get; set; }
    
        public virtual int AddBook(string title, string author, Nullable<short> year_published, Nullable<short> number_pages, string contents)
        {
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var authorParameter = author != null ?
                new ObjectParameter("author", author) :
                new ObjectParameter("author", typeof(string));
    
            var year_publishedParameter = year_published.HasValue ?
                new ObjectParameter("year_published", year_published) :
                new ObjectParameter("year_published", typeof(short));
    
            var number_pagesParameter = number_pages.HasValue ?
                new ObjectParameter("number_pages", number_pages) :
                new ObjectParameter("number_pages", typeof(short));
    
            var contentsParameter = contents != null ?
                new ObjectParameter("contents", contents) :
                new ObjectParameter("contents", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddBook", titleParameter, authorParameter, year_publishedParameter, number_pagesParameter, contentsParameter);
        }
    
        public virtual int DeleteBook(Nullable<short> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteBook", idParameter);
        }
    
        public virtual ObjectResult<Book> SelOffCount(Nullable<int> offset, Nullable<int> count)
        {
            var offsetParameter = offset.HasValue ?
                new ObjectParameter("offset", offset) :
                new ObjectParameter("offset", typeof(int));
    
            var countParameter = count.HasValue ?
                new ObjectParameter("count", count) :
                new ObjectParameter("count", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Book>("SelOffCount", offsetParameter, countParameter);
        }
    
        public virtual ObjectResult<Book> SelOffCount(Nullable<int> offset, Nullable<int> count, MergeOption mergeOption)
        {
            var offsetParameter = offset.HasValue ?
                new ObjectParameter("offset", offset) :
                new ObjectParameter("offset", typeof(int));
    
            var countParameter = count.HasValue ?
                new ObjectParameter("count", count) :
                new ObjectParameter("count", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Book>("SelOffCount", mergeOption, offsetParameter, countParameter);
        }
    
        public virtual int UpdateBook(Nullable<short> id, string title, string author, Nullable<short> year_published, Nullable<short> number_pages, string contents)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(short));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var authorParameter = author != null ?
                new ObjectParameter("author", author) :
                new ObjectParameter("author", typeof(string));
    
            var year_publishedParameter = year_published.HasValue ?
                new ObjectParameter("year_published", year_published) :
                new ObjectParameter("year_published", typeof(short));
    
            var number_pagesParameter = number_pages.HasValue ?
                new ObjectParameter("number_pages", number_pages) :
                new ObjectParameter("number_pages", typeof(short));
    
            var contentsParameter = contents != null ?
                new ObjectParameter("contents", contents) :
                new ObjectParameter("contents", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateBook", idParameter, titleParameter, authorParameter, year_publishedParameter, number_pagesParameter, contentsParameter);
        }
    }
}
