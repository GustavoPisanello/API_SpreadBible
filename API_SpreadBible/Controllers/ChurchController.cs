using API_SpreadBible.DataBase;
using API_SpreadBible.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_SpreadBible.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChurchController : Controller
    {
        private readonly ChurchDBContext dbContext;

        public ChurchController(ChurchDBContext dbContext) {
            this.dbContext = dbContext;        
        }
        
        // Método que recupera todas as Igrejas Cadastradas
        [HttpGet]
        public async Task<IActionResult> GetAllchurches()
        {
            return Ok(await dbContext.Churches.ToListAsync());
            
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetChurch([FromRoute] Guid id)
        {
            var church = dbContext.Churches.Find(id);
            if (church != null) { 
                return Ok(church);
            }
            return NotFound();
        }
        // Método queadiciona novas Igrejas Cadastradas
        [HttpPost]
        public async Task<IActionResult> AddChurch(AddChurchRequest addChurchRequest)
        {
            var newChurch = new Church()
            {
                ChurchId = Guid.NewGuid(),
                ChurchName = addChurchRequest.ChurchName,
                ChurchAddress = addChurchRequest.ChurchAddress,
                ChurchCEP = addChurchRequest.ChurchCEP,
                ChurchTel = addChurchRequest.ChurchTel,
                ChurchUF = addChurchRequest.ChurchUF
            };

           await dbContext.Churches.AddAsync(newChurch);
           await dbContext.SaveChangesAsync();

            return Ok(newChurch);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateChurch([FromRoute] Guid id, UpdateChurchRequest updateChurchRequest)
        {
            var church = dbContext.Churches.Find(id);

            if(church != null)
            {
                church.ChurchName = updateChurchRequest.ChurchName;
                church.ChurchAddress = updateChurchRequest.ChurchAddress; ;
                church.ChurchCEP = updateChurchRequest.ChurchCEP;
                church.ChurchUF = updateChurchRequest.ChurchUF;
                church.ChurchTel = updateChurchRequest.ChurchTel;
               
                await dbContext.SaveChangesAsync();
            
                return Ok(church);  
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteChurch([FromRoute] Guid id)
        {
           var church = await dbContext.Churches.FindAsync(id);

            if(church != null)
            {
                dbContext.Remove(church);
                await dbContext.SaveChangesAsync();
                return Ok("A igreja " + church.ChurchName + " foi deletada");
            }
            return NotFound();
        }
    }
}
