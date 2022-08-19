using LeerData;
using Microsoft.EntityFrameworkCore;

using (var db = new AppVentaCursosContext())
{
    // ------------------------------------------------SIMPLE-------------------------------------------------------------
    // Consulta simple con el método AsNoTracking() para traer data de la base de datos
    /*
    var cursos = db.Curso.AsNoTracking(); // devuelve un arreglo de tipo IQueryable
    foreach (var curso in cursos)
    {
        Console.WriteLine(curso.Titulo + " - " + curso.Descripcion);
    }
    */

    // ------------------------------------------------UNO A UNO-------------------------------------------------------------

    // Consulta para una relacion de Uno a Uno
    /*
    var cursos = db.Curso.Include(p => p.Precio).AsNoTracking();
    foreach (var curso in cursos)
    {
        Console.WriteLine(value: $"Curso: {curso.Titulo} - Precio: S/.{curso.Precio.PrecioActual}");
    }
    */

    // ------------------------------------------------UNO A MUCHOS-------------------------------------------------------------

    // Consulta para una relacion de Uno a Muchos
    /*
    var cursos = db.Curso.Include(c => c.Comentarios).AsNoTracking();
    foreach (var curso in cursos)
    {
        Console.WriteLine(value: $"Curso: {curso.Titulo}");
        foreach (var comentario in curso.Comentarios)
        {
            Console.WriteLine(value: $"************** {comentario.ComentarioTexto}");
        }
    }
    */

    // --------------------------------------------------MUCHOS A MUCHOS-----------------------------------------------------------

    // Consulta para una relacion de muchos a muchos
    var cursos = db.Curso.Include(c => c.Instructores).ThenInclude(ci => ci.Instructor);
    foreach (var curso in cursos)
    {
        Console.WriteLine(value: $"Curso: {curso.Titulo}");
        foreach (var link in curso.Instructores)
        {
            Console.WriteLine(value: $"*********** {link.Instructor.Nombre}");
        }
    }
}
