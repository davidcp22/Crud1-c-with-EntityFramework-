using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using Entities;
using System.ComponentModel;

namespace Layer
{
    public class AlumnoBL
    {
        public BindingList<AlumnoDto> ListarAlumnos()
        {
            try
            {
                using (personaEntities dbContext = new personaEntities())
                {
                    List<AlumnoDto> query = (from n in dbContext.alumno
                                 select new AlumnoDto

                                     {
                                         id_alumno = n.id_alumno,
                                         Nombre = n.Nombre,
                                         Apellido = n.Apellido,
                                         Telefono = n.Telefono,
                                         FechaNacimiento = n.FechaNacimiento

                                     }).ToList();
                    BindingList<AlumnoDto> Result = new BindingList<AlumnoDto>(query);
                    return Result;

                }


            }
            catch(Exception)
            {
                throw;
            }
        }

        public void ActulizarAlumno(List<AlumnoDto> TempInsert, List<AlumnoDto> TempEdit, List<AlumnoDto> TempDelete)
        {
            try
            {
                using (personaEntities dbContext = new personaEntities())
                {
                    foreach (AlumnoDto Alumno in TempInsert)
                    {
                        alumno entidad = new alumno();
                        entidad.Nombre = Alumno.Nombre;
                        entidad.Apellido = Alumno.Apellido;
                        entidad.Telefono = Alumno.Telefono;

                        dbContext.alumno.Add(entidad);

                    }
                    foreach (AlumnoDto Alumno in TempEdit)
                    {
                        alumno entidad =(from n in dbContext.alumno
                                        where n.id_alumno==Alumno.id_alumno
                                        select n).FirstOrDefault();

                        entidad.Nombre = Alumno.Nombre;
                        entidad.Apellido = Alumno.Apellido;
                        entidad.Telefono = Alumno.Telefono;

                        dbContext.Entry(entidad).CurrentValues.SetValues(entidad);
                    }
                    foreach (AlumnoDto Alumno in TempDelete)
                    {
                        alumno entidad = (from n in dbContext.alumno
                                          where n.id_alumno == Alumno.id_alumno
                                          select n).FirstOrDefault();
                        dbContext.alumno.Remove(entidad);

                    }
                    dbContext.SaveChanges();
                }


            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
