using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Maas(Personel per)
        {
            Maas m = getMaas(per);

            return View(m);
        }

        public Maas getMaas(Personel p)
        {
            Maas maas = new Maas();

            if (p.Statu == "Mudur")
            {
                maas.PMaas = 250 * p.GunSayisi;
                if (p.medeniDurum == "Evli")
                {
                    maas.Agi = 250;
                }
                else
                {
                    maas.Agi = 190;
                }
            }

            else if (p.Statu == "Sef")
            {
                maas.PMaas = 175 * p.GunSayisi;
                if (p.medeniDurum == "Evli")
                {
                    maas.Agi = 250;
                }
                else
                {
                    maas.Agi = 190;
                }
            }

            else if (p.Statu == "Memur")
            {
                maas.PMaas = 125 * p.GunSayisi;
                if (p.medeniDurum == "Evli")
                {
                    maas.Agi = 250;
                }
                else
                {
                    maas.Agi = 190;
                }
            }

            return maas;
        }

      

       
    }
}