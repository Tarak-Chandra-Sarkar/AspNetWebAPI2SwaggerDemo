namespace AspNetWebAPI2SwaggerDemo.Models
{
    /// <summary>
    /// Represents Authors
    /// </summary>
    public class Authors
    {
        /// <summary>
        /// Name of the Author
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Email of the Author
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// NoOfBooksWritten written by Author
        /// </summary>
        public int NoOfBooksWritten { get; set; }        
    }
}
