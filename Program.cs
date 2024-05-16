using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
    Console.WriteLine("Informações smartphone: Nokia");
    Smartphone nokia = new Nokia("2024", "123456789", "xz-1002", 8);
    nokia.InstalarAplicativo("Obsidian");
    nokia.Ligar();
    
    Console.WriteLine("\n");

    Console.WriteLine("Informações smartphone: Iphone");
    Smartphone iphone = new Iphone("2025", "987654321", "apple098", 4);
    iphone.InstalarAplicativo("Github");
    iphone.ReceberLigacao();
