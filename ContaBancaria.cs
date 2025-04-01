namespace POO
{
    class ContaBancaria
    {
        private double _saldo = 0;
        public void Depositar(double valor)
        {  
            _saldo += valor;
          
        }

        public void Sacar(double valor)
        {
           _saldo -= valor;          
        }

        public double VerSaldo()
        {
            return _saldo;
        }
    }
}
