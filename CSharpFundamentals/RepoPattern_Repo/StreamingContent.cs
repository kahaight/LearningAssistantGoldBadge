using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoPattern_Repo
{
    public enum GenreType 
    { 
        Horror = 1, 
        RomCom, 
        SciFi, 
        Comedy, 
        Action, 
        Fantasy
    }
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string MaturityRating { get; set; }
        public double StarRating { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public GenreType TypeOfGenre { get; set; }

        public StreamingContent() { }
        public StreamingContent(string title, string description, string maturityRating, double starRating, bool isFamilyFriendly, GenreType genre)
        {
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            IsFamilyFriendly = isFamilyFriendly;
            TypeOfGenre = genre;
        }


    }
}
