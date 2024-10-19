namespace Projeto_Combate {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite os dados do primeiro campeão:");
            Console.Write("Nome: ");
            string nome1 = Console.ReadLine();
            Console.Write("Vida inicial: ");
            int vidaInicial1 = int.Parse(Console.ReadLine());
            Console.Write("Ataque: ");
            int ataque1 = int.Parse(Console.ReadLine());
            Console.Write("Armadura: ");
            int armadura1 = int.Parse(Console.ReadLine());
            Champion champ1 = new Champion(nome1, vidaInicial1, ataque1, armadura1);
            Console.WriteLine();
            Console.WriteLine("Digite os dados do segundo campeão: ");
            Console.WriteLine();
            string nome2 = Console.ReadLine();
            Console.Write("Vida inicial: ");
            int vidaInicial2 = int.Parse(Console.ReadLine());
            Console.Write("Ataque: ");
            int ataque2 = int.Parse(Console.ReadLine());
            Console.Write("Armadura: ");
            int armadura2 = int.Parse(Console.ReadLine());
            Champion champ2 = new Champion(nome2, vidaInicial2, ataque2, armadura2);
            Console.WriteLine();
            Console.WriteLine("Quantos turnos você deseja executar? ");
            int turno = int.Parse(Console.ReadLine());
            for (int i = 0; i < turno; i++) {
                Console.WriteLine();
                Console.WriteLine("Resultado do turno " + (i+1));
                champ1.takeDamage(champ2);
                champ2.takeDamage(champ1);
                Console.WriteLine(champ1.Name + ":" + champ1.status());
                Console.WriteLine(champ2.Name + ":" + champ2.status());
                Console.WriteLine();

            }
        }
    }
}
