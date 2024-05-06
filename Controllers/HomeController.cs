using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Erivelton", "038.000.000-00", "erivelton@gmail.com", "Dog");
        Cliente cliente2 = new Cliente(02, "Erivelton", "038.000.000-00", "erivelton@gmail.com", "Thor");
        Cliente cliente3 = new Cliente(03, "Erivelton", "038.000.000-00", "erivelton@gmail.com", "luke");
        Cliente cliente4 = new Cliente(04, "Erivelton", "038.000.000-00", "erivelton@gmail.com", "Edgar");
        Cliente cliente5 = new Cliente(05, "Erivelton", "038.000.000-00", "erivelton@gmail.com", "Bob");

        //list de Clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);




        ViewBag.listaClientes = listaClientes;


        //instancias do tipo Fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "Fonecedor José", "038.000.000-00", "erivelton@gmail.com", "Dog");
        Fornecedor fornecedor2 = new Fornecedor(02, "Fornecedor Lucas ", "038.000.000-00", "erivelton@gmail.com", "Thor");
        Fornecedor fornecedor3 = new Fornecedor(03, "Fornecedor Matheus", "038.000.000-00", "erivelton@gmail.com", "luke");
        Fornecedor fornecedor4 = new Fornecedor(04, "Fornecedor  Lara", "038.000.000-00", "erivelton@gmail.com", "Edgar");
        Fornecedor fornecedor5 = new Fornecedor(05, "Fornecedor  Maria", "038.000.000-00", "erivelton@gmail.com", "Bob");
        //list de Clientes
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

internal class Clientes
{
}