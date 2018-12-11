using System;
using System.IO;
public class Welcome
{
	
	public static void Main(string[] args)
	{
	
	Console.WriteLine("Input 1 for frequency analysis or 2 for decryption");
	string option = Console.ReadLine();
	
	switch (option) {
		
		case "1":
	Console.WriteLine("Input some text to find out the frequency");
	string fullText = Console.ReadLine();
	
	char[] charArray = fullText.ToCharArray();
	Console.WriteLine("What letter would you like to search for?");
	string foundletter = Console.ReadLine();
	string newString = "";
	int numchar = 0;
	int numUserChar = 0;
	
	
	foreach(char a in charArray){
	
	if(a == ' ')
	continue;	
	
	newString += a;
	numchar++;
	
 if(a.ToString() == foundletter){
	 numUserChar++;
 }
	}
	Console.WriteLine("The word you inputted was: {0}", newString);
	Console.WriteLine("The sentence is {1} characters long", newString, numchar);
	Console.WriteLine("The number of occurences that {0} appears is {1} times", foundletter, numUserChar);
	
	break;
	
	case "2":
	
	
	string initialText = @"Mu husudjbo iqm, veh jxu vyhij jycu, jxu huikbj ev q iefxyijysqjut hqdiecmqhu qjjqsa, qdt
jxu uvvusji jxqj yj xqt ed jxu Dqjyedqb Xuqbjx Iuhlysu, ydsbktydw qcrkbqdsui ruydw jkhdut
qmqo qdt fqjyudji xqlydw jxuyh efuhqjyedi sqdsubbut mxybij fhufqhydw je we yd je
jxuqjhu. Jxu MqddqSho lyhki, qi yj rusqcu ademd, xqt vekdt q auo lkbduhqrybyjo, qdt yj
xqt q tulqijqjydw ycfqsj qi edu xeifyjqb qvjuh qdejxuh hufehjut jxqj yj xqt ruud qvvusjut;
duqhbo vyvjo yd jejqb. Yd jxu yccutyqju qvjuhcqjx, unfuhji qdt ydiytuhi qbyau mudj ed je
dumi ekjbuji qdt ed je iesyqb cutyq, myjx jxuyh unfbqdqjyedi eh xem jxyi sekbt xqlu
xqffudut. Mxqj yi sbuqh yi jxqj iecujxydw duutut je ru tedu je udikhu jxqj iksx qd qjjqsa
mybb duluh xqlu jxu iqcu ycfqsj ed jxu Dqjyedqb Xuqb Iuhlysu yd jxu vkjkhu."; 


	Console.WriteLine("Enter the shift value");
	int shiftvalue = Convert.ToInt32(Console.ReadLine());
	
	foreach(char b in initialText){
		
		int letter = b;
		letter = letter + shiftvalue;
		
		if (letter == 123)
		letter = 97;
		if (letter == 124)
		letter = 98;
	    if (letter == 125)
		letter = 99;
		if (letter == 126)
		letter = 100;
		if (letter == 127)
		letter = 101;
		if (letter == 128)
		letter = 102;
		if (letter == 129)
		letter = 103;
		if (letter == 130)
		letter = 104;
		if (letter == 131)
		letter = 105;
		if (letter == 132)
		letter = 106;
		if (letter == 133)
		letter = 107;
		if (letter == 93)
		letter = 67;
		if (letter == 98)
		letter = 72;
		if (letter == 42)
		letter = 32;
		if (letter == 54)
		letter = 44;
		if (letter == 56)
		letter = 46;
		if (letter == 69)
		letter = 59;
		if (letter == 72)
		letter = 98;
	
	
		string decodedstring = Convert.ToString(letter);
		
			 string decodedmessage = Char.ConvertFromUtf32(letter);
		
			
			Console.Write(decodedmessage);
	
	
	
	}
		
		break;
	}
		
		Console.ReadLine();
		//keeps the console window open to output the values
		

}
}
































