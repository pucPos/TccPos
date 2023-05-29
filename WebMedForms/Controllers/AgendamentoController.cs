﻿using System;
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
    public class AgendamentoController : Controller
    {
        private readonly Contexto _context;

        public AgendamentoController(Contexto context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
              return _context.Solicitacao != null ?
                          View(await GetSolicitacoes().Where(x => x.CodStatus == 2).ToListAsync()) :
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,CodStatus,NomeMedicoSolicitante,CrmMedicoSolicitante,ChaveAutenticacao,NomePaciente,CPF,RG,DataNascimento,CadUnicoSaude,Telefone,Celular,Email,Endereco,Complemento,Cidade,Estado,CEP,CID,IndicacaoMedica,IndicacaoTratamento,Prioridade,DataAgendamento1,DataAgendamento2,DataAgendamento3")] Solicitacao solicitacao)
        {
            if (id != solicitacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    solicitacao.CodStatus = 3;
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

        private bool SolicitacaoExists(int id)
        {
          return (_context.Solicitacao?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
