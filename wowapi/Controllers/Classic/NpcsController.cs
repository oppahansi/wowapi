﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using wowapi.Contracts;
using wowapi.Entities.Models.Classic;
using wowapi.Entities.Models.Search;

namespace wowapi.Controllers.Classic
{
    [Route("api/c/[controller]")]
    public class NpcsController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;

        public NpcsController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetNpcs([FromQuery] CreatureFilterParams filterParams)
        {   
            try
            {
                var creatureList = await _repository.CreatureTemplatesRepo.GetNpcsSearchResultList(filterParams);
                return Ok(creatureList.Take(250));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetNpcs method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{type}", Name = "NpcsByType")]
        public async Task<IActionResult> GetNpcsByType(byte type, [FromQuery] CreatureFilterParams filterParams)
        {
            try
            {
                var creatureTemplates = await _repository.CreatureTemplatesRepo.GetNpcsByTypeSearchResultListAsync(type, filterParams);
                return Ok(creatureTemplates.Take(250));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetNpcsByType action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        
        [HttpGet("1/{family}", Name = "NpcsByFamily")]
        public async Task<IActionResult> GetNpcsByFamily(sbyte family, [FromQuery] CreatureFilterParams filterParams)
        {
            try
            {
                var creatureTemplates = await _repository.CreatureTemplatesRepo.GetNpcsByFamilySearchResultListAsync(family, filterParams);
                return Ok(creatureTemplates.Take(250));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetNpcsByFamily action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}