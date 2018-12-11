using System;

public class cipher
{
	public static void Main(string[] args)
	{
		int shiftencode = 7;
		int shiftdecode = 9;
		
		string encode = "we attack at dawn";
		string encoded = "";
		
		Console.WriteLine("x = {0}", shiftencode);
		Console.WriteLine("Plain text: {0}", encode);
		Console.Write("Encoded text: ");
		
		foreach(char c1 in encode)
		{
			int numvalue1 = NumFromLetterEncode(c1);
			
			if(numvalue1 == 123)
				numvalue1 = 97;
				
			if(numvalue1 == 124)
				numvalue1 = 98;
				
			if(numvalue1 == 125)
				numvalue1 = 99;
				
			if(numvalue1 == 126)
				numvalue1 = 100;
				
			if(numvalue1 == 127)
				numvalue1 = 101;
				
			if(numvalue1 == 128)
				numvalue1 = 102;
				
			if(numvalue1 == 129)
				numvalue1 = 103;
				
			encoded = ((char)numvalue1).ToString();
			Console.Write("{0}", encoded);
			
		}
		
		string decode = "fn jan anjmh oxa hxda xamnab";
		string decoded = "";
		
		Console.WriteLine("\n\nx = {0}", shiftdecode);
		Console.WriteLine("Encoded text: {0}", decode);
		Console.Write("Plain text: ");
		
		foreach(char c2 in decode)
		{
			int numvalue2 = NumFromLetterDecode(c2);
			
			if(numvalue2 == 96)
				numvalue2 = 122;
			
			if(numvalue2 == 95)
				numvalue2 = 121;
			
			if(numvalue2 == 94)
				numvalue2 = 120;
			
			if(numvalue2 == 93)
				numvalue2 = 119;
			
			if(numvalue2 == 92)
				numvalue2 = 118;
			
			if(numvalue2 == 91)
				numvalue2 = 117;
			
			if(numvalue2 == 90)
				numvalue2 = 116;
			
			if(numvalue2 == 89)
				numvalue2 = 115;
			
			if(numvalue2 == 88)
				numvalue2 = 114;
			
			decoded = ((char)numvalue2).ToString();
			Console.Write("{0}", decoded);
			
		}
		
		Console.ReadLine();
		
	}
	
		
	public static int NumFromLetterEncode(char c1)
	{
		int shiftencode = 7;
		
		if(c1 >= 'a' && c1 <= 'z')
			{
				c1 -= (char)('a' - 1);
				int n = c1;
				c1 = (char)(n + 96 + shiftencode);
				
			}
			else c1 = '\0';
			
		return (int)c1;
			
	}
	
	public static int NumFromLetterDecode(char c2)
	{
		int shiftdecode = 9;
		
		if(c2 >= 'a' && c2 <= 'z')
			{
				c2 -= (char)('a' - 1);
				int n = c2;
				c2 = (char)(n + 96 - shiftdecode);
				
			}
			else c2 = '\0';
			
		return (int)c2;
			
	}
	
					
}
		
		