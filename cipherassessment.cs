using System;

public class Welcome
{
	public static void Main (string[] args)
	{
		Console.WriteLine("Enter the text you wish to encode or decode");
		string initialText = Console.ReadLine();
		Console.WriteLine("Enter 1 for encode and 2 for decode");
		string option = Console.ReadLine();
		Console.WriteLine("--------------------");
	
		int encodeshift = 7;
		int decodeshift = 9;
		
			switch (option){
		
		case "1":
		
		Console.Write("x = {0}\nPlain text: {1}\nEncoded text: ", encodeshift, initialText);
		
		foreach(char a in initialText){
			
			
			int letter = a;
			 letter = letter + encodeshift;
			
			
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
			 if (letter == 39)
			 letter = 32;
		   
		   string encodedstring = Convert.ToString(letter);
		
			 string encodedmessage = Char.ConvertFromUtf32(letter);
		
		
			
			Console.Write(encodedmessage);
		}
		break;
		case "2":
		
		Console.Write("x = {0}\nEncoded text: {1}\nPlain text: ", decodeshift, initialText);
		
		foreach(char b in initialText){
		
		int letter2 = b;
		letter2 = letter2 - decodeshift;
		
		if (letter2 == 23)
		 letter2 = 32;
		if (letter2 == 88)
		 letter2 = 114;
		if (letter2 == 89)
		 letter2 = 115;
		if (letter2 == 90)
		 letter2 = 116;
		if (letter2 == 91)
		 letter2 = 117;
		if (letter2 == 92)
		 letter2 = 118;
		if (letter2 == 93)
		 letter2 = 119;
		if (letter2 == 94)
		 letter2 = 120;
	    if (letter2 == 95)
	     letter2 = 121;
	    if (letter2 == 96)
	     letter2 = 122;
	
		string decodedstring = Convert.ToString(letter2);
		
			 string decodedmessage = Char.ConvertFromUtf32(letter2);
		
			
			Console.Write(decodedmessage);
		
		
		
		}
		break;
	}
	
	
	Console.ReadLine();
	
	
	
	}	
		
	
	
	
	}
	
	
	
	
	

