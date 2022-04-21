using ClimaTempo.Models;
using ClimaTempo.Repositories.Interfaces;
using ClimaTempo.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ClimaTempo.Controllers
{
    public class HomeController : Controller
    {

        private readonly IPrevisaoClimaRepository previsaoClimaRepository;
        private readonly IEstadoRepository estadoRepository;
        private readonly ICidadeRepository cidadeRepository;

        public HomeController(IPrevisaoClimaRepository previsaoClimaRepository, IEstadoRepository estadoRepository, ICidadeRepository cidadeRepository)
        {
            this.previsaoClimaRepository = previsaoClimaRepository;
            this.estadoRepository = estadoRepository;
            this.cidadeRepository = cidadeRepository;
        }


        public ActionResult Index()
        {
            var previsaoClimaVM = new PrevisaoClimaViewModel();
            previsaoClimaVM.Previsoes = previsaoClimaVM.Previsoes ?? new List<PrevisaoClima>();
            previsaoClimaVM.CidadesMaisFrias = previsaoClimaRepository.ObterCidadesMaisFrias();
            previsaoClimaVM.CidadesMaisQuentes = previsaoClimaRepository.ObterCidadesMaisQuentes();

            var estados = estadoRepository.ObterTodosEstados().ToList();
            ViewBag.Estados = new SelectList(estados, "Id", "Nome");
         
            return View(previsaoClimaVM);
        }

        public ActionResult About()
        {
            return View();
        }

        public JsonResult CidadeList(int? id)
        {
            var cidadeId = id ?? 0;

            if (cidadeId > 0)
            {
                var cidades = cidadeRepository.ObterTodasCidades(cidadeId);
                return Json(new SelectList(cidades, "Id", "Nome"), JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new SelectList(" "), JsonRequestBehavior.AllowGet);
            }
        }


        public ActionResult ObterPrevisao(int? id)
        {
            var cidadeId = id ?? 0;

            if (cidadeId > 0)
            {
                var previsoes = previsaoClimaRepository.ObterPrevisaoCidadeById(cidadeId).ToList();
                return PartialView("_Previsao", previsoes);
            }

            return PartialView("_Previsao",new List<PrevisaoClima>());

        }


    }
}