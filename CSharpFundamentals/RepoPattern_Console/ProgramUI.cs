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
        // the method that runs/starts the UI part of the application
        public void Run()
        {
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
                        DisplayAllContentByTitle();
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

        }

        //View current StreamingContent that is saved
        private void DisplayAllContent()
        {

        }
        //View existing content by title
        private void DisplayAllContentByTitle()
        {

        }

        //UPdate existing content
        private void UpdateExistingContent()
        {

        }
        //Delete existing content
        private void DeleteExistingContent()
        {

        }
    }
}
