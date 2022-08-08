using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Nogheric.Models
{
    public class Modelo : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'Modelo' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'Nogheric.Models.Modelo' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'Modelo'  en el archivo de configuración de la aplicación.
        public Modelo()
            : base("name=Modelo.cs")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    public class PageIndex
    {
        public int Id { get; set; }
        public string Head { get; set; }
        public string Body { get; set; }
        public string Foot { get; set; }
        public int Language { get; set; }

    }

    public class VideoHead
    {
        public int Id { get; set; }
        public string ApiKey { get; set; }
        public string Channel { get; set; }
        public List<VideoDetail> Details { get; set; }
    }

    public class VideoDetail
    {
        public int Id { get; set; }
        public int VideoHeadId { get; set; }
        public int Count { get; set; }
        public string Links { get; set; }

    }

    public class SocialNetWork
    {
        public int Id { get; set; }
        public string FaceBook { get; set; }
        public string Twitter { get; set; }
        public string YouTube { get; set; }
        public string Linkedin { get; set; }
        public string TikTok { get; set; }
        public string Instagram { get; set; }
        public string WebPage { get; set; }
        public string Other { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}