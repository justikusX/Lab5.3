string originalString = "Привет, мир!";
char[] charArray = originalString.ToCharArray();
Array.Reverse(charArray);
string reversedString = new string(charArray);

Console.WriteLine(reversedString);