namespace deber2
{
    class Empleado1
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sector { get; set; }
        public string RecordMes { get; set; }

        public string Presentar1()
        {
            return $"En primer lugar {Nombre} {Apellido} ubicado en el sector {Sector}";
        }
        public string ReconocerRecord1()
        {
            return $"con un icreible record de {RecordMes} botellas recolectadas al mes";
        }
    }
}
