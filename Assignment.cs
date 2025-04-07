using System;

namespace TaskManagementApp
{
    public class Assignment
    {
        public string Title { get; }

        public Assignment(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be null or empty.");

            Title = title;
        }
    }
}