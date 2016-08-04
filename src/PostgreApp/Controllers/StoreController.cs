using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PostgreApp.Repository;
using PostgreApp.Models;


namespace PostgreApp.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStoreRepository _storeRepository;

        public StoreController(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var stores = await _storeRepository.GetStoresAsync();
            return View(stores);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Store store)
        {
            if (ModelState.IsValid)
            {
                _storeRepository.InsertStore(store);
                return RedirectToAction("Index");
            }

            return View(store);
        }
    }
}
