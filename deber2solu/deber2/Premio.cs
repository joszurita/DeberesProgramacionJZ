namespace deber2
{
    class Premio
    {
        public int Id { get; set; }
        public string numCheque { get; set; }
        public string Banco { get; set; }
        public string Monto { get; set; }

        public string InducarNum()
        {
            return $"El siguiente cheque con numero: {numCheque} del Banco {Banco}: es otorgado al primer lugar, con un monto de {Monto} por su esfuerzo y dedicación";
        }
        public string InducarNum2()
        {
            return $"El siguiente cheque con numero: {numCheque} del Banco {Banco}: es otorgado al segundo lugar, con un monto de {Monto} por su esfuerzo y dedicación";
        }
        public string InducarNum3()
        {
            return $"El siguiente cheque con numero: {numCheque} del Banco {Banco}: es otorgado al tercer lugar, con un monto de {Monto} por su esfuerzo y dedicación";
        }
    }
}
