using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMedForms.Data;
using WebMedForms.Models;

namespace WebMedForms.Controllers
{
    public class SolicitacaoController : Controller
    {
        private readonly Contexto _context;

        public SolicitacaoController(Contexto context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string role)
        {
              return _context.Solicitacao != null ? 
                          //View(await _context.Solicitacao.ToListAsync()) :
                          View(await GetSolicitacoes().Where(x=>x.CodStatus==1).ToListAsync()) :
                          Problem("Entity set 'Contexto.Solicitacao'  is null.");
        }

        public IQueryable<Solicitacao> GetSolicitacoes()
        {
            return _context.Solicitacao.AsQueryable();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Solicitacao == null)
            {
                return NotFound();
            }

            var solicitacao = await _context.Solicitacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitacao == null)
            {
                return NotFound();
            }

            return View(solicitacao);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeMedicoSolicitante,CrmMedicoSolicitante,ChaveAutenticacao,NomePaciente,CPF,RG,CadUnicoSaude,Cpf,Telefone,Celular,Email,Endereco,Complemento,Cidade,Estado,CEP,CID,IndicacaoMedica,IndicacaoTratamento,CodStatus,DataNascimento")] Solicitacao solicitacao)
        {
            if (ModelState.IsValid)
            {
                solicitacao.CodStatus = 1;
                solicitacao.Prioridade = "Baixa";
                _context.Add(solicitacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(solicitacao);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Solicitacao == null)
            {
                return NotFound();
            }

            var solicitacao = await _context.Solicitacao.FindAsync(id);
            if (solicitacao == null)
            {
                return NotFound();
            }
            return View(solicitacao);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeMedicoSolicitante,CrmMedicoSolicitante,ChaveAutenticacao,NomePaciente,CPF,RG,CadUnicoSaude,Cpf,Telefone,Celular,Email,Endereco,Complemento,Cidade,Estado,CEP,CID,IndicacaoMedica,IndicacaoTratamento,CodStatus,DataNascimento,Prioridade")] Solicitacao solicitacao)
        {
            if (id != solicitacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    solicitacao.CodStatus = 1;
                    solicitacao.Prioridade = "Baixa";
                    _context.Update(solicitacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolicitacaoExists(solicitacao.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(solicitacao);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Solicitacao == null)
            {
                return NotFound();
            }

            var solicitacao = await _context.Solicitacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitacao == null)
            {
                return NotFound();
            }

            return View(solicitacao);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Solicitacao == null)
            {
                return Problem("Entity set 'Contexto.Solicitacao'  is null.");
            }
            var solicitacao = await _context.Solicitacao.FindAsync(id);
            if (solicitacao != null)
            {
                _context.Solicitacao.Remove(solicitacao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SolicitacaoExists(int id)
        {
          return (_context.Solicitacao?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
