public class Program
{
	public static void Main()
	{
		
		Console.WriteLine("Podaj liczbę (od 0 do 2 147 483 647)");
		string Liczba =	Console.ReadLine();
		int L = int.Parse(Liczba); 
		Console.WriteLine("Podaj podstawę (od 2 do 36)");
		string Podstawa =Console.ReadLine();
		int P = int.Parse(Podstawa); 
		int i=0;
		String[] tablica = new String[50];
		int licznik =0;
		
		while(licznik<1)
			{
				if(L!=0)
					{
					String a="";
					int R =  L%P;
					a=Convert.ToString(R);
						switch (R)
						{
						case 10:
						a="A"; break;
						case 11 :
						a="B"; break;
						case 12 :
						a="C";	break;
						case 13:
						a="D";	break;
						case 14:
						a="E";	break;
						case 15:
						a="F";	break;
						case 16:
						a="G";	break;
						case 17:
						a="H";	break;
						case 18:
						a="I";	break;	
						case 19:
						a="J";	break;	
						case 20:
						a="K";	break;	
						case 21:
						a="L";	break;	
						case 22:
						a="M";	break;	
						case 23:
						a="N";	break;	
						case 24:
						a="O";	break;	
						case 25:
						a="P";	break;	
						case 26:
						a="Q";	break;	
						case 27:
						a="R";	break;	
						case 28:
						a="S";	break;	
						case 29:
						a="T";	break;	
						case 30:
						a="U";	break;			
						case 31:
						a="V";	break;	
						case 32:
						a="W";	break;	
						case 33:
						a="X";	break;	
						case 34:
						a="Y";	break;	
						case 35:
						a="Z";	break;			
						default:
						break;
						}
					tablica[i] = a;
					i=i+1;
					L=(L-R)/P;
					}
				else
					{
					licznik=1;
					}
			}
		
		 
		
		int j = i;
		String wynik=" "; 
		while(j!=-1)
			
			
		
			{
				wynik = wynik+tablica[j];
				j=j-1;
			}
		Console.WriteLine("");
		Console.WriteLine("wynik w systemie "+P);
			Console.WriteLine(wynik);
		
	}
}
