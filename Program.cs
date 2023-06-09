using System; //utilizando a biblioteca system para pegar dados
namespace Atividade //dentro da minha pasta atividades
{
    class program //vai executar esse programa
    {
        static void Main(string[]args) //vai executar o que estiver dentro do static void main
        {
            float val_pag; //declarando uma variavel
            Console.WriteLine("Informar Nome"); //o comando writeline mostra o que ta entre aspas na tela e o usuario pode digitar algo nela
            string var_nome = Console.ReadLine(); //readline serve para armazenar e ler o dado digitado pelo writeline
            Console.WriteLine("Informar Endereço");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ?");
            string var_tipo = Console.ReadLine();
            if(var_tipo == "f") //se for digitado "f" o codigo irá excecutar o codigo a baixo
            {
                // --- Pessoa Física ----
                Pessoa_Fisica pf = new Pessoa_Fisica(); //apelidando a classe "pessoa_fisica" para "pf"
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Informar CPF:");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informar RG:");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informar Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine()); //convertendo o valor de string em float usando "float.Parse"
                pf.Pagar_Imposto(val_pag); //Vai utilizar a variavel "val_pag" e vai colocar na "pagar_imposto"
                Console.WriteLine("-------- Pessoa Física ---------");
                Console.WriteLine("Nome ..........: " + pf.nome);
                Console.WriteLine("Endereço ......: " + pf.endereco);
                Console.WriteLine("CPF ...........: " + pf.cpf);
                Console.WriteLine("RG ............: " + pf.rg);
                Console.WriteLine("Valor de Compra: " + pf.valor.ToString("C")); //O comando ToString serve para transformar o valor em string e o ("C") é para colocar o valor em Coins ,ou seja, formato de moeda
                Console.WriteLine("Imposto .......: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar : " +  pf.total.ToString("C"));
            }
            if(var_tipo == "j") //se digitado "j" sera executado o codigo a baixo.
            {
                // Pessoa Jurídica
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informar CNPJ:");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informar IE:");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informar Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("-------- Pessoa Jurídica ---------");
                Console.WriteLine("Nome ..........: " + pj.nome);
                Console.WriteLine("Endereço ......: " + pj.endereco);
                Console.WriteLine("CNPJ ..........: " + pj.cnpj);
                Console.WriteLine("IE ............: " + pj.ie);
                Console.WriteLine("Valor de Compra: " + pj.valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar : " +  pj.total.ToString("C"));
            }
        }
    }
}
