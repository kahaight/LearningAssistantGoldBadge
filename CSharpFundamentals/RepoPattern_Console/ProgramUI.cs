using RepoPattern_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoPattern_Console
{
    public class ProgramUI
    {
        private StreamingContentRepository _repo = new StreamingContentRepository();

        // the method that runs/starts the UI part of the application
        public void Run()
        {
            SeedContentList();
            Menu();
        }
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                // Display the options
                Console.WriteLine("Select a menu option \n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

                //Get the user's input
                string input = Console.ReadLine();

                // Evaluate the user's input and act accordingly
                switch (input)
                {
                    case "1":
                        //Create new content
                        CreateNewContent();
                        break;
                    case "2":
                        //View all content
                        DisplayAllContent();
                        break;
                    case "3":
                        //View content by title
                        DisplayContentByTitle();
                        break;
                    case "4":
                        //Update existing content
                        UpdateExistingContent();
                        break;
                    case "5":
                        //Delete existing content
                        DeleteExistingContent();
                        break;
                    case "6":
                        //Exit
                        Console.WriteLine("Goodbye");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;

                }

                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.Clear();

            }

        }

        //Create new streaming content
        private void CreateNewContent()
        {
            StreamingContent newContent = new StreamingContent();
            Console.WriteLine("Enter Title:\n");
            newContent.Title = Console.ReadLine();
            Console.WriteLine("Enter Description\n");
            newContent.Description = Console.ReadLine();
            Console.WriteLine("Enter Maturity Rating:\n");
            newContent.MaturityRating = Console.ReadLine();
            bool validStars = true;
            while (validStars)
            {

                Console.WriteLine("Enter Star Count\n");
                string starsAsString = Console.ReadLine();
                if (double.TryParse(starsAsString, out double result))
                {
                    newContent.StarRating = result;
                    validStars = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid numerical response, press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.WriteLine("Is Content Family Friendly?");
            string familyFriendlyString = Console.ReadLine().ToLower();
            if (familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            Console.WriteLine("Pick Genre:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Comedy\n" +
                "5. Action\n" +
                "6. Fantasy");

            newContent.TypeOfGenre = (GenreType)int.Parse(Console.ReadLine());

            _repo.AddContentToList(newContent);
        }


        //View current StreamingContent that is saved
        private void DisplayAllContent()
        {
            List<StreamingContent> contentToView = new List<StreamingContent>();
            contentToView = _repo.GetContentList();
            foreach (var content in contentToView)
            {
                Console.WriteLine(content.Title);
            }
        }
        //View existing content by title
        private void DisplayContentByTitle()
        {
            Console.WriteLine("Enter the title of the content you wish to view");
            string title = Console.ReadLine();
            StreamingContent content = _repo.GetContentByTitle(title);
            if (content != null)
            {

                Console.Clear();
                Console.WriteLine($"{content.Title}\n" +
                    $"{content.Description}\n" +
                    $"{content.MaturityRating}\n" +
                    $"{content.StarRating}\n" +
                    $"{content.IsFamilyFriendly}\n" +
                    $"{content.TypeOfGenre}");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No content by that title");
            }
        }

        //UPdate existing content
        private void UpdateExistingContent()
        {

        }
        //Delete existing content
        private void DeleteExistingContent()
        {

        }

        private void SeedContentList()
        {
            StreamingContent sharknado = new StreamingContent("Sharknado", "Tornadoes, but with sharks", "TV-14", 3.3, true, GenreType.Action);
            StreamingContent theRoom = new StreamingContent("The Room", "Banker's life gets turned upside down", "R", 3.6, false, GenreType.Horror);
            _repo.AddContentToList(sharknado);
            _repo.AddContentToList(theRoom);
        }
    }
}
