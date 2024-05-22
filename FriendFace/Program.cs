namespace FriendFace
{
    internal class Program
    {
        

        public static List<User> userList = new List<User>();
        public static List<User> friendList = new List<User>();

        static User Frode = new User("Frode", "Glad", true);
        static User LoggedInUser = Frode;

        static void Main(string[] args)
        {
            addAllUsers();
            StartScreen();
        }


        static void StartScreen()
        { 
            while (true){
                
                Console.Clear(); 
                Console.WriteLine($"Welcome {LoggedInUser.UserName}");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. View Friends");
                Console.WriteLine("2. Add Friends");
                Console.WriteLine("3. Remove friends");
                Console.WriteLine("e. Exit Program");
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    viewFriends();
                } else if (userInput == "2")
                {
                    addFriends();
                } else if (userInput == "3")
                {
                    removeFriends();
                } else if (userInput.ToLower() == "e")
                {
                    System.Environment.Exit(0);

                }
            }
        }

        static void addAllUsers()
        {
            userList.Add(new User("Birgitte69", "Likar turar i fjellet", false));
            userList.Add(new User("Hubert420", "Jeg har kontroll", false));
            userList.Add(new User("PetterFraFjellet", "Fjell <3", false));
            userList.Add(new User("RagnarRockstar", "Viking av hjertet, rockestjerne av sjel", false));
            userList.Add(new User("KnuteKnuseren", "Knuteløsninger, profesjonell tauverk", false));
            userList.Add(new User("LailaLatter", "Le du, så ler jeg også!", false));
            userList.Add(new User("FrodeFrossen", "Isbading er livet!", false));
            userList.Add(new User("SolveigSolsikke", "Solsikker og solskinn, alltid på topp!", false));
        }

        static void addFriends()
        {
            Console.Clear();
            Console.WriteLine("What user would you like to add?");
            Console.WriteLine("(Enter ID or 'e' to go back)");
            Console.WriteLine();
            for (int i = 0; i < userList.Count; i++)
            {
                Console.WriteLine($"{i}. {userList[i].UserName}");
            }

            string userInput = Console.ReadLine();
            if (userInput != "e"){
                int addFriend = Convert.ToInt32(userInput);

                friendList.Add(userList[addFriend]);
                userList.RemoveAt(addFriend);
            }
        }

        static void viewFriends()
        {
            Console.Clear();
            int i;
            if (friendList.Count != 0){
                Console.WriteLine("Write friends ID to view profile, or 'e' to go back!");
                Console.WriteLine();
                for (i = 0; i < friendList.Count; i++)
                {
                    Console.WriteLine(i + ". " + friendList[i].UserName);
                }

                string userInput = Console.ReadLine();
                if (userInput != "e")
                {
                    int viewFriend = Convert.ToInt32(userInput);
                    friendProfile(viewFriend);
                }
            }
            else
            {
                Console.WriteLine("You have no friends :(");
                Console.WriteLine("(Press any key to continue");
                Console.ReadKey(true);
            }
        }

        static void friendProfile(int i)
        {
            Console.Clear();
            Console.WriteLine($"Username: {friendList[i].UserName}");
            Console.WriteLine($"Bio: {friendList[i].Bio}");
            Console.WriteLine();
            Console.WriteLine("Press any key to go back");
            Console.ReadKey(true);
        }

        static void removeFriends()
        {
            Console.Clear();
            Console.WriteLine("Enter ID of friend you want to remove, or press 'e' to exit");
            for (int i = 0; i < friendList.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine(i + ". " + friendList[i].UserName);
                Console.WriteLine();
            }

            string userInput = Console.ReadLine();
            if (userInput != "e")
            {
                int removedFriend = Convert.ToInt32(userInput);
                userList.Add(friendList[removedFriend]);
                friendList.RemoveAt(removedFriend);
            }
        }
    }
}
