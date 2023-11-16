using Microsoft.AspNetCore.Mvc;
using Bank.Scoring;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankScoringController : Controller
    {
        ScoringEstimator scoringEstimator = new ScoringEstimator();

        [HttpGet(Name = "GetBankScoring")]
        public int Get(long pesel)
        {
            return scoringEstimator.ComputeScore(pesel);
        }
    }
}
