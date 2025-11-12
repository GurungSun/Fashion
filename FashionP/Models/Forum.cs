using System;

namespace FashionP.Models
{
    public class Forum
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Date { get; set; } = DateTime.Now.ToString("MMMM dd, yyyy");

        public Forum(Guid id, string title, string content, string date)
        {
            Id = id;
            Title = title;
            Content = content;
            Date = date;
        }
    }
}