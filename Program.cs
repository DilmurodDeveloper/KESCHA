Console.Write("Ismingzni kiriting: ");
string name = Console.ReadLine();
Console.Write("Familyangizni kiriting: ");
string lastname = Console.ReadLine();
string greeting  = $"Salom, {name}  {lastname}";
System.Console.WriteLine(greeting);

System.Console.Write("Yoshingizni kiriting: ");
string ageAsString = Console.ReadLine();
System.Console.WriteLine("Konvertatsiya qilinmoqda...");
int age =  Convert.ToInt32(ageAsString);
System.Console.WriteLine($"Muvaffaqiyatli konvertatsiya qilindi! {age}");

int KeschaYoshi = 5;
int yoshFarqi = age - KeschaYoshi;

System.Console.WriteLine($"sizning va kescha o'rtasidagi farq {yoshFarqi}");