using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ErrorsController : BaseController
    {
        private readonly StoreContext _context;

        public ErrorsController(StoreContext context)
        {
            _context = context;
        }

       [HttpGet("notfound")]
        public ActionResult NotFoundMethod()
        {
            var category = _context.Categories.Find(42);

            if (category == null) return NotFound();

            return Ok();
        }

          [HttpGet("servererror")]
        public ActionResult ServerErrorMethod()
        {
            var category = _context.Categories.Find(42);

            return Ok(category.ToString());
        }

          [HttpGet("badrequest")]
        public ActionResult BadRequestMethod()
        {
            return BadRequest();
        }

          [HttpGet("badrequest/{id}")]
        public ActionResult BadIdMethod(int id)
        {
            return Ok();
        }

    }
}