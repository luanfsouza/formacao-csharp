//int32 é uma variavel de tipo inteiro de 32bits que representa 2 bilhões
//int64 é uma variavel de tipo long 64bits que representa 9 trilhões

int a = Convert.ToInt32("46");
Console.WriteLine(a); 

int b = int.Parse("145");
Console.WriteLine(b); 

string c = "138-";
int d = 10;
int.TryParse(c, out d);
Console.WriteLine(d); 
