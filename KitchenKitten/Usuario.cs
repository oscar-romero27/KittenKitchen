using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenKitten
{
    public class Usuario
    {
        private int p_usuario_id;
        public int usuario_id
        {
            get
            {
                return p_usuario_id;
            }
            set
            {
                p_usuario_id = value;
            }
        }
        private string p_nombre;
        public string nombre
        {
            get
            {
                return p_nombre;
            }
            set
            {
                p_nombre = value;
            }
        }
        private string p_apellidos;
        public string apellidos
        {
            get
            {
                return p_apellidos;
            }
            set
            {
                p_apellidos = value;
            }
        }
        private string p_correo_electronico;
        public string correo_electronico
        {
            get
            {
                return p_correo_electronico;
            }
            set
            {
                p_correo_electronico = value;
            }
        }
        private string p_contrasenia;
        public string contrasenia
        {
            get
            {
                return p_contrasenia;
            }
            set
            {
                p_contrasenia = value;
            }
        }

        public Usuario(int usuario_id, string nombre, string apellidos, string correo_electronico, string contrasenia)
        {
            this.usuario_id = usuario_id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.correo_electronico = correo_electronico;
            this.contrasenia = contrasenia;
        }
        public Usuario()
        {

        }
    }
}
