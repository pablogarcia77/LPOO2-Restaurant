using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClasesBase
{
    public class Cliente: IDataErrorInfo
    {
        private int cli_id;
        /*validar obligatorio > 0*/
        public int Cli_id
        {
            get { return cli_id; }
            set { cli_id = value; }
        }
        private string cli_apellido;
        /*validar obligatorio*/
        public string Cli_apellido
        {
            get { return cli_apellido; }
            set { cli_apellido = value; }
        }
        private string cli_nombre;
        /*validar obligatorio*/
        public string Cli_nombre
        {
            get { return cli_nombre; }
            set { cli_nombre = value; }
        }
        private string cli_domicilio;

        public string Cli_domicilio
        {
            get { return cli_domicilio; }
            set { cli_domicilio = value; }
        }
        private string cli_telefono;
        /*validar obligatorio*/
        public string Cli_telefono
        {
            get { return cli_telefono; }
            set { cli_telefono = value; }
        }
        private string cli_email;

        public string Cli_email
        {
            get { return cli_email; }
            set { cli_email = value; }
        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get
            {
                string result = null;
                if (columnName == "Cli_id")
                {
                    if (String.IsNullOrEmpty(cli_id.ToString()))
                        result = "Debe ingresar un Id";
                    else if (cli_id <= 0)
                        result = "El Id debe ser mayor a 0";
                }
                if (columnName == "Cli_apellido")
                {
                    if (String.IsNullOrEmpty(cli_apellido))
                        result = "Debe ingresar el Apellido";
                }
                if (columnName == "Cli_nombre")
                {
                    if (String.IsNullOrEmpty(cli_nombre))
                        result = "Debe ingresar el Nombre";
                }
                if (columnName == "Telefono")
                {
                    if (String.IsNullOrEmpty(cli_telefono))
                        result = "Debe ingresar un Telefono";
                }
                return result;
            }
        }

    }
}
