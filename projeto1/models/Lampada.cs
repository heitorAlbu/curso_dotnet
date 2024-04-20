namespace projeto1.models
{

    public class Lampada()
    {
        public bool Estado { get; set; } = false;
        public int Intensidade { get; set; }



        public void LigarDesligar()
        {
            this.Estado = !this.Estado;
        }

        public void AjustarIntensidade(int novaIntensidade)
        {
            this.Intensidade = novaIntensidade;
        }
    }
}
