using Lesson_8_Collection;

MyCollection collection1 = new MyCollection();
MyCollection collection2 = new MyCollection();

collection1.Add(1);
collection1.Add(2);
collection1.Add(5);

collection2.Add(1);
collection2.Add(2);
collection2.Add(5);



Console.WriteLine(collection2.GetValue(2));


Console.WriteLine($"{collection1.GetLength()} + {collection2.GetLength()}");

var ans = collection1 + collection2;

for (int i = 0; i < ans.GetLength(); i++)
{
    Console.WriteLine(ans[i]);
}

Console.WriteLine(collection1 == collection2);
