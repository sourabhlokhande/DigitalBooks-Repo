using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelService.Model;
using ReaderApi.Services;

namespace ReaderApi.Controllers
{
    [Route("api/Reader")]
    [ApiController]
    public class ReaderController : ControllerBase
    {
        private readonly IReaderService _readerService;
        private readonly IPaymentService _paymentService;
        public ReaderController(IReaderService readerService, IPaymentService paymentService)
        {
           _readerService = readerService;
           _paymentService = paymentService;
        }

        [HttpGet("GetBook")]
        public IActionResult GetBook()
        {
            try
            {
                IEnumerable<Books> result = _readerService.GetBook();
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        [HttpPost("BuyBook")]
        public IActionResult BuyBook(Payment payment)
        {
            try
            {
                var result = _paymentService.BuyBook(payment);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
