using System.Collections.Generic;

namespace movie_app_task_backend.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
          
      public ICollection<Media> Media { get; set; }

      public int MediaId { get; set; }    
    }
}