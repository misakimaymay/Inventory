/*
  This code reverses a message, counts the number of times a particular character appears, then prints the results to the console window.
*/

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = originalMessage.ToCharArray();
Array.Reverse(charMessage);

int letterCount = 0;

foreach (char i in charMessage) 
{ 
    if (letter == 'o') 
    {
        letterCount++;
    } 
}

string newMessage = new String(charMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times");