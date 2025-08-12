using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogClovis.Models;

namespace BlogClovis.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["Mensagem"] = "Olá Mundo";
        // Criar objetos
        Categoria categoria = new();
        categoria.Id = 1;
        categoria.Nome = "Tecnologia";

        Categoria categoria2 = new()
        {
            Id = 2,
            Nome = "IA"
        };

        Categoria eletronico = new(3, "Eletronicos");

        List<Postagem> postagens = [
            new() {
                Id = 1,
                Nome = "JOGOS MENSAIS DA PLAYSTATION PLUS",
                CategoriaId = 1,
                Categoria = categoria,
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Jogos mensais de agosto para membros PlayStation Plus: Lies of P, Day Z, My Hero One’s Justice 2",
                Texto = "Lute contra marionetes macabras em uma versão distorcida de um conto infantil conhecido, use sua inteligência para sobreviver a mapas extensos cheios de ameaças e reviva um anime icônico em primeira mão com a linha de jogos mensais do PlayStation Plus para agosto. Lies of P, Day Z e My Hero One’s Justice 2 estarão disponíveis para os membros do PlayStation Plus a partir de 5 de agosto. Avatares do 15º aniversário do PlayStation Como anunciamos algumas semanas atrás, as comemorações do 15º aniversário do PlayStation Plus continuam a todo vapor, e estamos animados para revelar mais algumas surpresas! A partir de 5 de agosto, os membros do PlayStation Plus poderão reivindicar um conjunto especial de Avatares do 15º Aniversário, com títulos favoritos dos fãs como Cyberpunk 2077, Hogwarts Legacy, Diablo IV, God of War Ragnarök e Twisted Metal, todos disponíveis sem custo adicional. ",
                Thumbnail = "/img/1.jpg",
                Foto = "/img/1.jpg"
            },
          new() {
                Id = 1,
                Nome = "Mais jogos chegam à Promoção de Inverno da PlayStation Store",
                CategoriaId = 1,
                Categoria = categoria,
                DataPostagem = DateTime.Parse("17/07/2025"),
                Descricao = "Incluindo WWE 2K25, Doom: The Dark Ages, Cyberpunk 2077: Ultimate Edition e mais.",
                Texto = "Conforme chegamos ao fim da primeira parte da Promoção de Inverno, a diversão continua, com mais jogos entrando em promoção a partir de hoje*. Visite a página da Promoção de Inverno da PlayStation Store para conferir todos os jogos digitais em promoção, e descobrir qual será sua próxima aventura. *A promoção será atualizada às 00h do dia 29 de julho, e algumas ofertas serão substituídas por outras. A promoção acaba dia 13 de agosto, às 23h59. Algumas ofertas acabarão antes de 13 de agosto. Visite a PlayStation Store para saber mais detalhes das ofertas individuais.",
                Thumbnail = "/img/2.jpg",
                Foto = "/img/2.jpg"
          },

          new() {
                Id = 1,
                Nome = "Project Defiant ganha nome oficial.",
                CategoriaId = 1,
                Categoria = categoria,
                DataPostagem = DateTime.Parse("28/07/2025"),
                Descricao = "Incluindo WWE 2K25, Doom: The Dark Ages, Cyberpunk 2077: Ultimate Edition e mais.",
                Texto = "Conforme anunciado durante o State of Play de junho de 2025, FlexStrike é o primeiro controle sem fio para luta projetado pela Sony Interactive Entertainment. Compatível com PS5 ou PC, por meio de uma conexão com fio ou sem fio com o PlayStation Link, nossa inovadora tecnologia sem fio de latência ultrabaixa, o controle sem fio para luta FlexStrike possui botões de troca mecânica e portas restritivas intercambiáveis sem ferramentas. Isso inclui portas restritivas quadradas, circulares e octogonais que se encaixam nos compartimentos de armazenamento integrados do controle analógico para luta juntamente com o adaptador USB PS Link incluído. Os jogadores podem transportar com facilidade e segurança o controle analógico para luta, todos os seus componentes, como o cabo USB-C incluído e muito mais, para uma noite de luta local, para a casa de um amigo ou para um torneio com o estojo de transporte incluso, e ficar prontos para jogar com a bateria recarregável integrada. ",
                Thumbnail = "/img/3.jpg",
                Foto = "/img/3.jpg"
          },

          new() {
                Id = 1,
                Nome = "Silent Hill f: relatório em primeira mão",
                CategoriaId = 1,
                Categoria = categoria,
                DataPostagem = DateTime.Parse("17/07/2025"),
                Descricao = "Conheça um mundo lindo e ao mesmo tempo assombroso na pele de uma adolescente japonesa nos anos 1960.",
                Texto = "Terror psicológico ambientado no Japão nos anos 1960. A história começa quando Hinako foge de casa para ficar longe do pai irritado. Assim como no remake de 2024 de Silent Hill 2, desenvolvido pela Bloober Team, em Silent Hill f a perspectiva por cima do ombro permite movimentar a câmera com o controle analógico direito. Essa proximidade da visão de Hinako aumenta a tensão e deixa a pessoa ainda mais imersa no jogo. Quando você olha para a floresta ao redor da personagem, fica com uma impressão muito forte de que o perigo está próximo, e a sensação de isolamento e aprisionamento toma conta.",
                Thumbnail = "/img/4.jpg",
                Foto = "/img/4.jpg"
          },


        ];
        return View(postagens);
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
