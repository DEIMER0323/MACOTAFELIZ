using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hola vamos a empezar a trabajar con tabla ");
             //listarDuenoFiltro();
             //AddDueno();
             // BuscarDueno(1);

             //listarVeterinariosFiltrado();
            //AddVeterinario();
            //BuscarVeterinarios(1);

            listarMascotaFiltrado();
            AddMascota();
            //BuscarMascotas(1);
        }
        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Juan",
                Apellidos = "Sin Miedo",
                Direccion = "Bajo un puente",
                Telefono = "1234567891",
                Correo = "juansinmiedo@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }
        
        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                //Cedula = "12222",
                Nombres = "Juan",
                Apellidos = "con Miedo",
                Direccion = "Bajo un puente",
                Telefono = "1234567891",
                TarjetaProfesional = "TP111111111",
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }
         private static void AddMascota()
        {
            var mascota = new Mascota
            {
                //Cedula = "12222",
                Nombre = "braulio",
                Color = "negro",
                Especie = "perro",
                Raza = "labrador",
                
            };
            _repoMascota.AddMascota(mascota);
        }
        
        private static void listarMascotaFiltrado()
        {
            var mascotas = _repoMascota.GetAllMascota();
            foreach (Mascota d in mascotas)
            {
              Console.WriteLine(d.Nombre + " " + d.Color + " " + d.Raza);  
            }
           
        }
         private static void BuscarMascotas(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            
            {
              Console.WriteLine(mascota.Nombre + " " + mascota.Color + " " + mascota.Raza);  
            }
           
        }

        
    }
}
