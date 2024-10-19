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
            Console.Write("Nome: ");
            string nome2 = Console.ReadLine();
            Console.Write("Vida inicial: ");
            int vidaInicial2 = int.Parse(Console.ReadLine());
            Console.Write("Ataque: ");
            int ataque2 = int.Parse(Console.ReadLine());
            Console.Write("Armadura: ");
            int armadura2 = int.Parse(Console.ReadLine());
            Champion champ2 = new Champion(nome2, vidaInicial2, ataque2, armadura2);
            Console.WriteLine();
            Console.Write("Quantos turnos você deseja executar? ");
            int turno = int.Parse(Console.ReadLine());
            bool champMorto = false;
            for (int i = 0; i < turno; i++) {
                Console.WriteLine();
                Console.WriteLine("Resultado do turno " + (i + 1) + ":");
               
                champ2.takeDamage(champ1);
                champ1.takeDamage(champ2);
                 if (champ2.Life <= 0 || champ1.Life <= 0) {
                    champMorto = true;
                }
                Console.WriteLine(champ1.status());
                Console.WriteLine(champ2.status());
                if (champMorto) {
                    break;
                }
            }
            Console.WriteLine("Fim do combate");
        }
    }
}
