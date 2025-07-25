using Microsoft.AspNetCore.Mvc;
using Microsoft.ML;
using SentimentWebApp.Models;
using System.IO;

namespace SentimentWebApp.Controllers
{
    public class PredictionController : Controller
    {
        private readonly string _modelPath = "wwwroot/models/sentiment_model.zip";
        private readonly PredictionEngine<SentimentData, SentimentPrediction> _predictionEngine;

        public PredictionController()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(_modelPath, out var modelInputSchema);
            _predictionEngine = mlContext.Model.CreatePredictionEngine<SentimentData, SentimentPrediction>(mlModel);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new SentimentPrediction());
        }

        [HttpPost]
        public IActionResult Index(SentimentData input)
        {
            var result = _predictionEngine.Predict(input);
            return View(result);
        }
    }
}
