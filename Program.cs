// Программа, которая определяет соответствие закрытых скобок открытым и правильность очередности их написания
System.Console.WriteLine("Введите в любой последовательности открытые и закрытые скобки");
string text = Console.ReadLine();
void DoTheBracketsMatch (string inputText)
{
    int quantityLeftBrackets = 0;
    int quantityRightBrackets = 0;
    bool correctWriting = true;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] != '(' && text[i] != ')') System.Console.WriteLine("Вы ввели символы, отличные от скобок");
        else if (text[i] == '(') quantityLeftBrackets++;
        else if (text[i] == ')') quantityRightBrackets++;
        else if (quantityRightBrackets>quantityLeftBrackets)
        {
            correctWriting = false;
            System.Console.WriteLine(correctWriting);
            break;
        }
    }
    if (quantityLeftBrackets == quantityRightBrackets) System.Console.WriteLine(correctWriting);
    else
    {
        correctWriting = false;
        System.Console.WriteLine(correctWriting);
    }
}
DoTheBracketsMatch(text);