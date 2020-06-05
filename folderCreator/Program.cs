using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.AccessControl;
using System.Diagnostics;
using System.Xml;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


            // --- Templates ---



            string[] monthsTemplate = { "1. January", "2. February", "3. March", "4. April", "5. May", "6. June", "7. July", "8. August", "9. September", "10. October", "11. November", "12. December" };
            string[] daysTemplate = {"1. Monday", "2. Tuesday", "3. Wednesday", "4. Thursday", "5. Friday", "6. Saturday", "7. Sunday"};



            // --- Templates --- 


            // Condition for the while loop
            int numberOfRuns = 0;


            while (numberOfRuns != 1)
            {

                // Ask user for path -> Assign path to "directoriesPath" -> 
                // create a bool variable called "directoryExists" to later check if directory exists or not
                Console.Write("Path for directories to be created: ");
                string directoriesPath = @Console.ReadLine();
                    bool directoryExists = Directory.Exists(directoriesPath);



                newLine();




                // Check if path exists, and if yes, execute code

                if (directoryExists)
                {
                    // Ask user for name scheme -> assign asnswer to "nameSceheme" -> 
                    // use "nameScheme" to create the path to the desired directory and assign it to "nameOfFolders"

                    Console.Write("Name scheme of the folders: ");
                    string nameScheme = Console.ReadLine();
                    string nameOfFolders = directoriesPath + "\\" + nameScheme;



                    newLine();



                    // CODE FOR USING TEMPLATES

                    if (nameScheme == "months")
                    {
                        Console.Write("Would you like to use the Months tempalte? y/n\n> ");
                        string monthsTemplateAnswer = Console.ReadLine();

                        if (monthsTemplateAnswer == "y")
                        {

                            
                            newLine();

                            // Give the user ability to add years after the months template, for extra detail

                            Console.Write("Would you also like to add a year? y/n\n> ");
                            string addAYear = Console.ReadLine();



                            newLine();


                            // If user wants to add year we create 12 folders with the names from monthTemplate + the year chosen by the user

                            if (addAYear == "y")
                            {
                                Console.WriteLine("Year: ");
                                string yearDate = Console.ReadLine();

                                for (int i = 0; i < monthsTemplate.Length; i++)
                                {
                                    // creates the "months folders" and adds the "year" chosen by the user at the end of each of them
                                    Directory.CreateDirectory(directoriesPath + "\\" + monthsTemplate[i] + " " + yearDate);
                                }

                                
                                
                                newLine();

                                
                                
                                Console.WriteLine("Procedure Completed");

                                
                                
                                newLine();


                                
                                
                                // -- Check if user wants to open Windows Explorer to folder --

                                Console.Write("Would you like to open Windows Explorer to the path where the folders were created: y/n\n>");
                                string openingExplorerInIf = Console.ReadLine();

                                if (openingExplorerInIf == "y")
                                {
                                    Process.Start("explorer.exe", @directoriesPath);
                                }



                                newLine();




                                // Check if the user wants to continue to run the program and create more folders

                                Console.Write("Continue program: y/n\n> ");
                                string continuingInIf = Console.ReadLine();

                                newLine();

                                // If the answer is yes, then rerun the program, else, 
                                if (continuingInIf == "y")
                                {
                                    continue;
                                }
                                else if (continuingInIf == "n")
                                {
                                    Console.WriteLine("Program stopping.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("I don't understand your input, program terminating.");
                                    break;
                                }

                            }
                            else
                            {
                                // If user does not want to add a year, we proceed to create 12 months folder without a year

                                for (int i = 0; i < monthsTemplate.Length; i++)
                                {
                                    Directory.CreateDirectory(directoriesPath + "\\" + monthsTemplate[i]);
                                }



                                newLine();



                                Console.WriteLine("Procedure Completed");



                                newLine();

                                // -- Check if user wants to open Windows Explorer to folder --

                                Console.Write("Would you like to open Windows Explorer to the path where the folders were created: y/n\n>");
                                string openingExplorerInIf = Console.ReadLine();

                                if (openingExplorerInIf == "y")
                                {
                                    Process.Start("explorer.exe", @directoriesPath);
                                }

                                newLine();



                                // Check if the user wants to continue to run the program and create more folders

                                Console.Write("Continue program: y/n\n> ");
                                string continuingInIf = Console.ReadLine();

                                newLine();

                                // If the answer is yes, then rerun the program, else, 
                                if (continuingInIf == "y")
                                {
                                    continue;
                                }
                                else if (continuingInIf == "n")
                                {
                                    Console.WriteLine("Program stopping.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("I don't understand your input, program terminating.");
                                    break;
                                }
                            }
                        }
                    } else if (nameScheme == "days") {

                        // Using the DAYS template

                        Console.Write("Would you like to use the Days template? y/n\n> ");
                        string daysTemplateAnswer = Console.ReadLine();

                        // Check if user wants to use the "days" template

                        if (daysTemplateAnswer == "y")
                        {

                            newLine();

                            for (int i = 0; i < daysTemplate.Length; i++)
                            {
                                Directory.CreateDirectory(directoriesPath + "\\" + daysTemplate[i]);
                            }

                            newLine();

                            Console.WriteLine("Procedure Completed");

                            newLine();



                            // -- Check if user wants to open Windows Explorer to folder --

                            Console.Write("Would you like to open Windows Explorer to the path where the folders were created: y/n\n>");
                            string openingExplorerInIf = Console.ReadLine();

                            if (openingExplorerInIf == "y")
                            {
                                Process.Start("explorer.exe", @directoriesPath);
                            }



                            newLine();



                            // Check if the user wants to continue to run the program and create more folders
                            Console.Write("Continue program: y/n\n> ");
                            string continuingInIf = Console.ReadLine();

                            newLine();

                            // If the answer is yes, then rerun the program, else, 
                            if (continuingInIf == "y")
                            {
                                continue;
                            }
                            else if (continuingInIf == "n")
                            {
                                Console.WriteLine("Program stopping.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("I don't understand your input, program terminating.");
                                break;
                            }
                        }

                    }

                    // END OF CODE FOR USING TEMPLATES






                    // Asks user how many folders to create -> Assigns value to "numberOfFoldersStr" then converts it to Int and assigns it to "numberOfFolders"

                    Console.Write("Number of folders to be created: ");
                    string numberOfFoldersStr = Console.ReadLine();
                    int numberOfFolders = Convert.ToInt32(numberOfFoldersStr);



                    newLine();


                    // If number of folders is higher than 50, check whether user really wants that or he introduced
                    // a higher value by mistake. Used to avoid the creation of too many folders by mistake.

                    if (numberOfFolders > 50) 
                    {

                        // Ask if user is sure he wants to create that many folders

                        Console.Write("Are you sure you want to create that many folders: y/n\n> ");
                        string answer = Console.ReadLine();



                        newLine();


                        // If user is sure, proceed with the code

                        if (answer == "y")
                        {
                            Console.WriteLine("Okay!");

                            
                            
                            newLine();


                            // "for" loop that creates the required number of folders.
                            for (int i = 0; i < numberOfFolders; i++)
                            {

                                // condition used to remove any number from the first folder
                                // and add numbers only starting from the second folder
                                if (i < 1)
                                {
                                    Directory.CreateDirectory(nameOfFolders);
                                }
                                else
                                {
                                    Directory.CreateDirectory(nameOfFolders + Convert.ToString(i));
                                }
                            }



                            Console.WriteLine("Procedure Completed");



                            newLine();


                            // -- Check if user wants to open Windows Explorer to folder --

                            Console.Write("Would you like to open Windows Explorer to the path where the folders were created: y/n\n>");
                            string openingExplorerInIf = Console.ReadLine();

                            if (openingExplorerInIf == "y")
                            {
                                Process.Start("explorer.exe", @directoriesPath);
                            }


                            newLine();



                            // Check if the user wants to continue to run the program and create more folders
                            Console.Write("Continue program: y/n\n> ");
                            string continuingInIf = Console.ReadLine();

                            newLine();

                            // If the answer is yes, then rerun the program, else, 
                            if (continuingInIf == "y")
                            {
                                continue;
                            }
                            else if (continuingInIf == "n")
                            {
                                Console.WriteLine("Program stopping.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("I don't understand your input, program terminating.");
                                break;
                            }



                        }
                        else if (answer == "n")
                        {

                            // If user made a mistake and doesn't want to create so many folders, restart the program
                            
                            Console.WriteLine("Okay, let's try again!");

                            newLine();

                            continue;
                        }
                    }

                    
                    // If numberOfFolders is less than 50, then the program just creates the folders.

                    
                    
                    // "for" loop that creates the required number of folders.
                    for (int i = 0; i < numberOfFolders; i++)
                    {
                        // condition used to remove any number from the first folder
                        // and add numbers only starting from the second folder
                        if (i < 1)
                        {
                            Directory.CreateDirectory(nameOfFolders);
                        }
                        else
                        {
                            Directory.CreateDirectory(nameOfFolders + Convert.ToString(i));
                        }
                    }

                    
                    
                    Console.WriteLine("Procedure Completed");

                    
                    
                    newLine();

                    // -- Check if user wants to open Windows Explorer to folder --

                    Console.Write("Would you like to open Windows Explorer to the path where the folders were created: y/n\n>");
                    string openingParentFolder = Console.ReadLine();

                    if (openingParentFolder == "y")
                    {
                        Process.Start("explorer.exe", @directoriesPath);
                    }

                    newLine();




                    // Check if the user wants to continue to run the program and create more folders
                    Console.Write("Continue program: y/n\n> ");
                    string continuing = Console.ReadLine();

                    newLine();

                    // If the answer is yes, then rerun the program, else, 
                    if (continuing == "y")
                    {
                        continue;
                    }
                    else if (continuing == "n")
                    {
                        Console.WriteLine("Program stopping.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("I don't understand your input, program terminating.");
                        break;
                    }

                    
                    // > end of original "if" statement that checks whether the directory given by the user is valid or not

                }
                else
                {
                    // else, if directory does not exist, tell that to the user and rerun the program

                    Console.WriteLine("Directory does no exist, please try again!");
                    continue;
                }

            }

        }

        // Creating a new Line method
        public static void newLine()
        {
            Console.WriteLine(Environment.NewLine);
        }





    }
}