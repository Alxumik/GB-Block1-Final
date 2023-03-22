Console.Write("Введите число строк данных к обработке: ");
string N = Console.ReadLine();
Console.WriteLine("Введите строки данных к обработке: ");

int n = System.Convert.ToInt32(N);
string[] strInput = new string[n];
int count = 0;

for (int i = 0; i < n; i++){
    strInput[i] = Console.ReadLine();
    if(strInput[i].Length <= 3) count++;
}

string[] strOutput = new string[count];
int j = 0;

for (int i = 0; i < n; i++) if(strInput[i].Length <= 3) strOutput[j++] = strInput[i];

for (int i = 0; i < count; i++) Console.WriteLine(strOutput[i]);