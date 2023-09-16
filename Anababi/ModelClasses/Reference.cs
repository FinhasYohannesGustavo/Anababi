using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace Anababi.ModelClasses
{

    public class Reference
    {
        public enum ReferenceType
        {
            Book,
            Article
        }
        public enum ReferenceGenre
        {
            Fiction,
            NonFiction,
            ScienceFiction,
            Thriller,
            Fantasy,
            Romance,
            Adventure,
            Drama,
            Historical,
            Dystopian,
            Satire
        }

        [Key]
        public int Id {  get; set; }
        public string Title { get; set; } = null!;
        public DateTime PublishedOn { get; set; }
        public string ISBN { get; set; } = null!;
        public ReferenceType Type { get; set; }
        public ReferenceGenre Genre { get; set; }
        public Creator Creator { get; set; } = null!;
        public byte[]? CoverImage { get; set; }
        public string Description { get; set; } = null!;

        public Reference() { }

        public Reference(Reference reference)
        {
            Id = reference.Id;
            Title = reference.Title;
            PublishedOn = reference.PublishedOn;
            Creator = reference.Creator;
            ISBN = reference.ISBN;
            Type = reference.Type;
            Genre = reference.Genre;
            CoverImage = reference.CoverImage;
            Description = reference.Description;
        }
    }
}