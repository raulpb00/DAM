using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace catalogo2018_consola
{
    interface IDAO
    {
        // CRUD -> Create Read Update Delete
        
        bool Conectar(string srv, string port, string db, string user, string pwd);
        void Desconectar();
        bool Conectado();
        List<Dvd> SeleccionarPA(string codigo); // Procedimiento Almacenado de la BD.   call prodedimientoAlmacenado;
        DataTable SeleccionarTB(string codigo);
        List<Dvd> Seleccionar(string codigo);
        int Borrar(string codigo);
        Pais SeleccionarPais(string iso2);
        int Actualizar(Dvd unDVD);
        int Insertar(Dvd unDVD);
    }
}
