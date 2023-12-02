string palavraDigitada, palavraSoletrada;

Console.WriteLine("--- Soletrar ---\n");

Console.Write("Digite uma palavra: ");
palavraDigitada = Console.ReadLine()!;

var caracteres = palavraDigitada.ToCharArray();
palavraSoletrada = String.Join('-', caracteres).ToUpper();

Console.WriteLine($"\nSoletrando \"{palavraDigitada.ToUpper()}\": {palavraSoletrada}");