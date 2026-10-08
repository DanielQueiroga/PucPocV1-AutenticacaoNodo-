using Microsoft.AspNetCore.Mvc;
using PucPocV1.ViewModels;
using PucPocV1.Data;
using PucPocV1.Models;
using Microsoft.AspNetCore.Identity;

namespace PucPocV1.Controllers
{
    
    public class AuthenticateController : Controller
    {
        // CRIANDO VARIAVEL CHAMAMDA _context
        private readonly AppDbContext _context;
        public AuthenticateController(AppDbContext context)
        {
            _context = context;
        }

        //-------------------------- TELA DE CADASTRO -----------------------------------//
        // GET ABRE A TELA

        public IActionResult Registrar()
        {
            return View();
        }

        // METODO POST (RECEBE OS DADOS PREENCHIDOS E PROCESSA ELES)
        [HttpPost]
        public IActionResult Registrar(RegisterViewModel cadastro)
        {
            // Verificar validação dos dados
            if (!ModelState.IsValid)
                return View(cadastro);

            // VARIAVEL "emailexiste" SERÁ CRIADA QUANDO EXISTIR O EMAIL DIGITADO NO BANCO
            bool emailexiste = _context.Usuarios
                .Any(usuario => usuario.Email == cadastro.Email);


            if(emailexiste)
            {
                ModelState.AddModelError("Email", "Este email ja está cadastrado.");
                return View(cadastro);
            }

            // PEGA OS DADOS DA TELA E ARMAZENA NA PROPRIEDADE ESPECIFICA
            var usuario = new Usuario
            {
                NivelAcesso = cadastro.NivelAcesso.Value,
                Nome = cadastro.Nome,
                Email = cadastro.Email,
                Data_Nasc = cadastro.Data_Nasc.Value,
                Genero = cadastro.Genero,
                Escolaridade = cadastro.Escolaridade,
                Ativo_Area = "S",
                Criacao = DateTime.Now
            };

            // HASH PARA SENHA (CRIPTOGRAFAR)
            var escondeSenha = new PasswordHasher<Usuario>();
            usuario.Senha = escondeSenha.HashPassword(usuario, cadastro.Senha);

            // ADD USUARIO NOVO AO BANCO
            _context.Usuarios.Add(usuario);
            // SALVAR ALTERAÇÕES
            _context.SaveChanges();

            ViewBag.Mensagem = "Cadastro realizado com Sucesso😁!";
            return View();
        }
        //======================================= FIM TELA CADASTRO ========================================//

        //--------------------------------------- TELA DE LOGIN -------------------------------------------//
        
        // GET (ABRE) TELA LOGIN
        public IActionResult Login()
        {
            return View();
        }

        // POST - RECEBE OS DADOS DA TELA DE LOGIN
        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            // CONFERE SE OS CAMPOS ESTÃO VALIDOS
            if (!ModelState.IsValid)
                return View(login);

            // PROCURAR EMAIL NO BANCO DE DADOS
            //"FirstOrDefault" --> PROCURA O PRIMEIRO USUARIO QUE TENHA O EMAIL DIGITADO
            var usuario = _context.Usuarios
                .FirstOrDefault(usuario => usuario.Email == login.Email);

            //VERIFICAR SE ENCONTROU ALGUEM
            if (usuario == null)
            {
                ModelState.AddModelError(
                    "", "Email ou senha inválidos.");

                return View(login);
            }

            // VERIFICAR SENHA
            var hashSenha = new PasswordHasher<Usuario>();

            // COMPARA O HASH DA SENHA DIGITADA COM O HASH DO BANCO DE DADOS
            var resultadoSenha = hashSenha.VerifyHashedPassword(
                usuario,
                usuario.Senha,
                login.Senha);

            // SENHA CORRETA?
            if (resultadoSenha == PasswordVerificationResult.Failed)
            {
                ModelState.AddModelError("", "Email ou senha inválidos.");
                return View(login);
            }

            ViewBag.Mensagem = "Lógin válido! ✔️";

            return View(login);
        }

    }
}
