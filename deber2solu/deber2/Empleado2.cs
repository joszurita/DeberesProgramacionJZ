namespace deber2
{
    class Empleado2
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sector { get; set; }
        public string RecordMes { get; set; }

        public string Presentar2()
        {
            return $"En segundo lugar {Nombre} {Apellido} ubicado en el sector {Sector}";
        }
        public string ReconocerRecord2()
        {
            return $"con un record de {RecordMes} botellas recolectadas al mes";
        }
    }
}
