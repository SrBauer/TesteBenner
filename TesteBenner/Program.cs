using TesteBenner;

var network = new Network(size: 8);

network.Connect(1, 2);
network.Connect(6, 2);
network.Connect(2, 4);
network.Connect(5, 8);

Console.WriteLine(network.Query(1, 6));
Console.WriteLine(network.Query(6, 4));
Console.WriteLine(network.Query(7, 4));
Console.WriteLine(network.Query(5, 6));
Console.WriteLine(network.Query(2, 3));
Console.WriteLine(network.Query(3, 4));
Console.WriteLine(network.Query(2, 6));
Console.WriteLine(network.Query(8, 5));
