using Anababi.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;

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

        public static Creator GetCreator(Reference reference)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AnababiContext"].ConnectionString;
            int creatorId;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                int id = reference.Id;

                string query = "SELECT CreatorId FROM [AnababiLMS].[dbo].[References] WHERE Id = " + id.ToString();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    creatorId = (int?)command.ExecuteScalar() ?? 0;
                }
            }

            using (var context = new AnababiContext())
            {
                return context.Creators.FirstOrDefault(c => c.Id == creatorId);
            }
        }

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

        public static List<Reference> GetAllReferencesFromDB()
        {
            using AnababiContext context = new AnababiContext();
            List<Reference> references = context.References
                .Include(r => r.Creator)
                .Include(r => (r as PhysicalReference).Location)
                .ToList();
            
            //foreach(var reference in references)
            //{
            //    reference.Creator = GetCreator(reference);
            //}
            return references;
        }
    }
}