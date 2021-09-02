using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fabrizzi_TP_Integrador
{
    class Rol
    { //rol_IdRol int identity(1,1) primary key ,
     //   rol_NombreDeRol varchar(50) not null,
					//rol_Descripcion varchar(255), 
					//rol_Area varchar(50) not null,
					//rol_FechaDeAlta date,
     //               rol_FechaDeBaja date,
					//rol_FechaDeMod date,
     //               rol_Estado varchar(20));
        public int IdRol { get; set; }
        public String NombreRol { get; set; }
        public String DescripcionRol { get; set; }
        public String Area { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public DateTime FechaMod { get; set; }
        public String Estado { get; set; }
    }
}
