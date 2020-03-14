using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCoreReactREST.Entities
{
    public class Like
    {
        [Key]
        public int Id { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public Comment Comment { get; set; }

        [ForeignKey("Comment")]
        public int CommentId { get; set; }


    }
}
