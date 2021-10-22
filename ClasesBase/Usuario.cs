namespace ClasesBase
{
    public class Usuario
    {
        private int usu_id;

        public int Usu_id
        {
            get { return usu_id; }
            set { usu_id = value; }
        }
        private string usu_apellido_nombre;

        public string Usu_apellido_nombre
        {
            get { return usu_apellido_nombre; }
            set { usu_apellido_nombre = value; }
        }
        private string usu_nombre_usuario;

        public string Usu_nombre_usuario
        {
            get { return usu_nombre_usuario; }
            set { usu_nombre_usuario = value; }
        }
        private string usr_contraseña;

        public string Usr_contraseña
        {
            get { return usr_contraseña; }
            set { usr_contraseña = value; }
        }
        private int rol_id;

        public int Rol_id
        {
            get { return rol_id; }
            set { rol_id = value; }
        }
    }
}
