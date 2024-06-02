using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assignment7.Models
{
    public class Posts
    {
        [Key] public string Post_Id { get; set; }
        [Required] public string Owner_User_Id { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Commented_Post_Id { get; set; } = string.Empty;
        public string Original_Post_Id { get; set; } = string.Empty;
        public string Media_Path { get; set; } = string.Empty;
        [Required] public short Post_Type { get; set; }
        public string Location_Id { get; set; } = string.Empty;
        [Required] public DateTime Created_Date { get; set; }
    }
}
