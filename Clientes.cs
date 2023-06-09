namespace Atividade //dentro da pasta atividade
{
    class Clientes //criei uma class chamada cliente
    {
        public string nome {get; set;} //aqui ele vai pegar o nome 
        public string endereco {get; set;}// endereco
        public float valor {get; protected set;} 
        public float valor_imposto {get; protected set;}
        public float total {get; protected set;}

        public virtual void Pagar_Imposto(float v) //aqui ele vai pegar o valor do imposto da pessoa e fazer o calculo
        {
            this.valor = v;
            this.valor_imposto = this.valor * 10 / 100;
            this.total = this.valor + this.valor_imposto;

        }
    }
}