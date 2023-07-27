namespace Atividade   /// todas as classses estão no mesmo projeto de ambiente 

{
   class Pessoa_Juridica : Clientes
   {

    public string CNPJ {get;set;}
    public string IE   {get;set;}
    public override void Pagar_imposto(float v)
    {
        this.Valor =  v;
        this.Valor_imposto = this.Valor * 20 / 100;
        this.Total = this.Valor + this.Valor_imposto;


    }

   }

}