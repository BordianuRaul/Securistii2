using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Models
{
    public class Post
    {
        /*
        post_id
        owner_user_id
        description
        commented_post_id
        original_post_id
        media_path
        post_type
        location_id
        created_date
         */
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)] public string Post_Id { get; set; }

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
