using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ArmoneyWebCore.Models;

namespace ArmoneyWebCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("privacy")]
        public IActionResult Privacy()
        {
            return View();
        }
        [Route("about-us")]
        public IActionResult Aboutus()
        {
            return View();
        }
        [Route("restricted-countries")]
        public IActionResult Restricted()
        {
            return View();
        }
        [Route("faq")]
        public IActionResult Faq()
        {
            return View();
        }
        [Route("fees")]
        public IActionResult Fees()
        {
            return View();
        }
        [Route("vip")]
        public IActionResult Vip()
        {
            return View();
        }
        [Route("security")]
        public IActionResult Security()
        {
            return View();
        }
        [Route("carrers")]
        public IActionResult Carrers()
        {
            return View();
        }
        [Route("proof-of-reserves")]
        public IActionResult ProofReserves()
        {
            return View();
        }
        [Route("liquidity")]
        public IActionResult Liquidity()
        {
            return View();
        }
        [Route("funding-options")]
        public IActionResult FundingOption()
        {
            return View();
        }
        [Route("games")]
        public IActionResult Games()
        {
            return View();
        }
        [Route("buy-bitcoin")]
        public IActionResult BuyBitcoin()
        {
            return View();
        }
        [Route("buy-ethereum")]
        public IActionResult BuyEthereum()
        {
            return View();
        }
        [Route("buy-ripple")]
        public IActionResult BuyRipple()
        {
            return View();
        }
        [Route("buy-litecoin")]
        public IActionResult BuyLitecoin()
        {
            return View();
        }
        [Route("buy-bitcoin-cash")]
        public IActionResult BuyBitcoinCash()
        {
            return View();
        }
        [Route("buy-usdc")]
        public IActionResult BuyUSDC()
        {
            return View();
        }
        [Route("earn-and-list-your-business")]
        public IActionResult Earn()
        {
            return View();
        }
        [Route("competition")]
        public IActionResult Competition()
        {
            return View();
        }
        [Route("contact-us")]
        public IActionResult Contactus()
        {
            return View();
        }
        [Route("inquiries")]
        public IActionResult Inquiries()
        {
            return View();
        }
        [Route("gallery")]
        public IActionResult Gallery()
        {
            return View();
        }
        [Route("news")]
        public IActionResult News()
        {
            return View();
        }
        [Route("milestone")]
        public IActionResult Milestone()
        {
            return View();
        }
        [Route("terms-and-conditions")]
        public IActionResult Terms()
        {
            return View();
        }
        [Route("referral")]
        public IActionResult Referral()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
