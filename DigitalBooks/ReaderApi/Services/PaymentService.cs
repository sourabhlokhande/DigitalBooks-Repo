using ModelService.Data;
using ModelService.Model;

namespace ReaderApi.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly ApplicationDbContext _dbContext;

        public PaymentService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public string BuyBook(Payment payment)
        {
            try
            {
                _dbContext.PaymentTbl.Add(payment);
                _dbContext.SaveChanges();
                return $"Transaction Id : {payment.PaymentId} Payment Successfull";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
