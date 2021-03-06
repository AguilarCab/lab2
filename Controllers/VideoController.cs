﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using System.Data;
using System.Data.SqlClient;
using MVCLaboratorio.Utilerias;


namespace MVCLaboratorio.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()//Ver video//
        {

            ViewData["Videos"] = BaseHelper.ejecutarConsulta("Select * from Videos", CommandType.Text);
            return View();
        }

        public ActionResult Create()//crear video, muestra la interfaz//
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(int idVideo, string titulo, int repro, string url)
        {

            //guardar video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));

            
            BaseHelper.ejecutarSentencia("sp_video_insertar", CommandType.StoredProcedure, parametros);


            return RedirectToAction("Index","Video");
        }

        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Eliminarregistros()
        {
            string error = string.Empty;
            int registros = 0;
            List<SqlParameter> parametros = new List<SqlParameter>();
            try
            {
                int idVideo = Convert.ToInt16(Request.Form["idVideo"]);
                parametros.Add(new SqlParameter("@idVideo", idVideo));
                registros = BaseHelper.ejecutarEliminar("DELETE FROM Videos " + " WHERE idVideo = @idVideo", CommandType.Text, out error, parametros);
            }

            catch (Exception e) 
            {
                error = e.Message;
            }

            return View();
        }

        public ActionResult Edit()//
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int idVideo, string titulo, int repro, string url)
        {
            return View();
        }


    }
}
