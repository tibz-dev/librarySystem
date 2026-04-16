namespace LibrarySystem.Application.DTOs
{
    public class BookResponseDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Status { get; set; }  // "Available" or "Borrowed"
    }
}
