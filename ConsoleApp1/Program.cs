using ConsoleApp1;


Account a1 = new(1, 1, "Mwesigwa");
Console.WriteLine(a1);

Lion lion = new Lion();
lion.Eat();
lion.Sleep();

Elephant elephant = new Elephant();
elephant.Eat();
elephant.Sleep();

Bird bird = new();
bird.Eat();
bird.Sleep();
bird.Fly();

IFlyable flyable = new Plane();
flyable.Fly();




Library library = new();
library.AddBook(new Book("Robert T Kiyosaki", "Rich dad poor dad"));
library.AddBook(new Book("Henry", "Rich island"));
library.ShowBooks();

