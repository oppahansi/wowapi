﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace wowapi.Controllers.Classic
{
    [Route("api/c/npcs")]
    public class CreatureTemplateController : Controller
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;

        public CreatureTemplateController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetNpcsSearchResultList()
        {
            try
            {
                var creatureList = await _repository.CreatureTemplateRepository.GetNpcsSearchResultList();               
                return Ok(creatureList.Take(250));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetAllCreatureTemplates method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{type}", Name = "CreatureTemplatesByType")]
        public async Task<IActionResult> GetAllCreatureTemplateByType(byte type)
        {
            try
            {
                var creatureTemplates = await _repository.CreatureTemplateRepository.GetNpcsByTypeSearchResultList(type);
                return Ok(creatureTemplates.Take(250));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllCreatureTemplateByType action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}