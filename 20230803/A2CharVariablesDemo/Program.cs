using HeaderFooter;
Header _header = new();
Footer _footer = new();
_header.DisplayHeader ('=', "A2 Char Variables Demo");

ShowcharDemo();
_footer.DisplayFooter('-');


static void ShowcharDemo(){
           ForegroundColor = ConsoleColor.Green;

WriteLine($"Char: {sizeof(char)} byte(s) of memory. Its Min and Max Values are {(int)char.MinValue} and {(int)char.MaxValue}");


char choice;
choice = 'Y';
WriteLine ($"Char: {choice} {(int)choice}");
choice = 'y';
WriteLine ($"Char: {choice} {(int)choice}");


for(int i = 97 , j=65; i < 123; i++)
{
        Write($"{(char)i} == {i} :: {(char)j} == {j++} || ");
} 


ResetColor();
}