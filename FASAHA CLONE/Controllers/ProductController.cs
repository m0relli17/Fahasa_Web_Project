using Microsoft.AspNetCore.Mvc;

namespace FASAHA_CLONE.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(string keyword)
        {
            List<string> books = new List<string>
            {
                "Doraemon",
                "Conan",
                "One Piece",
                "Harry Potter",
                "Nhà Giả Kim",
                "Đắc Nhân Tâm",
                "Thám Tử Lừng Danh Conan",
                "Thanh Gươm Diệt Quỷ"
            };

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                books = books
                    .Where(book => book.Contains(
                        keyword.Trim(),
                        StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            ViewBag.Keyword = keyword;

            return View(books);
        }

        public IActionResult Details(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}
