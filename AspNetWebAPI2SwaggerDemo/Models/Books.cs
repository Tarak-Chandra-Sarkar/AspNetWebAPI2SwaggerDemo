using System;
using System.Collections.Generic;

namespace AspNetWebAPI2SwaggerDemo.Models
{
    /// <summary>
    /// Represents Books
    /// </summary>
    public class Books
    {
        /// <summary>
        /// Title of the Book
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// PublishedDate of the Book
        /// </summary>
        public DateTime PublishedDate { get; set; }

        /// <summary>
        /// ISBN of the Book
        /// </summary>
        public int ISBN { get; set; }        
    }
}
