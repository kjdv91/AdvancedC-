string[] fraudulentOrderIDs = new string[3] {"1","2","3"};

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// identificadores de pedidos
string[] orders = new string[8] {"B123", "C234", "A345", "C15", "B177", "G30003", "C235", "B179"};

string[] names = new string[3] {"Pepe", "Juan", "Luis"};


foreach (string name in names)
{
    Console.WriteLine(name);
}

int[] inventory = {200,544,700,175,250};

int suma =0;
int bin = 0;
foreach(int i in inventory){
    suma +=i;
    bin++;
    Console.WriteLine($"Bin {bin} = {i} items (Running total: {suma})");
   

}
 Console.WriteLine($"El valor del inventario total es {suma}");


foreach (string order in orders)
{
    if (order.StartsWith('B')){
        Console.WriteLine($"Order No. {order} es Fraude!");
    }
}
