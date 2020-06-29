namespace deber2
{
    class Empleado3
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sector { get; set; }
        public string RecordMes { get; set; }

        public string Presentar3()
        {
            return $"En tercer lugar {Nombre} {Apellido} ubicado en el sector {Sector}";
        }
        public string ReconocerRecord3()
        {
            return $"con un record de {RecordMes} botellas recolectadas al mes";
        }
    }
}
