int[] array = {0,1,2,3,4,5,6,7,8,9};
string[] strArray = {"Tim", "Martin", "Nikki", "Sara"};
bool[] arr = new bool[10];
for(int i =0; i<arr.Length; i++)
{
    if(i % 1 == 0)
    {
        arr[i] = true;
    }
    else
    {
        arr[i] = false;
    }
}
Console.WriteLine(arr[1]);

List<string> flavors = new List<string>()
{
    "Chocolate", "Vanilla", "Strawberry", "Cookie", "Mint"
};
Console.WriteLine(flavors.Count);
Console.WriteLine(flavors[2]);
flavors.Remove(flavors[2]);
Console.WriteLine(flavors[2]);
Console.WriteLine(flavors.Count);

int q = 0;
Random rand = new Random();
Dictionary<string, string> favorites = new Dictionary<string, string>();
int j = 0;

while(j<strArray.Length)
{
    q = rand.Next(0, 4);
    favorites.Add(strArray[j], flavors[q]);
    j++;
};

foreach(KeyValuePair<string,string> entry in favorites)
{
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}
