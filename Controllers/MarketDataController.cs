using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using netdemo20252.Models;

namespace netdemo20252.Controllers;

public class MarketDataController : Controller
{
    private readonly ILogger<MarketDataController> _logger;

    public MarketDataController(ILogger<MarketDataController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        _logger.LogInformation("Fetching market data...");
        var instruments = new List<Instrument>
        {
                new Instrument { Ticker = "AAPL", Nombre = "Apple Inc.", Sector = "Technology", Moneda = "USD", PrecioActual = 229.35m, CapitalizacionUSD = 3005779833320m },
                new Instrument { Ticker = "MSFT", Nombre = "Microsoft Corp.", Sector = "Technology", Moneda = "USD", PrecioActual = 522.04m, CapitalizacionUSD = 2790642591197m },
                new Instrument { Ticker = "GOOGL", Nombre = "Alphabet Inc.", Sector = "Communication Services", Moneda = "USD", PrecioActual = 201.42m, CapitalizacionUSD = 2131325620000m },
                new Instrument { Ticker = "AMZN", Nombre = "Amazon.com Inc.", Sector = "Consumer Discretionary", Moneda = "USD", PrecioActual = 222.69m, CapitalizacionUSD = 2300000000000m },
                new Instrument { Ticker = "META", Nombre = "Meta Platforms Inc.", Sector = "Communication Services", Moneda = "USD", PrecioActual = 769.30m, CapitalizacionUSD = 1855799799214m },
                new Instrument { Ticker = "NFLX", Nombre = "Netflix Inc.", Sector = "Communication Services", Moneda = "USD", PrecioActual = 1211.64m, CapitalizacionUSD = 534000000000m },
                new Instrument { Ticker = "TSLA", Nombre = "Tesla Inc.", Sector = "Consumer Discretionary", Moneda = "USD", PrecioActual = 329.65m, CapitalizacionUSD = 1040000000000m },
                new Instrument { Ticker = "NVDA", Nombre = "NVIDIA Corp.", Sector = "Technology", Moneda = "USD", PrecioActual = 925.18m, CapitalizacionUSD = 2300000000000m },
                new Instrument { Ticker = "INTC", Nombre = "Intel Corp.", Sector = "Technology", Moneda = "USD", PrecioActual = 34.75m, CapitalizacionUSD = 146000000000m },
                new Instrument { Ticker = "ADBE", Nombre = "Adobe Inc.", Sector = "Technology", Moneda = "USD", PrecioActual = 522.89m, CapitalizacionUSD = 236000000000m }
        };
        return View(instruments);
    }

    public IActionResult Details(string id)
    {
        _logger.LogInformation($"Fetching details for instrument: {id}");
        var instrument = new Instrument
        {
            Ticker = id,
            Nombre = "Instrument Name",
            Sector = "Sector",
            Moneda = "USD",
            PrecioActual = 100.00m,
            CapitalizacionUSD = 1000000000m
        };
        return View(instrument);
    }
}