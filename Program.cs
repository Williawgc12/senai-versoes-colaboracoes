using System; // essa linha significa que estamos usando a biblioteca System C#
namespace  Atividade
{
    class Programa ///classe 
    {
        static void Main(string[] args)
        {

            float val_pag;
                    Console.WriteLine("Informe o Nome: ");
                    string var_nome = Console.ReadLine();
                    Console.WriteLine("Informe o Endereço: ");
                    string var_endereco = Console.ReadLine();
                    Console.WriteLine("Pessoa Física (PF) ou Jurídica (PJ) ?");
                    string var_pessoa = Console.ReadLine();
                    if(var_pessoa == "PF"){
                            //Pessoa Fisica \\\

                            Pessoa_Fisica pf = new Pessoa_Fisica();
                            pf.Nome = var_nome;
                            pf.Endereco = var_endereco;
                            Console.WriteLine("Informar o CPF: ");
                            pf.CPF = Console.ReadLine();
                            Console.WriteLine("Informar o RG: ");
                            pf.RG = Console.ReadLine();
                            Console.WriteLine("Informar o valor de compra: ");
                            val_pag = float.Parse(Console.ReadLine());
                            pf.Pagar_imposto(val_pag);
                            Console.WriteLine("-------Pessoa Física (PF) --------");

                            Console.WriteLine("Nome...........: " + pf.Nome);
                            Console.WriteLine("Endereço.......: " + pf.Endereco);
                            Console.WriteLine("CPF............: " + pf.CPF);
                            Console.WriteLine("RG.............: " + pf.RG);
                            Console.WriteLine("Valor de compra: " + 
                            pf.Valor.ToString("C"));
                            Console.WriteLine("Impostos.......: " + 
                            pf.Valor_imposto.ToString("C"));
                            Console.WriteLine("Total a Pagar...: " + 
                            pf.Total.ToString("C"));


                    }
                    if(var_pessoa == "PJ"){
                        ///Pessoa Juridica \\\\
                        Pessoa_Juridica pj = new Pessoa_Juridica();
                            pj.Nome = var_nome;
                            pj.Endereco = var_endereco;
                            Console.WriteLine("Informar o CNPJ: ");
                            pj.CNPJ = Console.ReadLine();
                            Console.WriteLine("Informar o IE: ");
                            pj.IE = Console.ReadLine();
                            Console.WriteLine("Informar o valor de compra: ");
                            val_pag = float.Parse(Console.ReadLine());
                            pj.Pagar_imposto(val_pag);
                            Console.WriteLine("-------Pessoa Juridica (PJ) --------");

                            Console.WriteLine("Nome...........: " + pj.Nome);
                            Console.WriteLine("Endereço.......: " + pj.Endereco);
                            Console.WriteLine("CNPJ............: " + pj.CNPJ);
                            Console.WriteLine("IE.............: " + pj.IE);
                            Console.WriteLine("Valor de compra: " + 
                            pj.Valor.ToString("C"));
                            Console.WriteLine("Impostos.......: " + 
                            pj.Valor_imposto.ToString("C"));
                            Console.WriteLine("Total a Pagar...: " + 
                            pj.Total.ToString("C"));

                    }
        }
    }    
}
