using System;
using System.Media;
using System.Threading;

class Program
{
    static void Main()
    {
        PlayVoiceGreeting();
        DisplayLogo();
        StartChatbot();
    }

    // Voice Greeting
    static void PlayVoiceGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("greeting.wav");
            player.PlaySync();
        }
        catch
        {
            Console.WriteLine("Voice greeting could not be played.");
        }
    }

    //  ASCII IMAGE DISPLAY
    static void DisplayLogo()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(@"
   _____       _                 _____                 
  / ____|     | |               |  __ \               
 | |     _   _| |__   ___ _ __  | |__) |___  ___  ___ 
 | |    | | | | '_ \ / _ \ '__| |  _  // _ \/ __|/ _ \
 | |____| |_| | |_) |  __/ |    | | \ \  __/\__ \ (_) |
  \_____|\__,_|_.__/ \___|_|    |_|  \_\___||___/\___/
        ");

        Console.ResetColor();
    }

    // Chatbot System
    static void StartChatbot()
    {
        Console.Write("\nEnter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine($"\nWelcome {name}! I'm your Cybersecurity Awareness Bot.");
        Console.WriteLine("Ask me about phishing, passwords, scams, or malware.");
        Console.WriteLine("Type 'exit' to quit.\n");

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("You: ");
            Console.ResetColor();

            string input = Console.ReadLine();

            // 5. Input Validation
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Bot: Please enter a valid message.");
                continue;
            }

            input = input.ToLower();

            if (input == "exit")
            {
                Console.WriteLine("Bot: Goodbye! Stay safe online.");
                break;
            }

            // 4. Basic Responses
            Respond(input);
        }
    }

    //  Response System 
    static void Respond(string input)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;

        if (input.Contains("how are you"))
        {
            TypeEffect("Bot: I'm just a program, but I'm here to help you stay safe online!");
        }
        else if (input.Contains("your purpose"))
        {
            TypeEffect("Bot: My purpose is to educate you about cybersecurity.");
        }
        else if (input.Contains("phishing"))
        {
            TypeEffect("Bot: Phishing is a scam where attackers trick you into giving personal information.");
        }
        else if (input.Contains("password"))
        {
            TypeEffect("Bot: Use strong passwords with letters, numbers, and symbols.");
        }
        else if (input.Contains("scam"))
        {
            TypeEffect("Bot: Be careful of scams. Always verify sources.");
        }
        else if (input.Contains("malware"))
        {
            TypeEffect("Bot: Malware is harmful software. Avoid suspicious downloads.");
        }
        else
        {
            TypeEffect("Bot: I didn’t quite understand that. Could you rephrase?");
        }

        Console.ResetColor();
    }

    //  6. Typing Effect (Enhanced UI)
    static void TypeEffect(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(20);
        }
        Console.WriteLine();

    }
}