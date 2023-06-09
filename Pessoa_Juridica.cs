namespace Atividade
{
    class Pessoa_Juridica : Clientes //sub-classe criada para pessoa juridica dentro da classe clientes
    {
        public string cnpj {get; set;}
        public string ie {get; set;}

        public override void Pagar_Imposto(float v) //comando override ele sobscreve na class clientes o valor do imposto cobrado para pessoa juridica
        {
            this.valor = v;
            this.valor_imposto = this.valor *20 / 100;
            this.total = this.valor + this.valor_imposto;
        }
    }
}