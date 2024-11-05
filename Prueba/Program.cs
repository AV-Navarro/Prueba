using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viajeros;
using static Viajeros.Autenticacion;

namespace Prueba
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            var autenticacion = new Autenticacion();
            var publicaciones = await autenticacion.ObtenerPublicaciones();

            // Imprimir cada publicación en la consola
            foreach (var publicacion in publicaciones)
            {
                Console.WriteLine($"ID: {publicacion.Id}, Título: {publicacion.Title}");
            }

            // Obtener comentarios
            var comentarios = await autenticacion.ObtenerPublicaciones();
            foreach (var comentario in comentarios)
            {
                Console.WriteLine($"Comentario ID: {comentario.Id}, Comentario: {comentario.Body}");
            }

            // Crear una nueva publicación
            var nuevaPublicacion = new Post { UserId = 1, Title = "Nueva Publicación", Body = "Contenido de la nueva publicación" };
            bool resultadoCreacion = await autenticacion.CrearPublicacion(nuevaPublicacion);
            Console.WriteLine($"¿Publicación creada? {resultadoCreacion}");

           
            // Actualizar una publicación
            /*var publicacionActualizada = new Post { UserId = 1, Title = "Título Actualizado", Body = "Contenido actualizado" };            
            bool resultadoActualizacion = await autenticacion.ActualizarPublicacion(1, publicacionActualizada);
            Console.WriteLine($"¿Publicación actualizada? {resultadoActualizacion}");*/

        }
    }
}
