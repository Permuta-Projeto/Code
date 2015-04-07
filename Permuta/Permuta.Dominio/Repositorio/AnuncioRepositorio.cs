using Permuta.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permuta.Dominio.Repositorio
{
    public class AnuncioRepositorio
    {
        private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Anuncio> Anuncios
        {
            get { return _context.Anuncios; }
        }




        
        public void Salvar(Anuncio anuncio)
        {
            if (anuncio.AnuncioID == 0)
            {
                //Salvado
                _context.Anuncios.Add(anuncio);
            }
            else
            {
                //Alteração
                Anuncio oft = _context.Anuncios.Find(anuncio.AnuncioID);

                if (oft != null)
                {
                    oft.Titulo = anuncio.Titulo;
                    oft.Descricao = anuncio.Descricao;
                    oft.CategoriaID = anuncio.CategoriaID;
                    oft.Estado = anuncio.Estado;
                    oft.Bairro = anuncio.Bairro;
                    oft.Foto = anuncio.Foto;
                    oft.Tipo_Oferta = anuncio.Tipo_Oferta;
                }

            }

            _context.SaveChanges();
        }


        //Excluir

        public Anuncio Excluir(int AnuncioID)
        {

            Anuncio anun = _context.Anuncios.Find(AnuncioID);

            if (anun != null)
            {
                _context.Anuncios.Remove(anun);
                // _context.SaveChanges();
            }

            return anun;
        }
    }
}
