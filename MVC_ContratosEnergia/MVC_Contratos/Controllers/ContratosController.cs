using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Contratos.Models.Context;
using MVC_Contratos.Models.Entidades;

namespace MVC_Contratos.Controllers
{
    public class ContratosController : Controller
    {
        EstadiosContext _dbContext = new EstadiosContext();
        List<Clientes> cl;
        List<TiposContratos> tipos;
        Contratos c;

        // GET: Contratos
        public ActionResult Index()
        {
            List<Contratos> c = _dbContext.Contratos.ToList();
            cl = _dbContext.Clientes.ToList();
            tipos = _dbContext.TiposContratos.ToList();

            //var lista =
            //    from contrato in c
            //    join cliente in cl
            //    on contrato.Cliente equals cliente.Id
            //    join tc in tipos
            //    on contrato.TipoContrato equals tc.Id
            //    select new { Cliente = cliente.Nombre, TipoContrato = tc.Descripcion,
            //        FechaInicio = contrato.FechaInicio, FechaFinal = contrato.FechaFinal, Monto = contrato.Monto};

            //return View(lista);
            return View(c);
        }

        // GET: Contratos/Details/5
        public ActionResult Details(int id)
        {
            c = _dbContext.Contratos.Find(id);
            Clientes cliente = _dbContext.Clientes.ToList().Find(x => x.Id == c.Cliente);
            TiposContratos tipo = _dbContext.TiposContratos.ToList().Find(x => x.Id == c.TipoContrato);
            return View(c);
        }

        // GET: Contratos/Create
        public ActionResult Create()
        {
            cl = _dbContext.Clientes.ToList();
            ViewBag.cliente = cl;

            tipos = _dbContext.TiposContratos.ToList();
            ViewBag.tipos = tipos;

            return View();
        }

        // POST: Contratos/Create
        [HttpPost]
        public ActionResult Create(Contratos c)
        {
            try
            {
                _dbContext.Contratos.Add(c);
                _dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contratos/Edit/5
        public ActionResult Edit(int id)
        {
            Clientes cliente = _dbContext.Clientes.ToList().Find(x => x.Id == c.Cliente);
            TiposContratos tipo = _dbContext.TiposContratos.ToList().Find(x => x.Id == c.TipoContrato);

            cl = _dbContext.Clientes.ToList();
            ViewBag.cliente = cl;

            tipos = _dbContext.TiposContratos.ToList();
            ViewBag.tipos = tipos;

            c = _dbContext.Contratos.Find(id);

            return View(c);
        }

        // POST: Contratos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Contratos c)
        {
            try
            {
                _dbContext.Entry(c).State = EntityState.Modified;
                _dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contratos/Delete/5
        public ActionResult Delete(int id)
        {
            c = _dbContext.Contratos.Find(id);
            Clientes cliente = _dbContext.Clientes.ToList().Find(x => x.Id == c.Cliente);
            TiposContratos tipo = _dbContext.TiposContratos.ToList().Find(x => x.Id == c.TipoContrato);
            return View(c);
        }

        // POST: Contratos/Delete/5
        [HttpPost]
        public ActionResult Delete(Contratos c)
        {
            try
            {
                _dbContext.Entry(c).State = EntityState.Deleted;
                _dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
