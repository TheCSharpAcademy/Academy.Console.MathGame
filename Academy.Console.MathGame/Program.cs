int index = 1;
string name = "Pablo";
char initial = 'P';
int year = 2022;
decimal height = 1.85m;
bool doWeLoveToCode = true;

string myParagraph = @$"These are the most common data types:
{index++} - string, example: {name}
{index++} - char, example: {initial}
{index++} - int, example: {year}
{index++} - decimal, example: {height}
{index++} - bool, example: {doWeLoveToCode}";

Console.WriteLine(myParagraph);

Console.ReadLine();