using Labirinto.RegraNegocio;

char opcao;
bool sair = false;
LabirintoSolver labirinto;

do
{
    Console.WriteLine("-----Solucionador de Labirintos-----");
    Console.WriteLine("");
    Console.WriteLine("# Desenvolvido por Diego Silveira");
    Console.WriteLine("#");
    Console.WriteLine("# 22 de junho de 2011");
    Console.WriteLine("------------------------------------");
    Console.WriteLine("");
    Console.WriteLine("----------------MENU----------------");
    Console.WriteLine("");
    Console.WriteLine("1 - Resolver Labirinto Nivel 1");
    Console.WriteLine("2 - Resolver Labirinto Nivel 2");
    Console.WriteLine("3 - Resolver Labirinto Nivel 3");
    Console.WriteLine("4 - Sair");

    opcao = Console.ReadKey().KeyChar;
    Console.Clear();

    switch (opcao)
    {
        case '1':
            labirinto = new LabirintoSolver(8, Maps.Labirinto01, false);
            labirinto.ResolverConsole();
            break;
        case '2':
            labirinto = new LabirintoSolver(10, Maps.Labirinto02, false);
            labirinto.ResolverConsole();
            break;
        case '3':
            labirinto = new LabirintoSolver(20, Maps.Labirinto03, false);
            labirinto.ResolverConsole();
            break;
        case '4':
            sair = true;
            break;
    }
    
        
}

while (!sair);
