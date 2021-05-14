namespace ProjetoHospitais
{
    public class Upa : Hospital
    {
        public int QuantAmbulacias { get; set; }

        public override float valorTotalPessoal(){
            return (QuantFuncionarios + QuantAmbulacias) * SalMedioFuncionarios ;
        }

  
     
    }
}