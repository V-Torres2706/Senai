namespace Atividade
{
    class Pessoa_Juridica
    {
        public string cnpj {get; set;} 
        public string ie {get; set;}
        public virtual void Pagar_Imposto(float valor)  
    {
         this.valor = v;
         this.valor_imposto = this.valor* 20 / 100;
         this.total =this.valor + this.valor_imposto;
    
     }
   }
}