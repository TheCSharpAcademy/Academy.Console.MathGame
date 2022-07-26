int index = 1;
string name = "Pablo";
char initial = 'P';
int year = 2022;
decimal height = 1.85m;
bool doWeLoveToCode = true;
DateTime today = DateTime.Now;

Console.WriteLine(
    @$"These are C#'s 6 most common data types:
{index++} - string, example: {name}
{index++} - char, example: {initial}
{index++} - int, example: {year}
{index++} - decimal, example: {height}
{index++} - bool, example: {doWeLoveToCode}");

Console.ReadLine();