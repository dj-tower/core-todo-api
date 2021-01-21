using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vue_core_todo.Models;

namespace vue_core_todo.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class ChecklistController : ControllerBase {
        private readonly AppDbContext _dbContext;

        public ChecklistController(AppDbContext dbContext) {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<int> Create(ChecklistItem item) {
            _dbContext.ChecklistItems.Add(item);
            await _dbContext.SaveChangesAsync();

            return item.Id;
        }
    }
}
