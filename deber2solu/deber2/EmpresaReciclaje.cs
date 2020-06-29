namespace deber2
{
    class EmpresaReciclaje
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Record { get; set; }

        public Empleado1 Empleado1 { get; set; }

        public Empleado2 Empleado2 { get; set; }

        public Empleado3 Empleado3 { get; set; }
        public Premio Premio1 { get; set; }
        public Premio Premio2 { get; set; }
        public Premio Premio3 { get; set; }

        public string Presentarse()
        {
            return $"La empresa {Nombre} completamente dedicada al reciclaje";
        }
        public string Ubicarse()
        {
            return $"Esta ubicada en {Direccion}, CDL Ejercito plan II Oe2 y S46F lote 102";
        }
        public string Contactarse()
        {
            return $"Contacto {Telefono}, de lunes a viernes en horario 8:00 a 13:00 y 14:00 a 16:00";
        }
        public string Reconocer()
        {
            return $"Con un de {Record} botellas recicladas al año,presenta sus mejores empleados:";
        }

        public string Presentar1()
        {
            return Empleado1.Presentar1();
        }
        public string Reconocer1()
        {
            return Empleado1.ReconocerRecord1();
        }

        public string Presentar2()
        {
            return Empleado2.Presentar2();
        }
        public string Reconocer2()
        {
            return Empleado2.ReconocerRecord2();
        }

        public string Presentar3()
        {
            return Empleado3.Presentar3();
        }
        public string Reconocer3()
        {
            return Empleado3.ReconocerRecord3();
        }
        public string Indicar()
        {
            return Premio1.InducarNum();
        }
        public string Indicar2()
        {
            return Premio2.InducarNum2();
        }
        public string Indicar3()
        {
            return Premio3.InducarNum3();
        }
    }
}
